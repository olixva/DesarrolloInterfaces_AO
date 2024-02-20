using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Examen_AO
{
    public partial class BaseDatos : Form
    {
        private string connectionString = Properties.Settings.Default.bbddsqlConnectionString;
        public BaseDatos()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bbddsqlDataSet);

        }

        private void BaseDatos_Load(object sender, EventArgs e)
        {
            // Carga datos en la tabla 'bbddsqlDataSet.Orders'
            this.ordersTableAdapter.Fill(this.bbddsqlDataSet.Orders);

        }

        // Actualizamos el DataGridView de detalles con los detalles del pedido seleccionado
        private void orderIDTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM [Order Details] WHERE OrderId=@pedidoId";

                using (SqlConnection connectionSql = new SqlConnection(connectionString))
                {
                    connectionSql.Open();
                    SqlCommand command = new SqlCommand(query, connectionSql);
                    command.Parameters.AddWithValue("@pedidoId", orderIDTextBox.Text);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Crea una tabla en memoria con los datos de la consulta
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asigna la tabla al DataGridView si hay datos
                        dgvDetails.DataSource = dataTable;
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

        // Actualizamos el DataGridView de productos con el id del producto seleccionado
        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Comprobamos que la celda seleccionada sea la de la columna ProductId
            if (dgvDetails.CurrentCell.ColumnIndex != 1)
            {
                return;
            }

            try
            {
                string query = "SELECT * FROM Products WHERE ProductId=@productoId";

                using (SqlConnection connectionSql = new SqlConnection(connectionString))
                {
                    connectionSql.Open();
                    SqlCommand command = new SqlCommand(query, connectionSql);
                    command.Parameters.AddWithValue("@productoId", dgvDetails.SelectedCells[0].Value);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Crea una tabla en memoria con los datos de la consulta
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asigna la tabla al DataGridView si hay datos
                        dgvProducts.DataSource = dataTable;
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
    }
}
