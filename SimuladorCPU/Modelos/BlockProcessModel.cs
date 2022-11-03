using SimuladorCPU.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCPU.Modelos {
    public class BlockProcessModel {
        private uint CurrentIndex { get; set; }
        public ProcessModel? CurrentProcess { get; private set; }
        public List<ProcessModel> ProcessList { get; }
        public ListReadyProcess ReadyProcessList { get; }
        public ListBlockedProcess BlockedProcessList { get; }
        public ListFinishedProcess FinishedProcessList { get; }

        // Events
        public event ProcessEventHandler? AddingProcess;
        public event ProcessEventHandler? LoadingProcess;
        public event ProcessEventHandler? ContextChanged;
        public event ProcessEventHandler? DispatchingProcess;
        public event ProcessEventHandler? InterruptingProcess;
        public event ProcessEventHandler? FinishingProcess;

        public BlockProcessModel() {
            ProcessList = new();
            ReadyProcessList = new();
            BlockedProcessList = new();
            FinishedProcessList = new();
            CurrentIndex = 0;
        }

        // Añadir procesos al bloque de control de procesos para despues cargarlos en memoria
        public void AddProcess(ProcessModel? process) {

            if (process is null) return;

            CurrentIndex++;

            process.Id = CurrentIndex;

            ProcessList.Add(process);
            OnAddingProcess(new(process));
        }

        public void AddProcesses(IEnumerable<ProcessModel> processes) {

            foreach (var process in processes) AddProcess(process);

        }

        // Cargar los procesos en memoria enviandolos a la lista de procesos listos
        public void Load() {
            ReadyProcessList.AddRange(ProcessList);
            OnLoadingProcess(new());
        }

        // Ejecutar el primer proceso de la lista de procesos y removerlo
        public void Dispatch() {

            if (!ReadyProcessList.Any()) {
                CurrentProcess = null;
                return;
            }

            CurrentProcess = ReadyProcessList.First();
            ReadyProcessList.Remove(CurrentProcess);

            CurrentProcess.State = ProcessState.Running;

            OnDispatchingProcess(new(CurrentProcess));
        }

        // Tiempo agotado del proceso actual y pasa al siguiente en la lista
        public void ContextChange() {

            if (CurrentProcess is null) return;

            var oldProcess = CurrentProcess;

            ReadyProcessList.Add(oldProcess);

            Dispatch();

            OnContextChanged(new(oldProcess, CurrentProcess));
        }

        // Proceso actual finalizo y pasar al siguiente en la lista
        public void Finish() {

            if (CurrentProcess is null) return;

            FinishedProcessList.Add(CurrentProcess);

            OnFinishingProcess(new(CurrentProcess));

            Dispatch();

        }

        // El proceso actual tuvo una interrupción de entrada / salida y pasar al siguiente
        public void Interrupt() {

            if (CurrentProcess is null) return;

            BlockedProcessList.Add(CurrentProcess);

            OnInterruptingProcess(new(CurrentProcess));

            Dispatch();

        }

        #region OnEvents
        protected virtual void OnAddingProcess(ProcessEventArgs e) {
            AddingProcess?.Invoke(this, e);
        }
        protected virtual void OnLoadingProcess(ProcessEventArgs e) {
            LoadingProcess?.Invoke(this, e);
        }
        protected virtual void OnContextChanged(ProcessEventArgs e) {
            ContextChanged?.Invoke(this, e);
        }
        protected virtual void OnDispatchingProcess(ProcessEventArgs e) {
            DispatchingProcess?.Invoke(this, e);
        }
        protected virtual void OnInterruptingProcess(ProcessEventArgs e) {
            InterruptingProcess?.Invoke(this, e);
        }
        protected virtual void OnFinishingProcess(ProcessEventArgs e) {
            FinishingProcess?.Invoke(this, e);
        }
        #endregion

    }

    public abstract class ProcessList : List<ProcessModel> {

        public ProcessState ListType { get; }

        public ProcessList(ProcessState listType) {
            ListType = listType;
        }

        public new void Add(ProcessModel process) {
            process.State = ListType;

            base.Add(process);
        }

        public new void AddRange(IEnumerable<ProcessModel> processes) {

            foreach (var process in processes) process.State = ListType;

            base.AddRange(processes);
        }

        public new void Insert(int index, ProcessModel process) {

            process.State = ListType;
            base.Insert(index, process);
        }

        public new void InsertRange(int index, IEnumerable<ProcessModel> processes) {

            foreach (var process in processes) process.State = ListType;

            base.InsertRange(index, processes);
        }

    }

    public class ListReadyProcess : ProcessList {

        public ListReadyProcess()
            : base(ProcessState.Ready) { }

    }

    public class ListBlockedProcess : ProcessList {

        public ListBlockedProcess()
            : base(ProcessState.Blocked) { }

    }

    public class ListFinishedProcess : ProcessList {

        public ListFinishedProcess()
            : base(ProcessState.Finished) { }

    }
}
