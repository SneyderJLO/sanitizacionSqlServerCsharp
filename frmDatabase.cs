using System.Text.RegularExpressions;

using Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sanitizacionMejorado
{
    public partial class frmDatabase : Form
    {
        private List<string> listaTablas; string nombreColumnasProcesar = "";
        string connectionStringBuilder = "";
        public frmDatabase()
        {
            InitializeComponent();
        }
        public frmDatabase(List<string> tablas, string connectionStringBuilder)
        {
            InitializeComponent();
            listaTablas = tablas;
            this.connectionStringBuilder = connectionStringBuilder;
        }
        private void frmDatabase_Load(object sender, EventArgs e)
        {
            cmbTablas.DataSource = listaTablas;

        }



        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox cmb = sender as ComboBox;

            cargarColumnas(cmbTablas.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> columnas = ObtenerTablasSeleccionadas();
            if (columnas.Count > 0)
            {
                string columnasProcesar = string.Join(", ", columnas);
                using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ToString()))
                {
                    connection.Open();

                    // Consulta SQL para obtener los nombres de las bases de datos
                    string query = $"select {columnasProcesar} from {cmbTablas.SelectedItem.ToString()}"; // Excluyendo bases de sistema

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader); // Cargar los datos del lector en el DataTable

                            // Ahora puedes usar el DataTable con los datos
                            // Por ejemplo, puedes asignarlo a una fuente de datos de un control DataGridView
                            DataTable dataTableSanitizada = sanitizarDatos(dataTable);
                            dtgDatos.DataSource = dataTableSanitizada;
                        }
                    }
                    connection.Close();
                }
            }
            else
            {
                dtgDatos.DataSource = null;
                dtgDatos.Controls.Clear();
                MessageBox.Show("Debes seleccionar al menos un elemento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private DataTable sanitizarDatos(DataTable dataTable)
        {
            Random rand = new Random();
            DataTable dataTableSanitizada = dataTable.Clone();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow filaNueva = dataTableSanitizada.NewRow();
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    var valorActual = dataTable.Rows[i][j];

                    bool esDigito = valorActual.ToString().All(char.IsDigit);
                    if (esDigito)
                    {
                        int random = 1;
                        string max = valorActual.ToString() + "";
                        switch (max.Length)
                        {

                            case int n when n > 0 && n < 10:
                                // La longitud de la cadena está entre 1 y 9 (inclusive), establece un valor aleatorio entre 101 y 200
                                random = rand.Next(1, 9);
                                break;

                            case int n when n >= 10 && n <= 99:
                                // La longitud de la cadena está entre 10 y 100 (inclusive), establece un valor aleatorio entre 201 y 300
                                random = rand.Next(1, 99);
                                break;

                            case int n when n > 99 && n <= 1000:
                                // La longitud de la cadena está entre 101 y 1000 (inclusive), establece un valor aleatorio entre 301 y 400
                                random = rand.Next(100, 9999);
                                break;

                            default:
                                // Si la longitud de la cadena no coincide con ninguno de los casos anteriores, establece un valor predeterminado
                                random = max.Length;
                                break;
                        }

                        valorActual = random;

                    }
                    else
                    {
                        string resultado = Regex.Replace(valorActual.ToString(), @"\b[\w ]+\b", match =>
                        {
                            string caracteresAleatorios = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                            char[] nuevaPalabra = new char[match.Length];
                            for (int i = 0; i < match.Length; i++)
                            {

                                nuevaPalabra[i] = caracteresAleatorios[rand.Next(caracteresAleatorios.Length)];

                            }
                            return new string(nuevaPalabra);
                        });


                        valorActual = resultado;
                    }




                    //MessageBox.Show(dataTable.Rows[i][j] + "");


                    filaNueva[j] = valorActual;

                }
                dataTableSanitizada.Rows.Add(filaNueva);

            }


            return dataTableSanitizada;
        }

        private List<string> ObtenerTablasSeleccionadas()
        {
            List<string> tablasSeleccionadas = new List<string>();

            foreach (Control control in flowColumnas.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    tablasSeleccionadas.Add(checkBox.Text);
                }
            }

            return tablasSeleccionadas;
        }
        private void cargarColumnas(string tabla)
        {
            flowColumnas.Controls.Clear();
            using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ToString()))
            {
                connection.Open();

                // Consulta SQL para obtener los nombres de las bases de datos
                string query = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tabla}';"; // Excluyendo bases de sistema

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            string columna = reader.GetString(0);




                            CheckBox checkBox = new CheckBox();
                            checkBox.Text = columna;
                            checkBox.AutoSize = true;
                            checkBox.Checked = true;

                            flowColumnas.Controls.Add(checkBox);


                        }
                    }
                }
                connection.Close();
            }
        }



    }
}
