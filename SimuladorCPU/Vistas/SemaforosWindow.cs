using SimuladorCPU.Modelos;
using System.Numerics;

namespace SimuladorCPU.Vistas
{
    public partial class SemaforosWindow : Form
    {

        int totalDatos;
        PlanificadorFiFo planificador = new PlanificadorFiFo();
        int limiteDatos = 0;

        //int i, j, d, c;
        //double[,] resultados;
        //String[,] valores;
        //String[,] valoresOrdenados;
        //String[,] valoresSeguidos;

        public SemaforosWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //i = 0;
            //j = 0;
            //label5.Text = "" + Convert.ToString(totalDatos);

            //inicializarDataGridView();

            llegada.KeyPress += new KeyPressEventHandler(validarTeclaPulsada);
            salida.KeyPress += new KeyPressEventHandler(validarTeclaPulsada);
        }
        private void dgvDatos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //Evento que activa para escrivir solo numeros
            TextBox txtValidar = (TextBox)e.Control;
            txtValidar.KeyDown += new
            KeyEventHandler(inhabilitarTeclasDireccionSuprimir);
            txtValidar.KeyPress += new
            KeyPressEventHandler(validarTeclaPulsada);

        }
        private void limpiaTexto()
        {
            proceso.Clear();
            llegada.Clear();
            salida.Clear();
        }

        private void inhabilitarTeclasDireccionSuprimir(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down
            || e.KeyCode == Keys.Up
            || e.KeyCode == Keys.Left
            || e.KeyCode == Keys.Right
            || e.KeyCode == Keys.Delete
            )
                e.Handled = true;
        }
        private bool validarNombre(string nombre)
        {
            return !string.IsNullOrWhiteSpace(nombre);
        }
        private bool validarTiempo(string tiempo)
        {
            if (string.IsNullOrWhiteSpace(tiempo))
            {
                return false;
            }
            if (!int.TryParse(tiempo, out int nombre))
            {
                return false;
            }
            return true;
        }
        private void agregar_Click(object sender, EventArgs e)
        {
            if (!validarNombre(proceso.Text))
            {
                return;
            }
            if (!validarTiempo(llegada.Text))
            {
                return;
            }
            if (!validarTiempo(salida.Text))
            {
                return;
            }
            int inicio = int.Parse(llegada.Text);
            int final = int.Parse(salida.Text);
            string nombre = proceso.Text;
            //si encuatra algo crea una nueva lista con nuevos elementos
            if (planificador.Any(p => p.TiempoLlegada == inicio))
            {
                return;
            }
            planificador.Add(new ProcesosFiFo(nombre, inicio,
                final));
            //exprexion lambda


            actualizarTablas();
            limpiaTexto();



        }

        private void iniciador_Click(object sender, EventArgs e)
        {
            if (!planificador.Any())
            {
                return;
            }
            //limpiaTabla();
            planificador.Finalizar();

            //tablaOrdenada();
            tiempos2();
            mostrarTiempos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void actualizarTablas()
        {
            limpiaTabla();
            foreach (var p in planificador)
            {
                listBox1.Items.Add(p.Nombre);
                listBox2.Items.Add(p.TiempoLlegada);
                listBox3.Items.Add(p.TiempoSalida);
            }
        }
        private void limpiaTabla()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiaTabla();
            limpiaTexto();
            limpiaArrays();
            limpiaBase();
            //i = 0;
            //j = 0;
            //limiteDatos = 0;
            //inicializarDataGridView();
        }
        private void limpiaArrays()
        {
            planificador.Clear();
        }
        private void limpiaBase()
        {
            //dgvDatos.Rows.Clear();
            for (int i = dgvDatos.Rows.Count - 1; i >= 0; i--)
            {
                dgvDatos.Rows.RemoveAt(i);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //limiteDatos = 5;
            //valoresSeguidos[0, 0] = "Word"; valoresSeguidos[0, 2] = "Excel"; valoresSeguidos[0, 4] = "Paint";
            //valoresSeguidos[0, 3] = "Net"; valoresSeguidos[0, 1] = "Eclipse";

            //valoresSeguidos[1, 0] = "0"; valoresSeguidos[1, 2] = "2"; valoresSeguidos[1, 4] = "4";
            //valoresSeguidos[1, 3] = "3"; valoresSeguidos[1, 1] = "1";

            //valoresSeguidos[2, 0] = "10"; valoresSeguidos[2, 2] = "12"; valoresSeguidos[2, 4] = "5";
            //valoresSeguidos[2, 3] = "6"; valoresSeguidos[2, 1] = "24";

            //valoresSeguidos[3, 0] = "0"; valoresSeguidos[3, 2] = "0"; valoresSeguidos[3, 4] = "0";
            //valoresSeguidos[3, 1] = "0"; valoresSeguidos[3, 3] = "0";
        }



        private void validarTeclaPulsada(object sender, KeyPressEventArgs e)
        {
            TextBox obj = (TextBox)sender;
            bool esDigitoEntero = char.IsDigit(e.KeyChar);
            //bool esPuntoDecimal = ((e.KeyChar == '.')
            // && (obj.Text.IndexOf('.') == -1));
            bool esRetroceso = e.KeyChar == (char)Keys.Back;
            //bool esSignoNegativo = (e.KeyChar == '-') &&
            //(obj.Text.Length == 0);
            if (esDigitoEntero
            || esRetroceso
            //|| esSignoNegativo
            //|| esPuntoDecimal
            )
            {
                e.Handled = false; //Dejar pasar
            }
            else
                e.Handled = true; //Bloquear
        }

        private async void mostrarTiempos()
        {
            //for (i = 0; i < limiteDatos; i++)
            //{
            //    await Task.Delay(int.Parse(valoresSeguidos[1, i]) * 100);
            //    dgvDatos.Rows.Add(string.Empty);
            //    dgvDatos[1, i].Value = resultados[0, i]; Tiempo llegada
            //    dgvDatos[2, i].Value = resultados[1, i]; Tiempo final
            //    dgvDatos[3, i].Value = resultados[2, i]; Tiempo salida
            //    dgvDatos[4, i].Value = resultados[3, i];  Tiempo de espera
            //    dgvDatos[5, i].Value = resultados[4, i];  Tiempo de rafaga
            //    dgvDatos[6, i].Value = resultados[5, i];  Tiempo promedio
            //    if (valoresSeguidos[3, i] == "0")
            //    {
            //        dgvDatos[7, i].Value = "N";
            //    }
            //    else
            //    {
            //        dgvDatos[7, i].Value = valoresSeguidos[3, i];
            //    }

            //    dgvDatos[0, i].Value = valoresSeguidos[0, i]; Nombre porceso


            //}
            foreach (var p in planificador)
            {
                await Task.Delay(p.TiempoSalidaBloqueado * 100);
                dgvDatos.Rows.Add(
                    p.Nombre, //Nombre porceso
                    p.TiempoLlegada,   //Tiempo llegada
                    p.TiempoSalidaBloqueado, //Tiempo salida
                    p.TiempoFinal, //Tiempo final
                    p.TiempoEspera, //Tiempo de espera
                    p.TiempoRespuesta, // Tiempo de rafaga
                    p.EstaBloqueado ? p.TiempoBloqueado : "N" //Tiempo bloqueado
                );
            }
        }


        private void tiempos2()
        {

            ////Tiempo llegada tl [0,i]
            ////Tiempo salida Ts [2,i]
            //for (i = 0; i < totalDatos - 1; i++)
            //{
            //    resultados[0, i] = double.Parse(valoresSeguidos[1, i]);
            //    resultados[2, i] = double.Parse(valoresSeguidos[2, i]) + double.Parse(valoresSeguidos[3, i]);

            //}

            ////Tiempo final tf [1,i]

            //resultados[1, 0] = resultados[2, 0];
            //for (i = 1; i < totalDatos - 1; i++)
            //{
            //    resultados[1, i] = resultados[2, i] + resultados[1, i - 1];
            //  TiempoFinalAnterior + TiempoSalida
            //  Tf      TSalida
            //  10      10
            //  15      5
            //  26      11 
            //}



            ////Tiempo de respuesta Tr [4,i]
            //resultados[4, 0] = resultados[2, 0];
            //for (i = 1; i < totalDatos - 1; i++)
            //{
            //    resultados[4, i] = resultados[2, i] + resultados[4, i - 1];
            //}

            ////Tiempo de espera Te [3,i]
            //resultados[3, i] = 0;
            //for (i = 1; i < totalDatos - 1; i++)
            //{
            //    resultados[3, i] = resultados[4, i - 1] - resultados[0, i];
            //}

            ////tiempo de respuesta promedio tr / ts
            //for (i = 1; i < totalDatos - 1; i++)
            //{
            //    resultados[5, i] = resultados[4, i] / resultados[2, i];
            //}
        }

        private void BloqueaOpciones()
        {
            llegada.Enabled = salida.Enabled = proceso.Enabled = false;
            agregar.Enabled = iniciador.Enabled = false;
        }
    }
}