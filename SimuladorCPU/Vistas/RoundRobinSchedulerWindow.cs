using System;
using SimuladorCPU.Modelos;

namespace SimuladorCPU.Vistas {
    public partial class RoundRobinSchedulerWindow : Form {

        private readonly BlockProcessModel m_BlockProcess;
        private ProcessModel? RunningProcess => m_BlockProcess.RunningProcess;
        private ProcessModel? BlockedProcess => m_BlockProcess.BlockedProcess;
        private uint Quantum => m_BlockProcess.Quantum;
        private uint TimeWorking { get; set; } = 0;
        //private uint TimeBlocked { get; set; } = 0;
        private static int ComponentsGroupHeight => 45;
        public RoundRobinSchedulerWindow(BlockProcessModel blockProcess) {
            InitializeComponent();

            m_BlockProcess = blockProcess;

            m_QuantumLabel.Text = $"Quantum: {m_BlockProcess.Quantum}";

            ClearAllPanels();
        }

        public void ClearAllPanels() {
            ClearPanelContainer(m_PanelReadyProcess, m_BlockProcess.ProcessList.Count());
            ClearPanelContainer(m_PanelRunningProcess, 1);
            ClearPanelContainer(m_PanelFinishedProcess, m_BlockProcess.ProcessList.Count());
            ClearPanelContainer(m_PanelBlockedProcess, m_BlockProcess.ProcessList.Count());
        }
        public static void ClearPanelContainer(Panel container, int processCount = -1) {
            container.AutoSize = false;

            foreach (Control c in container.Controls)
                if (c.Tag is null) {
                    container.Controls.Remove(c);
                    c.Dispose();
                }

            if (processCount > -1) container.Height = ComponentsGroupHeight * (processCount + 1) + 5;
        }

        private void PutLabelFromProcess(Panel container, ProcessModel process) {

            // Label
            var lbl = new Label() {
                Name = $"{process.Name}",
                BackColor = container.BackColor,
                Dock = DockStyle.Top,
                FlatStyle = FlatStyle.Flat,
                Font = container.Font,
                ForeColor = container.ForeColor,
                Padding = new Padding(0, 10, 0, 0),
                Text = $"{process.Name}",
                TextAlign = ContentAlignment.TopCenter,
                Height = ComponentsGroupHeight,
                Visible = true,
            };

            container.Controls.Add(lbl);

            lbl.BringToFront();

        }
        private async Task LoadContentPanelFromProcessListAsync(Panel container, IQueue processList) {
            ClearPanelContainer(container);

            foreach (var process in processList) {

                await Task.Delay(500);

                PutLabelFromProcess(container, process);

            }

            await Task.Delay(500);
        }

        private void LoadContentPanelFromProcessList(Panel container, IQueue processList) {

            ClearPanelContainer(container);

            foreach (var process in processList) {

                PutLabelFromProcess(container, process);

            }

        }

        private async void RoundRobinSchedulerWindow_Shown(object sender, EventArgs e) {

            if (!m_BlockProcess.IsReady) return;

            m_BlockProcess.LoadQueue();

            await LoadContentPanelFromProcessListAsync(m_PanelReadyProcess, m_BlockProcess.ReadyProcessList);

            m_Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) {

            if (!m_BlockProcess.Running) {
                m_Timer.Stop();
                m_QuantumLabel.Text = $"Quantum: {Quantum}";
                //label2.Text = "Finalizados";
                return;
            }

            // Ejecutar el primero en la fila (Dispatch)
            m_BlockProcess.Dispatch();
            m_PanelReadyProcess.Controls.RemoveByKey(RunningProcess?.Name);

            // Hacer trabajo
            if (RunningProcess is not null) {

                PutLabelFromProcess(m_PanelRunningProcess, RunningProcess);

                m_Timer.Stop();
                m_TimerWork.Start();

                return;
            }

            //label2.Text = "No hay procesos para ejecutar";

        }

        private void TimerWork_Tick(object sender, EventArgs e) {

            // No hay proceso ejecutandose
            if (RunningProcess is null) {
                m_TimerWork.Stop();
                TimeWorking = 0;
                m_PanelRunningProcess.Controls.RemoveByKey(RunningProcess?.Name);
                return;
            }

            // Blocked
            if (RunningProcess.IsIOProcess && !RunningProcess.HasBeenBlocked) {

                if (RunningProcess.TimeLeft == RunningProcess.TimeBLocked) {
                    //label1.Text = $"Bloquear a {RunningProcess.Name}";
                    m_TimerWork.Stop();
                    TimeWorking = 0;
                    m_QuantumLabel.Text = $"Quantum: {Quantum}";

                    m_PanelRunningProcess.Controls.RemoveByKey(RunningProcess.Name);
                    PutLabelFromProcess(m_PanelBlockedProcess, RunningProcess);

                    m_BlockProcess.Block();

                    m_TimerBlocked.Start();
                    m_Timer.Start();

                    return;
                }

            }

            // Work done
            if (RunningProcess.TimeLeft == 0) {
                m_TimerWork.Stop();
                TimeWorking = 0;
                m_QuantumLabel.Text = $"Quantum: {Quantum}";

                m_PanelRunningProcess.Controls.RemoveByKey(RunningProcess.Name);

                PutLabelFromProcess(m_PanelFinishedProcess, RunningProcess);
                m_BlockProcess.WorkDone();
                m_Timer.Start();
                return;
            }

            // TimeOut
            if (TimeWorking == Quantum) {
                m_TimerWork.Stop();
                TimeWorking = 0;
                m_QuantumLabel.Text = $"Quantum: {Quantum}";

                m_PanelRunningProcess.Controls.RemoveByKey(RunningProcess.Name);
                PutLabelFromProcess(m_PanelReadyProcess, RunningProcess);

                m_BlockProcess.TimeOut();

                m_Timer.Start();
                return;
            }

            TimeWorking++;
            RunningProcess.TimeLeft--;
            m_QuantumLabel.Text = $"Quantum: {Quantum - TimeWorking}";
            //label2.Text = $"{RunningProcess.Name} ha trabajado: {TimeWorking}s.";
        }

        private async void TimerBlocked_Tick(object sender, EventArgs e) {

            // No hay procesos bloqueados
            if (BlockedProcess is null) {
                m_TimerBlocked.Stop();
                //TimeBlocked = 0;

                m_PanelBlockedProcess.Controls.RemoveByKey(BlockedProcess?.Name);
                return;
            }

            // Realese (Unblock)
            if (BlockedProcess.TimeBLockedLeft == 0) {
                m_TimerBlocked.Stop();
                //TimeBlocked = 0;

                m_PanelBlockedProcess.Controls.RemoveByKey(BlockedProcess.Name);
                PutLabelFromProcess(m_PanelReadyProcess, BlockedProcess);

                await Task.Delay(1000);

                m_BlockProcess.Realese();
                return;
            }

            //TimeBlocked++;
            BlockedProcess.TimeBLockedLeft--;
            //label3.Text = $"{BlockedProcess.Name} se ha bloqueado por {TimeBlocked}s.";

        }
    }
}
