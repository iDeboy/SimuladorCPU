using System;
using SimuladorCPU.Util;
using System.Collections;

namespace SimuladorCPU.Modelos {
    public sealed class BlockProcessModel : IEnumerable<ProcessModel> {

        #region Properties
        public ProcessModel? RunningProcess { get; private set; }
        public ProcessModel? BlockedProcess { get; private set; }
        public IQueue ProcessList { get; }
        public IQueue ReadyProcessList { get; }
        public IQueue BlockedProcessList { get; }
        public IQueue FinishedProcessList { get; }
        public bool Running => FinishedProcessList.Count() != ProcessList.Count();
        public uint Quantum { get; }
        public bool IsReady => AutoValidate();
        #endregion

        public BlockProcessModel(uint quantum, IEnumerable<ProcessModel> list) {
            ProcessList = new GeneralQueue(list);
            ReadyProcessList = new QueueReady();
            BlockedProcessList = new QueueBlocked();
            FinishedProcessList = new QueueFinished();
            Quantum = quantum;
        }

        // Añadir procesos al bloque de control de procesos para despues cargarlos en memoria
        public void AddProcess(ProcessModel? process) {

            if (process is null) return;

            ProcessList.Insert(process);
        }

        // Cargar los procesos en memoria enviandolos a la lista de procesos listos
        public void LoadQueue() {

            ReadyProcessList.Clear();

            foreach (var process in this) {
                ReadyProcessList.Insert(process);
            }
        }

        // Ejecutar el primer proceso de la lista de procesos y removerlo
        public void Dispatch() {

            if (!ReadyProcessList.Any()) {
                RunningProcess = null;
                return;
            }

            RunningProcess = ReadyProcessList.Peek()!;
            ReadyProcessList.Remove();

            RunningProcess.State = ProcessState.Running;

        }
        public void WorkDone() {
            if (RunningProcess is null) return;

            FinishedProcessList.Insert(RunningProcess);
            RunningProcess = null;
        }

        // Al proceso actual se le acabo el tiempo
        public void TimeOut() {
            if (RunningProcess is null) return;

            ReadyProcessList.Insert(RunningProcess);
            RunningProcess = null;
        }

        // Bloquear el proceso actual porque tuvo una interrupción de entrada / salida
        public void Block() {
            if (RunningProcess is null) return;

            BlockedProcessList.Insert(RunningProcess);
            RunningProcess = null;

            BlockedProcess = GetRandomBLockedProcess();
        }

        // Liberar un proceso de la lista de bloqueados
        public void Realese() {
            if (BlockedProcess is null) return;

            BlockedProcessList.Remove(BlockedProcess);
            ReadyProcessList.Insert(BlockedProcess);

            BlockedProcess = GetRandomBLockedProcess();

        }
        public void Clear() {
            ProcessList.Clear();
            ReadyProcessList.Clear();
            BlockedProcessList.Clear();
            FinishedProcessList.Clear();
        }

        public IEnumerator<ProcessModel> GetEnumerator() {
            return ProcessList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return ((IEnumerable)ProcessList).GetEnumerator();
        }

        public override string ToString() {
            return ProcessList.ToString();
        }

        private bool AutoValidate() {
            if (!this.Any()) return false;

            if (Quantum == 0) return false;

            return true;
        }

        private ProcessModel? GetRandomBLockedProcess() {
            return BlockedProcessList.PeekRandom();
        }

        // See: https://www.youtube.com/watch?v=LwTz4W_bRuo&t=535s

        // Inner classes

        public class GeneralQueue : Queue {
            public GeneralQueue(IEnumerable<ProcessModel> list) :
                base(ProcessState.None, list) { }
        }

        public class QueueReady : Queue {

            public QueueReady()
                : base(ProcessState.Ready) { }

        }

        public class QueueBlocked : Queue {

            public QueueBlocked()
                : base(ProcessState.Blocked) { }

        }

        public class QueueFinished : Queue {

            public QueueFinished()
                : base(ProcessState.Finished) { }

        }

    }

}
