using FontAwesome.Sharp;
using SimuladorCPU.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorCPU.Vistas {
    public partial class MainWindow : Form {

        // Properties
        private IconButton? CurrentButton { get; set; }
        private Form? CurrentForm { get; set; }
        private Panel LeftBorderPanel { get; }
        public MainWindow() {
            InitializeComponent();

            LeftBorderPanel = new() {
                Size = new(10, 0)
            };

            m_Dashboard.Controls.Add(LeftBorderPanel);
        }

        /// <summary>
        /// Abrir formulario en el panel central
        /// </summary>
        /// <param name="form"></param>
        private void OpenChildForm(Form form) {

            if (CurrentForm is not null) {
                CurrentForm.Close();
                CurrentForm.Dispose();
            }

            CurrentForm = form;
            CurrentForm.TopLevel = false;
            CurrentForm.FormBorderStyle = FormBorderStyle.None;
            CurrentForm.Dock = DockStyle.Fill;
            CurrentForm.BackColor = m_PanelForm.BackColor;
            CurrentForm.Size = m_PanelForm.Size;
            m_PanelForm.Controls.Add(CurrentForm);
            m_PanelForm.Tag = CurrentForm;
            CurrentForm.BringToFront();
            CurrentForm.Activate();
            CurrentForm.Show();
        }

        /// <summary>
        /// Activar boton
        /// </summary>
        /// <param name="sender"></param>
        private void ActiveButton(object? sender) {

            if (sender is not IconButton iconBtn) return;

            DisableButton();

            // CurrentButton
            CurrentButton = iconBtn;
            CurrentButton.BackColor = Colors.MenuButtonOverColor;
            CurrentButton.ForeColor = CurrentButton.IconColor = Colors.MenuButtonOverForeColor;

            CurrentButton.Padding = new(LeftBorderPanel.Width + 10, 0, 0, 0);

            // Caption
            m_CaptionIcon.IconChar = CurrentButton.IconChar;
            m_CaptionText.Text = CurrentButton.Text;

            // LeftBorderPanel
            LeftBorderPanel.Height = CurrentButton.Height;
            LeftBorderPanel.BackColor = Color.Black;
            LeftBorderPanel.Location = new(0, CurrentButton.Location.Y);
            LeftBorderPanel.Visible = true;
            LeftBorderPanel.BringToFront();

        }

        /// <summary>
        /// Desactivar el boton actual
        /// </summary>
        private void DisableButton() {

            if (CurrentButton is not IconButton iconBtn) return;

            // CurrentButton
            CurrentButton = iconBtn;
            CurrentButton.BackColor = Colors.DashboardColor;
            CurrentButton.ForeColor = CurrentButton.IconColor = Colors.MenuButtonForeColor;

            CurrentButton.Padding = new(10, 0, 0, 0);

        }

        private void ControlBar_MouseDown(object sender, MouseEventArgs e) {
            WinApi.ReleaseCapture();
            WinApi.SendMessage(Handle, 0x112, 0xF012, 0);
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void RoundRobinOption_Click(object sender, EventArgs e) {
            ActiveButton(sender);
            OpenChildForm(new RoundRobinWindow());
        }

        private void SemaforosOption_Click(object sender, EventArgs e) {
            ActiveButton(sender);

            // LLamar Semaforos
            OpenChildForm(new SemaforosWindow());
        }

        private void MinimizeButton_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }
    }
}
