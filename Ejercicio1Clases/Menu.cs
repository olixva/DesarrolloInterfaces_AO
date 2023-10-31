using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejercicio1Clases
{
    public partial class Menu : Form
    {
        private static List<Articulo> articulos = new List<Articulo>();
        public Menu()
        {
            InitializeComponent();
        }

        private void altasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ListarBox.Visible = false;

            AltasCosultasBox.Text = "Altas";
            btnConsultar.Visible = false;
            grpBoxRadio.Visible = false;
            btnCrear.Visible = true;

            limpiarCampos();
            txtId.Text = (Articulo.NArticulos + 1).ToString();
            txtId.Enabled = false;
            txtNombre.Enabled = true;
            cmboBoxCategoria.Enabled = true;
            txtPrecio.Enabled = true;
            txtExistencias.Enabled = true;

            AltasCosultasBox.Visible = true;
        }

        private void btnCrear_Click(object sender, System.EventArgs e)
        {
            bool fallo = false;

            string nombreArticulo = txtNombre.Text;
            string categoriaArticulo = "";
            decimal precioArticulo = 0;
            int existenciasArticulo = 0;

            if ((cmboBoxCategoria.Text.ToLower().Equals("informática")) || (cmboBoxCategoria.Text.ToLower().Equals("imagen")) ||
            (cmboBoxCategoria.Text.ToLower().Equals("telefonía")) || (cmboBoxCategoria.Text.ToLower().Equals("sonido")))
            {
                categoriaArticulo = cmboBoxCategoria.Text;
                error.SetError(cmboBoxCategoria, "");
            }
            else
            {
                error.SetError(cmboBoxCategoria, "Categoria no valida");
                fallo = true;
            }

            if (Decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                precioArticulo = precio;
                error.SetError(txtPrecio, "");
            }
            else
            {
                error.SetError(txtPrecio, "Formato no valido");
                fallo = true;
            }

            if (Int32.TryParse(txtExistencias.Text, out int existencias))
            {
                existenciasArticulo = existencias;
                error.SetError(txtExistencias, "");
            }
            else
            {
                error.SetError(txtExistencias, "Formato no valido");
                fallo = true;
            }

            if (!fallo)
            {
                Articulo articulo = new Articulo(nombreArticulo, categoriaArticulo, precioArticulo, existenciasArticulo);
                articulos.Add(articulo);

                txtId.Text = (articulo.CodigoArticulo + 1).ToString();
                MessageBox.Show("Articulo creado correctamente");
            }
            else
            {
                MessageBox.Show("Articulo no creado");
            }

        }

        private void limpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtExistencias.Text = "";
            cmboBoxCategoria.SelectedIndex = -1;

            error.SetError(txtId, "");
            error.SetError(cmboBoxCategoria, "");
            error.SetError(txtPrecio, "");
            error.SetError(txtExistencias, "");
        }

        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarBox.Visible = false;

            AltasCosultasBox.Text = "Consultas";
            btnCrear.Visible = false;
            btnConsultar.Visible = true;
            grpBoxRadio.Visible = true;
            radioNombre.Checked = true;

            limpiarCampos();
            txtId.Enabled = false;
            txtNombre.Enabled = true;
            cmboBoxCategoria.Enabled = false;
            txtPrecio.Enabled = false;
            txtExistencias.Enabled = false;

            AltasCosultasBox.Visible = true;
        }

        private void porCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarBox.Visible = false;

            AltasCosultasBox.Text = "Consultas";
            btnCrear.Visible = false;
            btnConsultar.Visible = true;
            grpBoxRadio.Visible = true;
            radioCodigo.Checked = true;

            limpiarCampos();
            txtId.Enabled = true;
            txtNombre.Enabled = false;
            cmboBoxCategoria.Enabled = false;
            txtPrecio.Enabled = false;
            txtExistencias.Enabled = false;

            AltasCosultasBox.Visible = true;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (radioCodigo.Checked)
            {
                bool encontrado = false;
                foreach (Articulo item in articulos)
                {
                    if (Int32.TryParse(txtId.Text, out int codigo))
                    {
                        if (item.CodigoArticulo == codigo)
                        {
                            encontrado = true;
                            MessageBox.Show(item.ToString());
                        }
                    }
                    else
                    {
                        error.SetError(txtId, "Formato invalido");
                    }
                }
                if (!encontrado)
                {
                    MessageBox.Show("No existe ningun usuario con los datos introducidos");
                }
            }
            else
            {
                bool encontrado = false;

                foreach (Articulo item in articulos)
                {
                    if (item.NombreArticulo == txtNombre.Text)
                    {
                        MessageBox.Show(item.ToString());
                        encontrado = true;
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show("No existe ningun usuario con los datos introducidos");
                }
            }
        }

        private void radioNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtNombre.Enabled = true;
            cmboBoxCategoria.Enabled = false;
            txtPrecio.Enabled = false;
            txtExistencias.Enabled = false;

            limpiarCampos();
        }

        private void radioCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNombre.Enabled = false;
            cmboBoxCategoria.Enabled = false;
            txtPrecio.Enabled = false;
            txtExistencias.Enabled = false;

            limpiarCampos();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarBox.Visible = true;
            AltasCosultasBox.Visible = false;

            txtBoxListar.Text = "";
            cmboBoxCategoria.SelectedIndex = -1;
            lblCategoriaListar.Visible = false;
            cmboBoxCategoriaListar.Visible = false;
        }

        private void porCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarBox.Visible = true;
            AltasCosultasBox.Visible = false;

            txtBoxListar.Text = "";
            cmboBoxCategoria.SelectedIndex = -1;
            lblCategoriaListar.Visible = true;
            cmboBoxCategoriaListar.Visible = true;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtBoxListar.Text = "";

            if (todosToolStripMenuItem.Enabled == true)
            {
                foreach (Articulo item in articulos)
                {
                    txtBoxListar.Text += item.ToString() + "\n";
                }
            }
            else
            {

            }
        }
    }
}
