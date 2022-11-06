namespace SimuladorCPU.Vistas {
    partial class MainWindow {
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
            this.m_Dashboard = new System.Windows.Forms.Panel();
            this.m_SemaforosOption = new FontAwesome.Sharp.IconButton();
            this.m_RoundRobinOption = new FontAwesome.Sharp.IconButton();
            this.m_Icon = new FontAwesome.Sharp.IconPictureBox();
            this.m_Title = new System.Windows.Forms.Label();
            this.m_ControlBar = new System.Windows.Forms.Panel();
            this.m_MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.m_CloseButton = new FontAwesome.Sharp.IconButton();
            this.m_CaptionPanel = new System.Windows.Forms.Panel();
            this.m_CaptionText = new System.Windows.Forms.Label();
            this.m_CaptionIcon = new FontAwesome.Sharp.IconPictureBox();
            this.m_PanelAux = new System.Windows.Forms.Panel();
            this.m_PanelForm = new System.Windows.Forms.Panel();
            this.m_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_Icon)).BeginInit();
            this.m_ControlBar.SuspendLayout();
            this.m_CaptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_CaptionIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // m_Dashboard
            // 
            this.m_Dashboard.BackColor = System.Drawing.Color.DodgerBlue;
            this.m_Dashboard.Controls.Add(this.m_SemaforosOption);
            this.m_Dashboard.Controls.Add(this.m_RoundRobinOption);
            this.m_Dashboard.Controls.Add(this.m_Icon);
            this.m_Dashboard.Controls.Add(this.m_Title);
            this.m_Dashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.m_Dashboard.Name = "m_Dashboard";
            this.m_Dashboard.Size = new System.Drawing.Size(285, 800);
            this.m_Dashboard.TabIndex = 0;
            // 
            // m_SemaforosOption
            // 
            this.m_SemaforosOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.m_SemaforosOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_SemaforosOption.FlatAppearance.BorderSize = 0;
            this.m_SemaforosOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_SemaforosOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_SemaforosOption.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.m_SemaforosOption.IconChar = FontAwesome.Sharp.IconChar.TrafficLight;
            this.m_SemaforosOption.IconColor = System.Drawing.Color.WhiteSmoke;
            this.m_SemaforosOption.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.m_SemaforosOption.IconSize = 40;
            this.m_SemaforosOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_SemaforosOption.Location = new System.Drawing.Point(0, 203);
            this.m_SemaforosOption.Name = "m_SemaforosOption";
            this.m_SemaforosOption.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.m_SemaforosOption.Size = new System.Drawing.Size(285, 60);
            this.m_SemaforosOption.TabIndex = 6;
            this.m_SemaforosOption.Text = "Semáforos";
            this.m_SemaforosOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_SemaforosOption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.m_SemaforosOption.UseVisualStyleBackColor = false;
            this.m_SemaforosOption.Click += new System.EventHandler(this.SemaforosOption_Click);
            // 
            // m_RoundRobinOption
            // 
            this.m_RoundRobinOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.m_RoundRobinOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_RoundRobinOption.FlatAppearance.BorderSize = 0;
            this.m_RoundRobinOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_RoundRobinOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_RoundRobinOption.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.m_RoundRobinOption.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.m_RoundRobinOption.IconColor = System.Drawing.Color.WhiteSmoke;
            this.m_RoundRobinOption.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.m_RoundRobinOption.IconSize = 40;
            this.m_RoundRobinOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_RoundRobinOption.Location = new System.Drawing.Point(0, 143);
            this.m_RoundRobinOption.Name = "m_RoundRobinOption";
            this.m_RoundRobinOption.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.m_RoundRobinOption.Size = new System.Drawing.Size(285, 60);
            this.m_RoundRobinOption.TabIndex = 5;
            this.m_RoundRobinOption.Text = "Round-Robin";
            this.m_RoundRobinOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_RoundRobinOption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.m_RoundRobinOption.UseVisualStyleBackColor = false;
            this.m_RoundRobinOption.Click += new System.EventHandler(this.RoundRobinOption_Click);
            // 
            // m_Icon
            // 
            this.m_Icon.BackColor = System.Drawing.Color.DodgerBlue;
            this.m_Icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_Icon.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.m_Icon.IconChar = FontAwesome.Sharp.IconChar.Microchip;
            this.m_Icon.IconColor = System.Drawing.Color.DarkSlateGray;
            this.m_Icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.m_Icon.IconSize = 108;
            this.m_Icon.Location = new System.Drawing.Point(0, 35);
            this.m_Icon.Name = "m_Icon";
            this.m_Icon.Size = new System.Drawing.Size(285, 108);
            this.m_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.m_Icon.TabIndex = 2;
            this.m_Icon.TabStop = false;
            // 
            // m_Title
            // 
            this.m_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_Title.Location = new System.Drawing.Point(0, 0);
            this.m_Title.Name = "m_Title";
            this.m_Title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_Title.Size = new System.Drawing.Size(285, 35);
            this.m_Title.TabIndex = 1;
            this.m_Title.Text = "Simulador";
            this.m_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.m_Title.UseCompatibleTextRendering = true;
            // 
            // m_ControlBar
            // 
            this.m_ControlBar.Controls.Add(this.m_MinimizeButton);
            this.m_ControlBar.Controls.Add(this.m_CloseButton);
            this.m_ControlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_ControlBar.Location = new System.Drawing.Point(285, 0);
            this.m_ControlBar.Name = "m_ControlBar";
            this.m_ControlBar.Size = new System.Drawing.Size(1200, 55);
            this.m_ControlBar.TabIndex = 3;
            this.m_ControlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlBar_MouseDown);
            // 
            // m_MinimizeButton
            // 
            this.m_MinimizeButton.BackColor = System.Drawing.SystemColors.Control;
            this.m_MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_MinimizeButton.FlatAppearance.BorderSize = 0;
            this.m_MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.m_MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.m_MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.m_MinimizeButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(118)))), ((int)(((byte)(189)))));
            this.m_MinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.m_MinimizeButton.IconSize = 25;
            this.m_MinimizeButton.Location = new System.Drawing.Point(1094, 0);
            this.m_MinimizeButton.Name = "m_MinimizeButton";
            this.m_MinimizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_MinimizeButton.Size = new System.Drawing.Size(53, 55);
            this.m_MinimizeButton.TabIndex = 5;
            this.m_MinimizeButton.TabStop = false;
            this.m_MinimizeButton.UseVisualStyleBackColor = false;
            this.m_MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // m_CloseButton
            // 
            this.m_CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.m_CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_CloseButton.FlatAppearance.BorderSize = 0;
            this.m_CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.m_CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.m_CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_CloseButton.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.m_CloseButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(118)))), ((int)(((byte)(189)))));
            this.m_CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.m_CloseButton.IconSize = 25;
            this.m_CloseButton.Location = new System.Drawing.Point(1147, 0);
            this.m_CloseButton.Name = "m_CloseButton";
            this.m_CloseButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_CloseButton.Size = new System.Drawing.Size(53, 55);
            this.m_CloseButton.TabIndex = 4;
            this.m_CloseButton.TabStop = false;
            this.m_CloseButton.UseVisualStyleBackColor = false;
            this.m_CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // m_CaptionPanel
            // 
            this.m_CaptionPanel.Controls.Add(this.m_CaptionText);
            this.m_CaptionPanel.Controls.Add(this.m_CaptionIcon);
            this.m_CaptionPanel.Controls.Add(this.m_PanelAux);
            this.m_CaptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_CaptionPanel.Location = new System.Drawing.Point(285, 55);
            this.m_CaptionPanel.Name = "m_CaptionPanel";
            this.m_CaptionPanel.Size = new System.Drawing.Size(1200, 45);
            this.m_CaptionPanel.TabIndex = 4;
            // 
            // m_CaptionText
            // 
            this.m_CaptionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_CaptionText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_CaptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_CaptionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.m_CaptionText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_CaptionText.Location = new System.Drawing.Point(87, 0);
            this.m_CaptionText.Name = "m_CaptionText";
            this.m_CaptionText.Size = new System.Drawing.Size(1113, 45);
            this.m_CaptionText.TabIndex = 5;
            this.m_CaptionText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_CaptionIcon
            // 
            this.m_CaptionIcon.BackColor = System.Drawing.SystemColors.Control;
            this.m_CaptionIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_CaptionIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.m_CaptionIcon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.m_CaptionIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.m_CaptionIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.m_CaptionIcon.IconSize = 45;
            this.m_CaptionIcon.Location = new System.Drawing.Point(42, 0);
            this.m_CaptionIcon.Name = "m_CaptionIcon";
            this.m_CaptionIcon.Size = new System.Drawing.Size(45, 45);
            this.m_CaptionIcon.TabIndex = 5;
            this.m_CaptionIcon.TabStop = false;
            // 
            // m_PanelAux
            // 
            this.m_PanelAux.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_PanelAux.Location = new System.Drawing.Point(0, 0);
            this.m_PanelAux.Name = "m_PanelAux";
            this.m_PanelAux.Size = new System.Drawing.Size(42, 45);
            this.m_PanelAux.TabIndex = 5;
            // 
            // m_PanelForm
            // 
            this.m_PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_PanelForm.Location = new System.Drawing.Point(285, 100);
            this.m_PanelForm.Name = "m_PanelForm";
            this.m_PanelForm.Size = new System.Drawing.Size(1200, 700);
            this.m_PanelForm.TabIndex = 5;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 800);
            this.Controls.Add(this.m_PanelForm);
            this.Controls.Add(this.m_CaptionPanel);
            this.Controls.Add(this.m_ControlBar);
            this.Controls.Add(this.m_Dashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador";
            this.m_Dashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_Icon)).EndInit();
            this.m_ControlBar.ResumeLayout(false);
            this.m_CaptionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_CaptionIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel m_Dashboard;
        private Panel m_ControlBar;
        private FontAwesome.Sharp.IconButton m_CloseButton;
        private FontAwesome.Sharp.IconPictureBox m_Icon;
        private Label m_Title;
        private FontAwesome.Sharp.IconButton m_SemaforosOption;
        private FontAwesome.Sharp.IconButton m_RoundRobinOption;
        private FontAwesome.Sharp.IconButton m_MinimizeButton;
        private Panel m_CaptionPanel;
        private FontAwesome.Sharp.IconPictureBox m_CaptionIcon;
        private Panel m_PanelAux;
        private Label m_CaptionText;
        private Panel m_PanelForm;
    }
}