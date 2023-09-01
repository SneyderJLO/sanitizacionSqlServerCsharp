using Conexion;
using System.Data.SqlClient;

namespace sanitizacionMejorado
{
    public partial class frmSessionLogin : Form
    {
        List<String> tablasDatabase = new List<string>();
        ConexionDB conexionDB = new ConexionDB();
        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
        string dataBase = "";
        bool flagConexion = false;
        public frmSessionLogin()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            flowDB.Controls.Clear();
            try
            {
                //string connectionString = $"Data Source={txtServidor.Text};Integrated Security=True;";
                //   string connectionString = $"Data Source={txtServidor.Text};user=sa; password=123*abc*456;";
                connectionStringBuilder.DataSource = txtServidor.Text;
                //connectionStringBuilder.InitialCatalog = dataBase;
                connectionStringBuilder.UserID = txtUsuario.Text;
                connectionStringBuilder.Password = txtPassword.Text;

                using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ToString()))
                {
                    connection.Open();
                    flagConexion = true;
                    // Consulta SQL para obtener los nombres de las bases de datos
                    string query = "SELECT name FROM sys.databases WHERE database_id > 4"; // Excluyendo bases de sistema

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {


                            while (reader.Read())
                            {
                                string dbName = reader.GetString(0);

                                RadioButton radioButton = new RadioButton();
                                radioButton.Text = dbName;
                                radioButton.AutoSize = true;
                                radioButton.CheckedChanged += RadioButton_CheckedChanged;
                                flowDB.Controls.Add(radioButton);


                            }

                        }
                    }

                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                flagConexion = false;
                //MessageBox.Show("Error\n" + ex.ToString(), "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
            }
            if (flagConexion)
            {

                lblConexionVerified.Text = "Conexión establecida";
            }
            else
                lblConexionVerified.Text = "No se ha podido establecer conexión";
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                dataBase = radioButton.Text;
                connectionStringBuilder.InitialCatalog = dataBase;

            }

        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {


            try
            {
                if (dataBase.Length > 0)
                {
                    connectionStringBuilder.DataSource = txtServidor.Text;
                    connectionStringBuilder.InitialCatalog = dataBase;
                    connectionStringBuilder.UserID = txtUsuario.Text;
                    connectionStringBuilder.Password = txtPassword.Text;
                    //  connectionStringBuilder.IntegratedSecurity = false;
                    using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ToString()))
                    {
                        connection.Open();
                        //MessageBox.Show(connectionStringBuilder.ToString());
                        flagConexion = true;

                        connection.Close();
                    }
                }
                else
                {

                    MessageBox.Show("Debes seleccionar una base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            catch (Exception ex)
            {
                flagConexion = false;
                Console.WriteLine(ex.ToString());
            }

            if (flagConexion)
            {

                lblConexionVerified.Text = "Conexión establecida";
            }
            else
                lblConexionVerified.Text = "No se ha podido establecer conexión";
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (flagConexion && dataBase != "")
            {
                try
                {
                    conexionDB.Conexion = connectionStringBuilder.ToString();

                    using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ToString()))
                    {
                        connection.Open();

                        // Consulta SQL para obtener los nombres de las bases de datos
                        string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE  = 'BASE TABLE'"; // Excluyendo bases de sistema

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                tablasDatabase.Clear();
                                while (reader.Read())
                                {
                                    string dbTabla = reader.GetString(0);
                                    tablasDatabase.Add(dbTabla);



                                }
                            }
                        }
                        connection.Close();
                    }
                    var dialogo = new frmDatabase(tablasDatabase, connectionStringBuilder.ToString());

                    dialogo.ShowDialog();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }

                //MessageBox.Show(conexionDB.Conexion);
            }
            else
                MessageBox.Show("Sin acceso a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private List<string> cargarData()
        {
            // Aquí debes obtener la lista de nombres de tablas desde tu base de datos
            List<string> listaTablas = tablasDatabase;
            return listaTablas;
        }




    }
}