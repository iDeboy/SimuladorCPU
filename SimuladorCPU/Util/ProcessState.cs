using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCPU.Util {
    public enum ProcessState {
        None = 0,
        Ready,
        Running,
        Blocked,
        Finished
    }
}
