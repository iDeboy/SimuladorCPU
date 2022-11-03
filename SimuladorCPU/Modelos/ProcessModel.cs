using SimuladorCPU.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCPU.Modelos {
    public class ProcessModel {
        public uint Id { get; set; }
        public string Name { get; set; }
        public uint Time { get; }
        public bool IsIOProcess { get; set; }
        public ProcessState State { get; set; }
        public uint TimeLeft { get; set; }
        public uint TimeBLocked { get; }
        public uint TimeBLockedLeft { get; set; }
        public bool IsReady => State is ProcessState.Ready;
        public bool IsRunning => State is ProcessState.Running;
        public bool IsBlocked => State is ProcessState.Blocked;
        public bool IsFinished => State is ProcessState.Finished;

        public ProcessModel(uint id, string name, uint time, bool isIoProcess = false, ProcessState state = ProcessState.Ready) {
            Id = id;
            Name = name;
            Time = time;
            IsIOProcess = isIoProcess;
            State = state;
            TimeLeft = Time;

            if (!IsIOProcess) TimeBLocked = 0;
            else TimeBLocked = (uint)new Random().Next((int)Time);

            TimeBLockedLeft = TimeBLocked;

        }

        public ProcessModel(uint id, string name, uint time, bool isIoProcess)
            : this(id, name, time, isIoProcess, default) { }

        public ProcessModel(uint id, string name, uint time)
            : this(id, name, time, default, default) { }


    }
}
