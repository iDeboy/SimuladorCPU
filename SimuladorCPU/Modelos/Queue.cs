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
        public int Size { get; protected set; }

        public ProcessState QueueType { get; }

        public List<ProcessModel> Processes { get; }


        // Methods
        public void Clear() {
            Processes.Clear();
        }

        public void Insert(ProcessModel? process) {

            if (process is null) return;

            process.State = QueueType;

            Processes.Add(process);
            Size = Processes.Count;
        }

        public Task InsertAsync(ProcessModel? process) {

            return Task.Run(() => {

                if (process is null) return;

                process.State = QueueType;

                Processes.Add(process);
                Size = Processes.Count;

            });
        }

        public ProcessModel? Peek() => Processes.FirstOrDefault();

        public void Remove() {
            var first = Peek();

            if (first is null) return;

            Processes.Remove(first);
            Size = Processes.Count;
        }

        public override string ToString() {

            string result = $"Tipo: {QueueType}, Tamaño: {Size}";

            if (Size != 0) result += "\nProcesos:\n";

            result += string.Join(',', Processes);

            return result;
        }

        public IEnumerator<ProcessModel> GetEnumerator() => Processes.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Processes).GetEnumerator();

        // Constructor
        protected Queue(ProcessState queueType) {
            Processes = new();
            QueueType = queueType;
            Size = Processes.Count;
        }
    }
}
