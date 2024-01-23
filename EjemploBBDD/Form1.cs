using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace EjemploBBDD
{
    public partial class Form1 : Form
    {
        SqlConnection connectionSql;
        string connectionString;
        public Form1()
        {
            InitializeComponent();
            connectionString = Properties.Settings.Default.Conexion;
            connectionSql = new SqlConnection(connectionString);
        }

        private void CargarDatosConDataReader()
        {
            try
            {
                connectionSql.Open();
                string query = "SELECT * FROM Animal";
                SqlCommand command = new SqlCommand(query, connectionSql);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    // Crea una tabla en memoria con los datos de la consulta
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Asigna la tabla al DataGridView
                    dataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No hay datos");
                }
                connectionSql.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error general: " + ex.Message);
            }
        }


        private void CargarDatosConDataAdapter()
        {
            try
            {
                string query = "SELECT * FROM Animal";

                using (SqlConnection connectionSql = new SqlConnection(connectionString))
                {
                    connectionSql.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionSql))
                    {
                        // Crea una tabla en memoria con los datos de la consulta
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asigna la tabla al DataGridView si hay datos
                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No hay datos");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error general: " + ex.Message);
            }
        }

        private void btnCargarDatos_Click(object sender, System.EventArgs e)
        {
            CargarDatosConDataAdapter();
        }
    }
}
