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

        //Cargar datos en el DataGridView con un DataReader 
        //Util si solo se va a leer los datos una vez
        private void CargarAnimalesDataGridConDataReader()
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


        //Cargar datos en el DataGridView con un DataAdapter
        //Util si se va a leer los datos varias veces o realizar operaciones en los datos
        private void CargarAnimalesDataGridConDataAdapter()
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
            CargarAnimalesDataGridConDataAdapter();
        }

        //Cargar datos en el ListBox de Zoos con un DataAdapter
        private void CargarDatosZooListBox()
        {
            try
            {
                string query = "SELECT * FROM Zoo";

                using (SqlConnection connectionSql = new SqlConnection(connectionString))
                {
                    connectionSql.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionSql))
                    {
                        // Crea una tabla en memoria con los datos de la consulta
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asigna la tabla al ListBox si hay datos
                        if (dataTable.Rows.Count > 0)
                        {
                            listBoxZoos.DisplayMember = "Ubicacion";
                            listBoxZoos.ValueMember = "Id";
                            listBoxZoos.DataSource = dataTable;
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

        private void btnCargarZooListBox_Click(object sender, EventArgs e)
        {
            CargarDatosZooListBox();
        }

        //Cargar datos en el ListBox de Animales con un DataAdapter

        private void CargarAnimalesListBox()
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

                        // Asigna la tabla al ListBox si hay datos
                        if (dataTable.Rows.Count > 0)
                        {
                            listBoxAnimales.DisplayMember = "Nombre";
                            listBoxAnimales.ValueMember = "Id";
                            listBoxAnimales.DataSource = dataTable;
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


        private void btnCargarAnimalesList_Click(object sender, EventArgs e)
        {
            CargarAnimalesListBox();
        }

        //Cargar datos en el ListBox de AnimalesZoo con un DataAdapter
        private void CargarAnimalesPorZooListBox()
        {
            try
            {
                string query = "SELECT * FROM Animal a INNER JOIN AnimalZoo az ON a.Id=az.animalId WHERE az.zooId=@zooId";

                using (SqlConnection connectionSql = new SqlConnection(connectionString))
                {
                    connectionSql.Open();
                    SqlCommand command = new SqlCommand(query, connectionSql);
                    command.Parameters.AddWithValue("@zooId", listBoxZoos.SelectedValue);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Crea una tabla en memoria con los datos de la consulta
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asigna la tabla al DataGridView si hay datos
                        if (dataTable.Rows.Count > 0)
                        {
                            listBoxAnimalesZoo.DisplayMember = "Nombre";
                            listBoxAnimalesZoo.ValueMember = "Id";
                            listBoxAnimalesZoo.DataSource = dataTable;
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

        private void listBoxZoos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarAnimalesPorZooListBox();
        }

        //Cargar datos en la tabla de Zoo ejecutando directamente el SqlCommand
        private int AgregarZoo(String nombre)
        {
            try
            {
                string query = "INSERT INTO Zoo VALUES (@Ubicacion)";

                using (SqlConnection connectionSql = new SqlConnection(connectionString))
                {
                    connectionSql.Open();
                    SqlCommand command = new SqlCommand(query, connectionSql);
                    command.Parameters.AddWithValue("@Ubicacion", nombre);

                    return command.ExecuteNonQuery();
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
            return 0;
        }

        private void btnInsertarZoo_Click(object sender, EventArgs e)
        {
            if (txtBoxInsertarZoo.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre de zoo");
            }
            else
            {
                AgregarZoo(txtBoxInsertarZoo.Text);
                CargarDatosZooListBox();
                txtBoxInsertarZoo.Text = "";
            }
        }

        //Borrar datos en la tabla de Zoo ejecutando directamente el SqlCommand
        private int BorrarZoo(int id)
        {
            try
            {
                string query = "DELETE FROM Zoo WHERE id = @ZooId";

                using (SqlConnection connectionSql = new SqlConnection(connectionString))
                {
                    connectionSql.Open();
                    SqlCommand command = new SqlCommand(query, connectionSql);
                    command.Parameters.AddWithValue("@ZooId", id);

                    return command.ExecuteNonQuery();
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
            return 0;
        }

        private void btnBorrarZoo_Click(object sender, EventArgs e)
        {
            if (listBoxZoos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un zoo");
            }
            else
            {
                if (BorrarZoo((int)listBoxZoos.SelectedValue) != 0)
                {
                    CargarDatosZooListBox();
                }
                else
                {
                    MessageBox.Show("No se ha podido borrar el zoo");
                }
            }
        }

        //Cargar datos en la tabla de AnimalZoo ejecutando directamente el SqlCommand
        private int AgregarAnimalZoo(int zooId, int animalId)
        {
            try
            {
                string query = "INSERT INTO AnimalZoo VALUES (@ZooId, @AnimalId)";

                using (SqlConnection connectionSql = new SqlConnection(connectionString))
                {
                    connectionSql.Open();
                    SqlCommand command = new SqlCommand(query, connectionSql);
                    command.Parameters.AddWithValue("@ZooId", zooId);
                    command.Parameters.AddWithValue("@AnimalId", animalId);

                    return command.ExecuteNonQuery();
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
            return 0;
        }

        private void btnAsignarAnimalZoo_Click(object sender, EventArgs e)
        {
            if (listBoxZoos.SelectedIndex == -1 || listBoxAnimales.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Animal y un Zoo");
            }
            else
            {
                if (AgregarAnimalZoo((int)listBoxZoos.SelectedValue, (int)listBoxAnimales.SelectedValue) != 0)
                {
                    CargarAnimalesPorZooListBox();
                }
                else
                {
                    MessageBox.Show("No se ha podido borrar el zoo");
                }
            }
        }
    }
}


