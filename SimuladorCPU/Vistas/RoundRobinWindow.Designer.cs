namespace SimuladorCPU.Vistas {
    partial class RoundRobinWindow {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.m_ProcessNameLabel = new System.Windows.Forms.Label();
            this.m_TextBoxProcessName = new System.Windows.Forms.TextBox();
            this.m_GroupProcess = new System.Windows.Forms.GroupBox();
            this.m_ErrorLabel = new System.Windows.Forms.Label();
            this.m_AddProcessButton = new FontAwesome.Sharp.IconButton();
            this.m_FlowLayoutTime = new System.Windows.Forms.FlowLayoutPanel();
            this.m_ProcessTimeLabel = new System.Windows.Forms.Label();
            this.m_TextBoxProcessTime = new System.Windows.Forms.TextBox();
            this.m_CheckBoxInputOutputProcess = new System.Windows.Forms.CheckBox();
            this.m_FlowLayoutName = new System.Windows.Forms.FlowLayoutPanel();
            this.m_FlowLayoutQuantum = new System.Windows.Forms.FlowLayoutPanel();
            this.m_QuantumLabel = new System.Windows.Forms.Label();
            this.m_TextBoxQuantum = new System.Windows.Forms.TextBox();
            this.m_GroupProcessList = new System.Windows.Forms.GroupBox();
            this.m_DataGridProcess = new System.Windows.Forms.DataGridView();
            this.m_ProcessId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_ProcessTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_ProcessIsIO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.m_StartButton = new FontAwesome.Sharp.IconButton();
            this.m_PanelControlButtons = new System.Windows.Forms.Panel();
            this.m_CleanButton = new FontAwesome.Sharp.IconButton();
            this.m_QuantumErrorLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_GroupProcess.SuspendLayout();
            this.m_FlowLayoutTime.SuspendLayout();
            this.m_FlowLayoutName.SuspendLayout();
            this.m_FlowLayoutQuantum.SuspendLayout();
            this.m_GroupProcessList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_DataGridProcess)).BeginInit();
            this.m_PanelControlButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_ProcessNameLabel
            // 
            this.m_ProcessNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_ProcessNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_ProcessNameLabel.Location = new System.Drawing.Point(12, 8);
            this.m_ProcessNameLabel.Name = "m_ProcessNameLabel";
            this.m_ProcessNameLabel.Size = new System.Drawing.Size(81, 25);
            this.m_ProcessNameLabel.TabIndex = 0;
            this.m_ProcessNameLabel.Text = "Nombre:";
            this.m_ProcessNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_TextBoxProcessName
            // 
            this.m_TextBoxProcessName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_TextBoxProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_TextBoxProcessName.Location = new System.Drawing.Point(99, 10);
            this.m_TextBoxProcessName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_TextBoxProcessName.Name = "m_TextBoxProcessName";
            this.m_TextBoxProcessName.Size = new System.Drawing.Size(254, 26);
            this.m_TextBoxProcessName.TabIndex = 1;
            this.m_TextBoxProcessName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxProcessName_KeyPress);
            // 
            // m_GroupProcess
            // 
            this.m_GroupProcess.Controls.Add(this.m_ErrorLabel);
            this.m_GroupProcess.Controls.Add(this.m_AddProcessButton);
            this.m_GroupProcess.Controls.Add(this.m_FlowLayoutTime);
            this.m_GroupProcess.Controls.Add(this.m_FlowLayoutName);
            this.m_GroupProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_GroupProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_GroupProcess.Location = new System.Drawing.Point(96, 40);
            this.m_GroupProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_GroupProcess.Name = "m_GroupProcess";
            this.m_GroupProcess.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_GroupProcess.Size = new System.Drawing.Size(416, 188);
            this.m_GroupProcess.TabIndex = 2;
            this.m_GroupProcess.TabStop = false;
            this.m_GroupProcess.Text = "Agregar procesos";
            // 
            // m_ErrorLabel
            // 
            this.m_ErrorLabel.AutoSize = true;
            this.m_ErrorLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_ErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.m_ErrorLabel.Location = new System.Drawing.Point(3, 106);
            this.m_ErrorLabel.Name = "m_ErrorLabel";
            this.m_ErrorLabel.Padding = new System.Windows.Forms.Padding(9, 8, 0, 0);
            this.m_ErrorLabel.Size = new System.Drawing.Size(9, 28);
            this.m_ErrorLabel.TabIndex = 3;
            this.m_ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_AddProcessButton
            // 
            this.m_AddProcessButton.BackColor = System.Drawing.SystemColors.Control;
            this.m_AddProcessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_AddProcessButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.m_AddProcessButton.IconColor = System.Drawing.Color.DarkCyan;
            this.m_AddProcessButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.m_AddProcessButton.IconSize = 40;
            this.m_AddProcessButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_AddProcessButton.Location = new System.Drawing.Point(70, 139);
            this.m_AddProcessButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_AddProcessButton.Name = "m_AddProcessButton";
            this.m_AddProcessButton.Size = new System.Drawing.Size(262, 34);
            this.m_AddProcessButton.TabIndex = 4;
            this.m_AddProcessButton.Text = "Agregar";
            this.m_AddProcessButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.m_AddProcessButton.UseVisualStyleBackColor = false;
            this.m_AddProcessButton.Click += new System.EventHandler(this.AddProcessButton_Click);
            // 
            // m_FlowLayoutTime
            // 
            this.m_FlowLayoutTime.AutoSize = true;
            this.m_FlowLayoutTime.Controls.Add(this.m_ProcessTimeLabel);
            this.m_FlowLayoutTime.Controls.Add(this.m_TextBoxProcessTime);
            this.m_FlowLayoutTime.Controls.Add(this.m_CheckBoxInputOutputProcess);
            this.m_FlowLayoutTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_FlowLayoutTime.Location = new System.Drawing.Point(3, 62);
            this.m_FlowLayoutTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_FlowLayoutTime.Name = "m_FlowLayoutTime";
            this.m_FlowLayoutTime.Padding = new System.Windows.Forms.Padding(9, 8, 0, 8);
            this.m_FlowLayoutTime.Size = new System.Drawing.Size(410, 44);
            this.m_FlowLayoutTime.TabIndex = 3;
            // 
            // m_ProcessTimeLabel
            // 
            this.m_ProcessTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_ProcessTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_ProcessTimeLabel.Location = new System.Drawing.Point(12, 8);
            this.m_ProcessTimeLabel.Name = "m_ProcessTimeLabel";
            this.m_ProcessTimeLabel.Size = new System.Drawing.Size(81, 25);
            this.m_ProcessTimeLabel.TabIndex = 0;
            this.m_ProcessTimeLabel.Text = "Tiempo:";
            this.m_ProcessTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_TextBoxProcessTime
            // 
            this.m_TextBoxProcessTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_TextBoxProcessTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_TextBoxProcessTime.Location = new System.Drawing.Point(99, 10);
            this.m_TextBoxProcessTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_TextBoxProcessTime.Name = "m_TextBoxProcessTime";
            this.m_TextBoxProcessTime.Size = new System.Drawing.Size(123, 26);
            this.m_TextBoxProcessTime.TabIndex = 1;
            this.m_TextBoxProcessTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
            // 
            // m_CheckBoxInputOutputProcess
            // 
            this.m_CheckBoxInputOutputProcess.AutoSize = true;
            this.m_CheckBoxInputOutputProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_CheckBoxInputOutputProcess.Location = new System.Drawing.Point(238, 10);
            this.m_CheckBoxInputOutputProcess.Margin = new System.Windows.Forms.Padding(13, 2, 3, 2);
            this.m_CheckBoxInputOutputProcess.Name = "m_CheckBoxInputOutputProcess";
            this.m_CheckBoxInputOutputProcess.Size = new System.Drawing.Size(133, 24);
            this.m_CheckBoxInputOutputProcess.TabIndex = 2;
            this.m_CheckBoxInputOutputProcess.Text = "Entrada/Salida";
            this.m_CheckBoxInputOutputProcess.UseVisualStyleBackColor = true;
            // 
            // m_FlowLayoutName
            // 
            this.m_FlowLayoutName.AutoSize = true;
            this.m_FlowLayoutName.Controls.Add(this.m_ProcessNameLabel);
            this.m_FlowLayoutName.Controls.Add(this.m_TextBoxProcessName);
            this.m_FlowLayoutName.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_FlowLayoutName.Location = new System.Drawing.Point(3, 21);
            this.m_FlowLayoutName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_FlowLayoutName.Name = "m_FlowLayoutName";
            this.m_FlowLayoutName.Padding = new System.Windows.Forms.Padding(9, 8, 0, 8);
            this.m_FlowLayoutName.Size = new System.Drawing.Size(410, 41);
            this.m_FlowLayoutName.TabIndex = 2;
            // 
            // m_FlowLayoutQuantum
            // 
            this.m_FlowLayoutQuantum.AutoSize = true;
            this.m_FlowLayoutQuantum.Controls.Add(this.m_QuantumLabel);
            this.m_FlowLayoutQuantum.Controls.Add(this.m_TextBoxQuantum);
            this.m_FlowLayoutQuantum.Location = new System.Drawing.Point(3, 2);
            this.m_FlowLayoutQuantum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_FlowLayoutQuantum.Name = "m_FlowLayoutQuantum";
            this.m_FlowLayoutQuantum.Padding = new System.Windows.Forms.Padding(9, 8, 0, 8);
            this.m_FlowLayoutQuantum.Size = new System.Drawing.Size(250, 41);
            this.m_FlowLayoutQuantum.TabIndex = 3;
            // 
            // m_QuantumLabel
            // 
            this.m_QuantumLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_QuantumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_QuantumLabel.Location = new System.Drawing.Point(12, 8);
            this.m_QuantumLabel.Name = "m_QuantumLabel";
            this.m_QuantumLabel.Size = new System.Drawing.Size(106, 25);
            this.m_QuantumLabel.TabIndex = 0;
            this.m_QuantumLabel.Text = "Quantum:";
            this.m_QuantumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_TextBoxQuantum
            // 
            this.m_TextBoxQuantum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_TextBoxQuantum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_TextBoxQuantum.Location = new System.Drawing.Point(124, 10);
            this.m_TextBoxQuantum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_TextBoxQuantum.Name = "m_TextBoxQuantum";
            this.m_TextBoxQuantum.Size = new System.Drawing.Size(123, 26);
            this.m_TextBoxQuantum.TabIndex = 1;
            this.m_TextBoxQuantum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
            // 
            // m_GroupProcessList
            // 
            this.m_GroupProcessList.Controls.Add(this.m_DataGridProcess);
            this.m_GroupProcessList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_GroupProcessList.Location = new System.Drawing.Point(531, 131);
            this.m_GroupProcessList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_GroupProcessList.Name = "m_GroupProcessList";
            this.m_GroupProcessList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_GroupProcessList.Size = new System.Drawing.Size(434, 354);
            this.m_GroupProcessList.TabIndex = 4;
            this.m_GroupProcessList.TabStop = false;
            this.m_GroupProcessList.Text = "Procesos";
            // 
            // m_DataGridProcess
            // 
            this.m_DataGridProcess.AllowUserToAddRows = false;
            this.m_DataGridProcess.AllowUserToDeleteRows = false;
            this.m_DataGridProcess.AllowUserToResizeRows = false;
            this.m_DataGridProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_DataGridProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.m_DataGridProcess.BackgroundColor = System.Drawing.SystemColors.Control;
            this.m_DataGridProcess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.m_DataGridProcess.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.m_DataGridProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_DataGridProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_ProcessId,
            this.m_ProcessName,
            this.m_ProcessTime,
            this.m_ProcessIsIO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.m_DataGridProcess.DefaultCellStyle = dataGridViewCellStyle2;
            this.m_DataGridProcess.Location = new System.Drawing.Point(5, 22);
            this.m_DataGridProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_DataGridProcess.MultiSelect = false;
            this.m_DataGridProcess.Name = "m_DataGridProcess";
            this.m_DataGridProcess.ReadOnly = true;
            this.m_DataGridProcess.RowHeadersVisible = false;
            this.m_DataGridProcess.RowHeadersWidth = 52;
            this.m_DataGridProcess.RowTemplate.Height = 29;
            this.m_DataGridProcess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_DataGridProcess.Size = new System.Drawing.Size(418, 328);
            this.m_DataGridProcess.TabIndex = 0;
            // 
            // m_ProcessId
            // 
            this.m_ProcessId.DataPropertyName = "Id";
            this.m_ProcessId.HeaderText = "Id";
            this.m_ProcessId.MinimumWidth = 6;
            this.m_ProcessId.Name = "m_ProcessId";
            this.m_ProcessId.ReadOnly = true;
            // 
            // m_ProcessName
            // 
            this.m_ProcessName.DataPropertyName = "Name";
            this.m_ProcessName.HeaderText = "Nombre";
            this.m_ProcessName.MinimumWidth = 6;
            this.m_ProcessName.Name = "m_ProcessName";
            this.m_ProcessName.ReadOnly = true;
            // 
            // m_ProcessTime
            // 
            this.m_ProcessTime.DataPropertyName = "Time";
            this.m_ProcessTime.HeaderText = "Tiempo";
            this.m_ProcessTime.MinimumWidth = 6;
            this.m_ProcessTime.Name = "m_ProcessTime";
            this.m_ProcessTime.ReadOnly = true;
            // 
            // m_ProcessIsIO
            // 
            this.m_ProcessIsIO.DataPropertyName = "IsIOProcess";
            this.m_ProcessIsIO.HeaderText = "E/S";
            this.m_ProcessIsIO.MinimumWidth = 6;
            this.m_ProcessIsIO.Name = "m_ProcessIsIO";
            this.m_ProcessIsIO.ReadOnly = true;
            // 
            // m_StartButton
            // 
            this.m_StartButton.BackColor = System.Drawing.SystemColors.Control;
            this.m_StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_StartButton.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.m_StartButton.IconColor = System.Drawing.Color.LimeGreen;
            this.m_StartButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.m_StartButton.IconSize = 35;
            this.m_StartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_StartButton.Location = new System.Drawing.Point(67, 53);
            this.m_StartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_StartButton.Name = "m_StartButton";
            this.m_StartButton.Size = new System.Drawing.Size(262, 34);
            this.m_StartButton.TabIndex = 5;
            this.m_StartButton.Text = "Iniciar";
            this.m_StartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.m_StartButton.UseVisualStyleBackColor = false;
            this.m_StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // m_PanelControlButtons
            // 
            this.m_PanelControlButtons.Controls.Add(this.m_CleanButton);
            this.m_PanelControlButtons.Controls.Add(this.m_StartButton);
            this.m_PanelControlButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_PanelControlButtons.Location = new System.Drawing.Point(99, 250);
            this.m_PanelControlButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_PanelControlButtons.Name = "m_PanelControlButtons";
            this.m_PanelControlButtons.Size = new System.Drawing.Size(414, 236);
            this.m_PanelControlButtons.TabIndex = 6;
            // 
            // m_CleanButton
            // 
            this.m_CleanButton.BackColor = System.Drawing.SystemColors.Control;
            this.m_CleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_CleanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_CleanButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.m_CleanButton.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.m_CleanButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.m_CleanButton.IconSize = 35;
            this.m_CleanButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_CleanButton.Location = new System.Drawing.Point(67, 146);
            this.m_CleanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_CleanButton.Name = "m_CleanButton";
            this.m_CleanButton.Size = new System.Drawing.Size(262, 34);
            this.m_CleanButton.TabIndex = 6;
            this.m_CleanButton.Text = "Limpiar todo";
            this.m_CleanButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.m_CleanButton.UseVisualStyleBackColor = false;
            this.m_CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // m_QuantumErrorLabel
            // 
            this.m_QuantumErrorLabel.AutoSize = true;
            this.m_QuantumErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_QuantumErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.m_QuantumErrorLabel.Location = new System.Drawing.Point(3, 44);
            this.m_QuantumErrorLabel.Name = "m_QuantumErrorLabel";
            this.m_QuantumErrorLabel.Padding = new System.Windows.Forms.Padding(9, 8, 0, 0);
            this.m_QuantumErrorLabel.Size = new System.Drawing.Size(9, 28);
            this.m_QuantumErrorLabel.TabIndex = 7;
            this.m_QuantumErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_FlowLayoutQuantum);
            this.panel1.Controls.Add(this.m_QuantumErrorLabel);
            this.panel1.Location = new System.Drawing.Point(536, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 88);
            this.panel1.TabIndex = 8;
            // 
            // RoundRobinWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_PanelControlButtons);
            this.Controls.Add(this.m_GroupProcessList);
            this.Controls.Add(this.m_GroupProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RoundRobinWindow";
            this.Text = "RoundRobinWindow";
            this.m_GroupProcess.ResumeLayout(false);
            this.m_GroupProcess.PerformLayout();
            this.m_FlowLayoutTime.ResumeLayout(false);
            this.m_FlowLayoutTime.PerformLayout();
            this.m_FlowLayoutName.ResumeLayout(false);
            this.m_FlowLayoutName.PerformLayout();
            this.m_FlowLayoutQuantum.ResumeLayout(false);
            this.m_FlowLayoutQuantum.PerformLayout();
            this.m_GroupProcessList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_DataGridProcess)).EndInit();
            this.m_PanelControlButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label m_ProcessNameLabel;
        private TextBox m_TextBoxProcessName;
        private GroupBox m_GroupProcess;
        private FlowLayoutPanel m_FlowLayoutName;
        private FlowLayoutPanel m_FlowLayoutTime;
        private Label m_ProcessTimeLabel;
        private TextBox m_TextBoxProcessTime;
        private CheckBox m_CheckBoxInputOutputProcess;
        private FontAwesome.Sharp.IconButton m_AddProcessButton;
        private Label m_ErrorLabel;
        private FlowLayoutPanel m_FlowLayoutQuantum;
        private Label m_QuantumLabel;
        private TextBox m_TextBoxQuantum;
        private GroupBox m_GroupProcessList;
        private DataGridView m_DataGridProcess;
        private DataGridViewTextBoxColumn m_ProcessId;
        private DataGridViewTextBoxColumn m_ProcessName;
        private DataGridViewTextBoxColumn m_ProcessTime;
        private DataGridViewCheckBoxColumn m_ProcessIsIO;
        private FontAwesome.Sharp.IconButton m_StartButton;
        private Panel m_PanelControlButtons;
        private FontAwesome.Sharp.IconButton m_CleanButton;
        private Label m_QuantumErrorLabel;
        private Panel panel1;
    }
}