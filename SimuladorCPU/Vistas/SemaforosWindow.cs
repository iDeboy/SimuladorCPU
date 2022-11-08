using System.Numerics;

namespace SimuladorCPU.Vistas
{
    public partial class SemaforosWindow : Form
    {
        int alturaTotal, anchoTabla, altoDeFila;
        int totalDatos;
        int limiteDatos = 0;
        int celda = 0;
        int i, j, d, c;
        double[,] resultados;
        String[,] valores;
        String[,] valoresOrdenados;
        String[,] valoresSeguidos;

        public SemaforosWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            i = 0;
            j = 0;
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
            proceso.Text = "";
            llegada.Text = "";
            salida.Text = "";
        }
        private void ajustarControles()
        {
            dgvDatos.Rows.Add();
            //Obtener la altura de la fila 0;
            altoDeFila = dgvDatos.Rows[0].Height;
            alturaTotal += altoDeFila;
            dgvDatos.Size = new Size(anchoTabla, alturaTotal);
            dgvDatos.Rows[celda].HeaderCell.Value = "P" + (celda + 1);

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
        private void agregar_Click(object sender, EventArgs e)
        {
            if (proceso.Text != "" && llegada.Text != "" && salida.Text != "")
            {
                if (int.Parse(llegada.Text) >= totalDatos)
                {
                    MessageBox.Show("El orden de llegada no puede exceder el limite de procesos");
                }
                else
                {
                    if (llegada.Text == valoresOrdenados[1, int.Parse(llegada.Text)])
                    {
                        MessageBox.Show("Existe un proceso que ya tiene ese tiempo de llegada");
                    }
                    else
                    {
                        if (salida.Text == "0")
                        {
                            MessageBox.Show("La duracion del proceso debe ser mayor a 0");
                        }
                        else
                        {
                            if (limiteDatos + 1 < totalDatos)
                            {
                                celda++;
                                valores[0, j] = proceso.Text;
                                valores[1, j] = llegada.Text;
                                valores[2, j] = salida.Text;
                                d = int.Parse(llegada.Text);
                                valoresOrdenados[0, d] = proceso.Text;
                                valoresOrdenados[1, d] = llegada.Text;
                                valoresOrdenados[2, d] = salida.Text;
                                actualizarTablas();
                                limpiaTexto();
                                j++;
                                limiteDatos++;
                            }
                            else
                            {
                                MessageBox.Show("Limite de procesos");
                            }
                            //ajustarControles();



                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Uno o más datos no tienen algun valor");
            }
            //MessageBox.Show("es " + valores[0, j]);
            //MessageBox.Show("re " + proceso.Text);

        }

        private void iniciador_Click(object sender, EventArgs e)
        {
            //limpiaTabla();
            ordenadDatos();

            //tablaOrdenada();
            tiempos();
            mostrarTiempos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void inicializarDataGridView()
        {
            dgvDatos.RowHeadersWidth = dgvDatos.RowHeadersWidth + 30;
            dgvDatos.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDatos.ColumnCount = 7;

            dgvDatos.Columns[0].Width = 110;
            dgvDatos.Columns[1].Width = 110;
            dgvDatos.Columns[2].Width = 110;
            dgvDatos.Columns[3].Width = 110;
            dgvDatos.Columns[4].Width = 110;
            dgvDatos.Columns[5].Width = 110;
            dgvDatos.Columns[6].Width = 110;

            //Estilos de encabezados de columna
            dgvDatos.ColumnHeadersDefaultCellStyle.Font =
            new Font(
            dgvDatos.DefaultCellStyle.Font.Name,
            12, dgvDatos.DefaultCellStyle.Font.Style);
            dgvDatos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //tienen efecto alguno
            dgvDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dgvDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            //Tamaño del contenedor del DataGridView
            anchoTabla =
            dgvDatos.Columns[0].Width +
            dgvDatos.Columns[1].Width +
            dgvDatos.Columns[2].Width +
            dgvDatos.Columns[3].Width +
            dgvDatos.Columns[4].Width +
            dgvDatos.Columns[5].Width +
            dgvDatos.Columns[6].Width +
            dgvDatos.RowHeadersWidth;

            //Alto de fila = alto de encabezado de columna +
            // dos tercios de su valor. (mayor margen de tolerancia)
            alturaTotal = dgvDatos.Columns[0].HeaderCell.Size.Height +
        (2 * dgvDatos.Columns[0].HeaderCell.Size.Height / 3);
            dgvDatos.Size = new Size(anchoTabla, alturaTotal);
            //Establecer rótulos de los encabezados de columna
            dgvDatos.Columns[0].Name = "Proceso";
            dgvDatos.Columns[1].Name = "Tiempo Ll.";
            dgvDatos.Columns[2].Name = "Tiempo F.";
            dgvDatos.Columns[3].Name = "Tiempo S.";
            dgvDatos.Columns[4].Name = "Tiempo E.";
            dgvDatos.Columns[5].Name = "Tiempo R.";
            dgvDatos.Columns[6].Name = "Tiempo NR.";

            //Ajuste automático del ancho del contenedor
            //con el ancho de la tabla DataGridView
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Centrar contenido de celdas
            dgvDatos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Inhabilitar ordenación para las 7 columnas
            dgvDatos.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Inhabilitar segunda columna para edición
            dgvDatos.Columns[0].ReadOnly = true;
            dgvDatos.Columns[1].ReadOnly = true;
            dgvDatos.Columns[2].ReadOnly = true;
            dgvDatos.Columns[3].ReadOnly = true;
            dgvDatos.Columns[4].ReadOnly = true;
            dgvDatos.Columns[5].ReadOnly = true;
            dgvDatos.Columns[6].ReadOnly = true;
            //Inhabilitar selección múltiple
            dgvDatos.MultiSelect = false;
            //No mostrar encabezados de filas
            //dgvDatos.RowHeadersVisible = false;
            //Inhabilitar modificación del ancho del encabezado de fila
            dgvDatos.RowHeadersWidthSizeMode =
            DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            //Inhabilitar agregar filas por parte del usuario
            dgvDatos.AllowUserToAddRows = false;
            //Inhabilitar redimensionamiento de filas y columnas
            dgvDatos.AllowUserToResizeColumns = false;
            dgvDatos.AllowUserToResizeRows = false;
            //Coloreado de filas alternado
            dgvDatos.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            //Estilo de celdas de las 7 columnas
            dgvDatos.DefaultCellStyle.Font = new Font(
            dgvDatos.DefaultCellStyle.Font.Name,
            12, dgvDatos.DefaultCellStyle.Font.Style);
        }

        public void actualizarTablas()
        {
            listBox1.Items.Add(valores[0, j]);
            listBox2.Items.Add(valores[1, j]);
            listBox3.Items.Add(valores[2, j]);
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
            bloqueoCeldas();
            i = 0;
            j = 0;
            limiteDatos = 0;
            //inicializarDataGridView();
        }
        private void limpiaArrays()
        {
            Array.Clear(valores, 0, valores.Length);
            Array.Clear(valoresSeguidos, 0, valoresSeguidos.Length);
            Array.Clear(valoresOrdenados, 0, valoresSeguidos.Length);
        }
        private void limpiaBase()
        {
            //dgvDatos.Rows.Clear();
            for (i = dgvDatos.Rows.Count - 1; i >= 0; i--)
            {
                dgvDatos.Rows.RemoveAt(i);
            }
        }
        private void bloqueoCeldas()
        {
            proceso.Enabled = llegada.Enabled = salida.Enabled
                = button1.Enabled = agregar.Enabled = iniciador.Enabled = false;
            numericUpDown1.Enabled = true;
            button2.Enabled = true;
        }
        private void activarCeldas()
        {
            proceso.Enabled = llegada.Enabled = salida.Enabled
                = button1.Enabled = agregar.Enabled = iniciador.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            totalDatos = int.Parse(numericUpDown1.Value.ToString());
            numericUpDown1.Enabled = false;
            button2.Enabled = false;
            label5.Text = "" + Convert.ToString(totalDatos);
            totalDatos++;
            valores = new String[3, totalDatos];
            valoresSeguidos = new String[3, totalDatos];
            valoresOrdenados = new String[3, totalDatos];
            resultados = new double[11, totalDatos];
            
            
            activarCeldas();
        }

        //solo sirve para mostrar los datos ordenados con forme al tiempo de llegada
        private void tablaOrdenada()
        {
            for (i = 0; i < limiteDatos; i++)
            {
                //MessageBox.Show(valoresSeguidos[0, i] + " " + valoresSeguidos[1, i] + " "
                //        + valoresSeguidos[2, i]);
                if (valoresSeguidos[0, i] != null || valoresSeguidos[1, i] != null || valoresSeguidos[2, i] != null)
                {
                    listBox1.Items.Add(valoresSeguidos[0, i]);
                    listBox2.Items.Add(valoresSeguidos[1, i]);
                    listBox3.Items.Add(valoresSeguidos[2, i]);
                }

            }
        }
        private void tiempos()
        {
            for (i = 0; i < limiteDatos; i++)
            {
                //ts
                resultados[0, i] = double.Parse(valoresSeguidos[2, i]);
            }
            //tf0
            resultados[1, 0] = double.Parse(valoresSeguidos[1, 0]) + resultados[0, 0];
            //tf
            for (i = 1; i < limiteDatos; i++)
            {

                resultados[1, i] = resultados[0, i] + resultados[1, i - 1];
            }

            //tr
            for (i = 0; i < limiteDatos; i++)
            {

                resultados[2, i] = resultados[1, i] - double.Parse(valoresSeguidos[1, i]);
            }

            //te
            for (i = 0; i < limiteDatos; i++)
            {

                resultados[3, i] = resultados[2, i] - resultados[0, i];
            }

            //Nr
            for (i = 0; i < limiteDatos; i++)
            {

                resultados[4, i] = resultados[2, i] / resultados[0, i];
            }
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
            for (i = 0; i < limiteDatos; i++)
            {
                await Task.Delay(int.Parse(valoresSeguidos[1, i]) * 1000);
                dgvDatos.Rows.Add(string.Empty);
                dgvDatos[2, i].Value = resultados[1, i];
                dgvDatos[5, i].Value = resultados[2, i];
                dgvDatos[4, i].Value = resultados[3, i];
                dgvDatos[6, i].Value = resultados[4, i];
                dgvDatos[0, i].Value = valoresSeguidos[0, i];
                dgvDatos[3, i].Value = valoresSeguidos[2, i];
                dgvDatos[1, i].Value = valoresSeguidos[1, i];

            }
        }
        //Actualmente ordena datos no tiene ocupacion
        private void ordenadDatos()
        {
            c = 0;
            for (i = 0; i < totalDatos; i++)
            {
                if (valoresOrdenados[1, i] != "" && valoresOrdenados[1, i] != null)
                {
                    valoresSeguidos[0, c] = valoresOrdenados[0, i];
                    valoresSeguidos[1, c] = valoresOrdenados[1, i];
                    valoresSeguidos[2, c] = valoresOrdenados[2, i];
                    c++;
                }

            }

            //valoresOrdenados[0, a - c] = valoresOrdenados[0, a];
            //valoresOrdenados[1, a - c] = valoresOrdenados[1, a];
            //valoresOrdenados[2, a - c] = valoresOrdenados[2, a];

            //valoresOrdenados[0, a] = null;
            //valoresOrdenados[1, a] = null;
            //valoresOrdenados[2, a] = null;


        }
    }
}