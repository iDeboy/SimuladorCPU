using SimuladorCPU.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCPU.Modelos {
    public interface IQueue : IEnumerable<ProcessModel> {

        int Size { get; }
        ProcessState QueueType { get; }
        List<ProcessModel> Processes { get; }

        // Sync Methods
        public void Insert(ProcessModel? process);
        public void Remove();
        public ProcessModel? Peek();
        public void Clear();
        public string ToString();

        // Async Methods
        public Task InsertAsync(ProcessModel? process);

    }
}
