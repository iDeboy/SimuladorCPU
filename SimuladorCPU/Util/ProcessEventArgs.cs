using SimuladorCPU.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCPU.Util {
    public class ProcessEventArgs : EventArgs {
        public ProcessModel? OldProcess { get; set; }
        public ProcessModel? NewProcess { get; set; }

        public ProcessEventArgs(ProcessModel? oldProcess, ProcessModel? newProcess) {
            OldProcess = oldProcess;
            NewProcess = newProcess;
        }

        public ProcessEventArgs(ProcessModel process)
            : this(null, process) { }

        public ProcessEventArgs()
            : this(null, null) { }
    }
}
