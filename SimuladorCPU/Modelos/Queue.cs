using SimuladorCPU.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCPU.Modelos {
    public abstract class Queue : IQueue {

        // Properties
        public int Size => Processes.Count;

        public ProcessState QueueType { get; }

        public List<ProcessModel> Processes { get; }


        // Constructor
        protected Queue(ProcessState queueType, IEnumerable<ProcessModel> list) {
            Processes = new();

            InsertRange(list);

            QueueType = queueType;
        }

        protected Queue(ProcessState queueType)
            : this(queueType, new List<ProcessModel>()) { }

        // Methods
        public void Clear() {
            Processes.Clear();
        }

        /*public Task Clear() {
            return Task.Run(() => Processes.Clear());
        }*/

        public void Insert(ProcessModel? process) {

            if (process is null) return;

            process.State = QueueType;

            Processes.Add(process);
        }

        public void InsertRange(IEnumerable<ProcessModel> processList) {
            foreach (var p in processList) Insert((ProcessModel)p.Clone());
        }
        /*public Task InsertRange(IEnumerable<ProcessModel> processList) {

            List<Task> tasks = new();

            foreach (var p in processList) tasks.Add(Insert(p));

            return Task.WhenAll(tasks);
        }
        public Task Insert(ProcessModel? process) {

            return Task.Run(() => {
                if (process is null) return;

                process.State = QueueType;

                Processes.Add(process);
                Size = Processes.Count;
            });
        }*/

        public ProcessModel? Peek() => Processes.FirstOrDefault();
        /*public Task<ProcessModel?> Peek() {
            return Task.Run(() => {
                return Processes.FirstOrDefault();
            });
        }*/
        public ProcessModel? PeekRandom() {

            int index = new Random().Next(Size);

            return Processes.ElementAtOrDefault(index);
        }
        public void Remove() {
            var first = Peek();

            if (first is null) return;

            Processes.Remove(first);
        }

        public void Remove(ProcessModel? process) { 

            if(process is null) return; 

            Processes.RemoveAll(p => p.Name == process.Name);
        }
        /*public async Task Remove() {

            var first = await Peek();

            if (first is null) return;

            Processes.Remove(first);
            Size = Processes.Count;

            await Task.CompletedTask;
        }*/

        public override string ToString() {

            string result = $"Tipo: {QueueType}, Tamaño: {Size}";

            if (Size != 0) result += "\nProcesos:\n";

            result += string.Join(',', Processes);

            return result;
        }

        public IEnumerator<ProcessModel> GetEnumerator() => Processes.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Processes).GetEnumerator();
    }
}
