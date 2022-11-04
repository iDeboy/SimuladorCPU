using SimuladorCPU.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SimuladorCPU.Vistas {
    public partial class RoundRobinWindow : Form {

        private BlockProcessModel m_BlockProcess;

        public RoundRobinWindow() {
            InitializeComponent();
            m_DataGridProcess.AutoGenerateColumns = false;

            m_BlockProcess = new BlockProcessModel();
        }

        private bool ValidateProcessName(string name) {

            name = name.Trim();

            if (string.IsNullOrWhiteSpace(name)) {
                m_ErrorLabel.Text = "* El nombre del proceso no es válido.";
                return false;
            }

            if (m_BlockProcess.Any(p => p.Name == name)) {
                m_ErrorLabel.Text = "* Ya existe ese proceso.";
                return false;
            }

            m_ErrorLabel.Text = "";
            return true;
        }
        private bool ValidateProcessTime(string time) {
            time = time.Trim();

            if (string.IsNullOrWhiteSpace(time)) {
                m_ErrorLabel.Text = "* El tiempo del proceso no es válido.";
                return false;
            }

            if (!uint.TryParse(time, out uint result)) {
                m_ErrorLabel.Text = "* El tiempo del proceso es muy grande.";
                return false;
            }

            if (result == 0) {
                m_ErrorLabel.Text = "* El tiempo no puede ser cero.";
                return false;
            }

            m_ErrorLabel.Text = "";
            return true;
        }
        private bool ValidateQuantum(string quantum) {
            quantum = quantum.Trim();

            if (string.IsNullOrWhiteSpace(quantum)) {
                m_QuantumErrorLabel.Text = "* El quantum no es válido.";
                return false;
            }

            if (!uint.TryParse(quantum, out uint result)) {
                m_QuantumErrorLabel.Text = "* El quantum es muy grande.";
                return false;
            }

            if (result == 0) {
                m_QuantumErrorLabel.Text = "* El quantum no puede ser cero.";
                return false;
            }

            m_QuantumErrorLabel.Text = "";
            return true;
        }
        private bool ValidateProcessList() {

            if (!m_BlockProcess.Any()) {
                m_QuantumErrorLabel.Text = "* No hay procesos.";
                return false;
            }

            m_QuantumErrorLabel.Text = "";
            return true;
        }
        private void ClearProcessInformation() {
            m_TextBoxProcessName.Clear();
            m_TextBoxProcessTime.Clear();
            m_CheckBoxInputOutputProcess.Checked = false;
        }
        private void ClearErrorLabels() {
            m_ErrorLabel.Text = m_QuantumErrorLabel.Text = "";
        }
        private void ClearAll() {
            ClearProcessInformation();
            ClearErrorLabels();
            m_DataGridProcess.DataSource = null;
            m_TextBoxQuantum.Clear();
            m_BlockProcess.Clear();
        }
        private void AddProcessButton_Click(object sender, EventArgs e) {

            var name = m_TextBoxProcessName.Text.Trim();

            if (!ValidateProcessName(name)) return;

            var strTime = m_TextBoxProcessTime.Text.Trim();

            if (!ValidateProcessTime(strTime)) return;

            uint time = uint.Parse(strTime);

            var IOProcess = m_CheckBoxInputOutputProcess.Checked;

            m_BlockProcess.AddProcess(new ProcessModel(name, time, IOProcess));

            m_DataGridProcess.DataSource = null;
            m_DataGridProcess.DataSource = m_BlockProcess.ToList();

            ClearProcessInformation();
        }

        private void TextBoxProcessName_KeyPress(object sender, KeyPressEventArgs e) {

            if (sender is not TextBox txtBox) return;

            if (e.KeyChar == (char)Keys.Enter
                && !string.IsNullOrWhiteSpace(txtBox.Text)) m_TextBoxProcessTime.Focus();

        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e) {

            if (sender is not TextBox) return;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void StartButton_Click(object sender, EventArgs e) {

            var strQuantum = m_TextBoxQuantum.Text.Trim();

            if (!ValidateQuantum(strQuantum)) return;

            uint quantum = uint.Parse(strQuantum);

            if (!ValidateProcessList()) return;

            ClearErrorLabels();

            // Iniciar el simulador
            m_BlockProcess.Quantum = quantum;

            m_BlockProcess.Run();
        }

        private void CleanButton_Click(object sender, EventArgs e) {
            ClearAll();
        }
    }
}
