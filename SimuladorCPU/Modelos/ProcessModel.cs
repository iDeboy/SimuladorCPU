using SimuladorCPU.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SimuladorCPU.Modelos {
    public class ProcessModel : ICloneable {

        private static readonly List<uint> m_Ids = new();
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
        public bool HasBeenBlocked => TimeBLockedLeft == 0;

        public override string ToString() {
            return "{\n\t" + $"[{Id} - {Name}]: \n\t\tTiempo Total: {Time}\n\t\tTiempo faltante: {TimeLeft}" + "\n}";
        }

        private static uint GeneratePId() {

            uint pId = (uint)new Random().Next(999);

            // Si otro proceso ya tiene esa id, vuelvo a generar otra
            while (m_Ids.Any(id => id == pId)) pId = (uint)new Random().Next(999);

            m_Ids.Add(pId);

            return pId;
        }

        public object Clone() {
            return new ProcessModel(this);
        }
        private ProcessModel(ProcessModel other) {
            Id = other.Id;
            Name = other.Name;
            Time = other.Time;
            IsIOProcess = other.IsIOProcess;
            State = other.State;
            TimeLeft = other.TimeLeft;
            TimeBLocked = other.TimeBLocked;
            TimeBLockedLeft = other.TimeBLockedLeft;
        }
        public ProcessModel(string name, uint time, bool isIoProcess = false, ProcessState state = ProcessState.None) {
            Id = GeneratePId();
            Name = name;
            Time = time;
            IsIOProcess = isIoProcess;
            State = state;
            TimeLeft = Time;

            if (!IsIOProcess) TimeBLocked = 0;
            else TimeBLocked = (uint)new Random().Next(1, (int)Time);

            TimeBLockedLeft = TimeBLocked;

        }

        public ProcessModel(string name, uint time, bool isIoProcess)
            : this(name, time, isIoProcess, default) { }

        public ProcessModel(string name, uint time)
            : this(name, time, default, default) { }


    }
}
