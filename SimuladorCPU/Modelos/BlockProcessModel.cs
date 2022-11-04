using SimuladorCPU.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCPU.Modelos {
    public sealed class BlockProcessModel : IEnumerable<ProcessModel> {
        private ProcessModel? RunningProcess { get; set; }
        public IQueue ProcessList { get; }
        public IQueue ReadyProcessList { get; }
        public IQueue BlockedProcessList { get; }
        public IQueue FinishedProcessList { get; }
        public bool Running { get; private set; }
        public uint Quantum { get; set; }

        public BlockProcessModel() {
            ProcessList = new GeneralQueue();
            ReadyProcessList = new QueueReady();
            BlockedProcessList = new QueueBlocked();
            FinishedProcessList = new QueueFinished();
            Running = false;
        }

        public async void Run() {

            if (!this.Any()) return;

            if (Quantum == 0) return;

            Running = true;
            await LoadQueueAsync();

            while (Running) {

                Dispatch();

            }

        }

        private uint GeneratePId() {

            uint pId = (uint)new Random().Next(999);

            // Si otro proceso ya tiene esa id, vuelvo a generar otra
            while (this.Any(p => p.Id == pId)) pId = GeneratePId();

            return pId;
        }

        // Añadir procesos al bloque de control de procesos para despues cargarlos en memoria
        public void AddProcess(ProcessModel? process) {

            if (process is null) return;

            process.Id = GeneratePId();

            ProcessList.Insert(process);
        }

        // Cargar los procesos en memoria enviandolos a la lista de procesos listos
        private void LoadQueue() {

            foreach (var process in this) ReadyProcessList.Insert(process);

        }

        private Task LoadQueueAsync() {

            List<Task> tasks = new();

            foreach (var process in this) tasks.Add(ReadyProcessList.InsertAsync(process));

            return Task.WhenAll(tasks);
        }

        // Ejecutar el primer proceso de la lista de procesos y removerlo
        private void Dispatch() {

            if (!ReadyProcessList.Any()) {
                RunningProcess = null;
                return;
            }

            RunningProcess = ReadyProcessList.Peek()!;
            ReadyProcessList.Remove();

            RunningProcess.State = ProcessState.Running;
        }
        public void Clear() {
            ProcessList.Clear();
            ReadyProcessList.Clear();
            BlockedProcessList.Clear();
            FinishedProcessList.Clear();
            Running = false;
            Quantum = 0;
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

        // See: https://www.youtube.com/watch?v=LwTz4W_bRuo&t=535s

        // Tiempo agotado del proceso actual y pasa al siguiente en la lista
        /*
        public void ContextChange() {

            if (RunningProcess is null) return;

            var oldProcess = CurrentProcess;

            ReadyProcessList.Add(oldProcess);

            Dispatch();
        }

        // Proceso actual finalizo y pasar al siguiente en la lista
        public void Finish() {

            if (CurrentProcess is null) return;

            FinishedProcessList.Add(CurrentProcess);

            Dispatch();

        }

        // El proceso actual tuvo una interrupción de entrada / salida y pasar al siguiente
        public void Interrupt() {

            if (CurrentProcess is null) return;

            BlockedProcessList.Add(CurrentProcess);

            Dispatch();

        }*/

        // Inner classes

        public class GeneralQueue : Queue {
            public GeneralQueue() :
                base(ProcessState.None) { }
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
