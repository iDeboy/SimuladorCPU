namespace SimuladorCPU.Vistas {
    partial class RoundRobinSchedulerWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.m_QuantumLabel = new System.Windows.Forms.Label();
            this.m_PanelReadyProcess = new System.Windows.Forms.Panel();
            this.m_ReadyProcessTitle = new System.Windows.Forms.Label();
            this.m_PanelRunningProcess = new System.Windows.Forms.Panel();
            this.m_RunningProcessTitle = new System.Windows.Forms.Label();
            this.m_PanelFinishedProcess = new System.Windows.Forms.Panel();
            this.m_FinishedProcessTitle = new System.Windows.Forms.Label();
            this.m_PanelBlockedProcess = new System.Windows.Forms.Panel();
            this.m_BlockedProcessTitle = new System.Windows.Forms.Label();
            this.m_Timer = new System.Windows.Forms.Timer(this.components);
            this.m_TimerWork = new System.Windows.Forms.Timer(this.components);
            this.m_TimerBlocked = new System.Windows.Forms.Timer(this.components);
            this.m_PanelReadyProcess.SuspendLayout();
            this.m_PanelRunningProcess.SuspendLayout();
            this.m_PanelFinishedProcess.SuspendLayout();
            this.m_PanelBlockedProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_QuantumLabel
            // 
            this.m_QuantumLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_QuantumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_QuantumLabel.Location = new System.Drawing.Point(0, 0);
            this.m_QuantumLabel.Name = "m_QuantumLabel";
            this.m_QuantumLabel.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.m_QuantumLabel.Size = new System.Drawing.Size(1198, 86);
            this.m_QuantumLabel.TabIndex = 1;
            this.m_QuantumLabel.Text = "Quantum: #";
            this.m_QuantumLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // m_PanelReadyProcess
            // 
            this.m_PanelReadyProcess.AutoSize = true;
            this.m_PanelReadyProcess.BackColor = System.Drawing.SystemColors.ControlLight;
            this.m_PanelReadyProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_PanelReadyProcess.Controls.Add(this.m_ReadyProcessTitle);
            this.m_PanelReadyProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_PanelReadyProcess.Location = new System.Drawing.Point(12, 114);
            this.m_PanelReadyProcess.Name = "m_PanelReadyProcess";
            this.m_PanelReadyProcess.Size = new System.Drawing.Size(272, 92);
            this.m_PanelReadyProcess.TabIndex = 2;
            // 
            // m_ReadyProcessTitle
            // 
            this.m_ReadyProcessTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_ReadyProcessTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_ReadyProcessTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_ReadyProcessTitle.Location = new System.Drawing.Point(0, 0);
            this.m_ReadyProcessTitle.Name = "m_ReadyProcessTitle";
            this.m_ReadyProcessTitle.Size = new System.Drawing.Size(270, 45);
            this.m_ReadyProcessTitle.TabIndex = 4;
            this.m_ReadyProcessTitle.Tag = "Title";
            this.m_ReadyProcessTitle.Text = "Listos";
            this.m_ReadyProcessTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_PanelRunningProcess
            // 
            this.m_PanelRunningProcess.AutoSize = true;
            this.m_PanelRunningProcess.BackColor = System.Drawing.SystemColors.ControlLight;
            this.m_PanelRunningProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_PanelRunningProcess.Controls.Add(this.m_RunningProcessTitle);
            this.m_PanelRunningProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_PanelRunningProcess.Location = new System.Drawing.Point(313, 115);
            this.m_PanelRunningProcess.Name = "m_PanelRunningProcess";
            this.m_PanelRunningProcess.Size = new System.Drawing.Size(272, 92);
            this.m_PanelRunningProcess.TabIndex = 3;
            // 
            // m_RunningProcessTitle
            // 
            this.m_RunningProcessTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_RunningProcessTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_RunningProcessTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_RunningProcessTitle.Location = new System.Drawing.Point(0, 0);
            this.m_RunningProcessTitle.Name = "m_RunningProcessTitle";
            this.m_RunningProcessTitle.Size = new System.Drawing.Size(270, 45);
            this.m_RunningProcessTitle.TabIndex = 4;
            this.m_RunningProcessTitle.Tag = "Title";
            this.m_RunningProcessTitle.Text = "Corriendo";
            this.m_RunningProcessTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_PanelFinishedProcess
            // 
            this.m_PanelFinishedProcess.AutoSize = true;
            this.m_PanelFinishedProcess.BackColor = System.Drawing.SystemColors.ControlLight;
            this.m_PanelFinishedProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_PanelFinishedProcess.Controls.Add(this.m_FinishedProcessTitle);
            this.m_PanelFinishedProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_PanelFinishedProcess.Location = new System.Drawing.Point(609, 114);
            this.m_PanelFinishedProcess.Name = "m_PanelFinishedProcess";
            this.m_PanelFinishedProcess.Size = new System.Drawing.Size(272, 92);
            this.m_PanelFinishedProcess.TabIndex = 4;
            // 
            // m_FinishedProcessTitle
            // 
            this.m_FinishedProcessTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_FinishedProcessTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_FinishedProcessTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_FinishedProcessTitle.Location = new System.Drawing.Point(0, 0);
            this.m_FinishedProcessTitle.Name = "m_FinishedProcessTitle";
            this.m_FinishedProcessTitle.Size = new System.Drawing.Size(270, 45);
            this.m_FinishedProcessTitle.TabIndex = 4;
            this.m_FinishedProcessTitle.Tag = "Title";
            this.m_FinishedProcessTitle.Text = "Terminados";
            this.m_FinishedProcessTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_PanelBlockedProcess
            // 
            this.m_PanelBlockedProcess.AutoSize = true;
            this.m_PanelBlockedProcess.BackColor = System.Drawing.SystemColors.ControlLight;
            this.m_PanelBlockedProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_PanelBlockedProcess.Controls.Add(this.m_BlockedProcessTitle);
            this.m_PanelBlockedProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_PanelBlockedProcess.Location = new System.Drawing.Point(905, 114);
            this.m_PanelBlockedProcess.Name = "m_PanelBlockedProcess";
            this.m_PanelBlockedProcess.Size = new System.Drawing.Size(272, 92);
            this.m_PanelBlockedProcess.TabIndex = 5;
            // 
            // m_BlockedProcessTitle
            // 
            this.m_BlockedProcessTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_BlockedProcessTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_BlockedProcessTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_BlockedProcessTitle.Location = new System.Drawing.Point(0, 0);
            this.m_BlockedProcessTitle.Name = "m_BlockedProcessTitle";
            this.m_BlockedProcessTitle.Size = new System.Drawing.Size(270, 45);
            this.m_BlockedProcessTitle.TabIndex = 4;
            this.m_BlockedProcessTitle.Tag = "Title";
            this.m_BlockedProcessTitle.Text = "Bloqueados";
            this.m_BlockedProcessTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_Timer
            // 
            this.m_Timer.Interval = 1;
            this.m_Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // m_TimerWork
            // 
            this.m_TimerWork.Interval = 1000;
            this.m_TimerWork.Tick += new System.EventHandler(this.TimerWork_Tick);
            // 
            // m_TimerBlocked
            // 
            this.m_TimerBlocked.Interval = 1000;
            this.m_TimerBlocked.Tick += new System.EventHandler(this.TimerBlocked_Tick);
            // 
            // RoundRobinSchedulerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 615);
            this.Controls.Add(this.m_PanelBlockedProcess);
            this.Controls.Add(this.m_PanelFinishedProcess);
            this.Controls.Add(this.m_PanelRunningProcess);
            this.Controls.Add(this.m_PanelReadyProcess);
            this.Controls.Add(this.m_QuantumLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RoundRobinSchedulerWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulación";
            this.Shown += new System.EventHandler(this.RoundRobinSchedulerWindow_Shown);
            this.m_PanelReadyProcess.ResumeLayout(false);
            this.m_PanelRunningProcess.ResumeLayout(false);
            this.m_PanelFinishedProcess.ResumeLayout(false);
            this.m_PanelBlockedProcess.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label m_QuantumLabel;
        public Panel m_PanelReadyProcess;
        public Label m_ReadyProcessTitle;
        public Panel m_PanelRunningProcess;
        public Label m_RunningProcessTitle;
        public Panel m_PanelFinishedProcess;
        public Label m_FinishedProcessTitle;
        public Panel m_PanelBlockedProcess;
        public Label m_BlockedProcessTitle;
        private System.Windows.Forms.Timer m_Timer;
        private System.Windows.Forms.Timer m_TimerWork;
        private System.Windows.Forms.Timer m_TimerBlocked;
    }
}