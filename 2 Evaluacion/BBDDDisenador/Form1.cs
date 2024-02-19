using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BBDDDisenador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string connectionString = Properties.Settings.Default.ZooBDConnectionString;

        private void zooBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zooBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooBDDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar los zoos
            this.animalTableAdapter.Fill(this.zooBDDataSet.Animal);

            // Cargar los animales del zoo
            this.zooTableAdapter.Fill(this.zooBDDataSet.Zoo);

            // Cargar los animales del zoo
            CargarAnimalesPorZoo();

        }

        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            CargarAnimalesPorZoo();
        }

        private void CargarAnimalesPorZoo()
        {
            try
            {
                string query = "SELECT * FROM Animal a INNER JOIN AnimalZoo az ON a.Id=az.animalId WHERE az.zooId=@zooId";

                using (SqlConnection connectionSql = new SqlConnection(connectionString))
                {
                    connectionSql.Open();
                    SqlCommand command = new SqlCommand(query, connectionSql);
                    command.Parameters.AddWithValue("@zooId", idTextBox.Text);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Crea una tabla en memoria con los datos de la consulta
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asigna la tabla al DataGridView si hay datos

                        dgvAnimalesZoo.DataSource = dataTable;
                        dgvAnimalesZoo.Columns.Remove("id");
                        dgvAnimalesZoo.Columns.Remove("id1");
                        dgvAnimalesZoo.Columns.Remove("zooId");
                        dgvAnimalesZoo.Columns.Remove("animalId");
                        dgvAnimalesZoo.Columns[0].HeaderText = "Animales";
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

        private void btnAsignarAnimal_Click(object sender, EventArgs e)
        {
            AgregarAnimalZoo(idTextBox.Text);
            CargarAnimalesPorZoo();
        }


        private int AgregarAnimalZoo(string zooId)
        {
            try
            {
                string query = "INSERT INTO AnimalZoo VALUES (@ZooId, @AnimalId)";

                using (SqlConnection connectionSql = new SqlConnection(connectionString))
                {
                    connectionSql.Open();
                    SqlCommand command = new SqlCommand(query, connectionSql);
                    command.Parameters.AddWithValue("@ZooId", zooId);
                    command.Parameters.AddWithValue("@AnimalId", dvgAnimales.SelectedCells[0].Value);

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

        private void dvgAnimales_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.animalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooBDDataSet);
        }
    }
}
