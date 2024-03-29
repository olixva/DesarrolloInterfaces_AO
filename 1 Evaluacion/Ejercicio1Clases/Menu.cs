﻿using System;
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

        //Altas
        private void altasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ListarBox.Visible = false;
            PedidosBox.Visible = false;

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

        //Consultas

        //Consulta por nombre
        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarBox.Visible = false;
            PedidosBox.Visible = false;

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

        //Consulta por codigo
        private void porCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarBox.Visible = false;
            PedidosBox.Visible = false;

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
            if (radioCodigo.Checked)//Consulta por codigo
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
                    MessageBox.Show("No existe ningun producto con los datos introducidos");
                }
            }
            else //Consulta por nombre
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

        //Listados

        //Listar Minimos
        private void minimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarBox.Text = "Listar minimos";
            ListarBox.Visible = true;
            AltasCosultasBox.Visible = false;
            PedidosBox.Visible = false;

            txtBoxListar.Text = "";
            cmboBoxCategoria.SelectedIndex = -1;
            lblCategoriaListar.Visible = false;
            cmboBoxCategoriaListar.Visible = false;
        }

        //Listar por Categoria
        private void porCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarBox.Text = "Listar por categoria";
            ListarBox.Visible = true;
            AltasCosultasBox.Visible = false;
            PedidosBox.Visible = false;

            txtBoxListar.Text = "";
            cmboBoxCategoriaListar.SelectedIndex = -1;
            lblCategoriaListar.Visible = true;
            cmboBoxCategoriaListar.Visible = true;
        }

        //Listar todos
        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarBox.Text = "Listar todos";
            ListarBox.Visible = true;
            AltasCosultasBox.Visible = false;
            PedidosBox.Visible = false;

            txtBoxListar.Text = "";
            cmboBoxCategoria.SelectedIndex = -1;
            lblCategoriaListar.Visible = false;
            cmboBoxCategoriaListar.Visible = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtBoxListar.Text = "";

            if (ListarBox.Text == "Listar todos") //Listar todos
            {
                foreach (Articulo item in articulos)
                {
                    txtBoxListar.Text += item.ToString() + "\n";
                }
            }
            else if (ListarBox.Text == "Listar minimos") //Listar minimos
            {
                foreach (Articulo item in articulos)
                {
                    if (item.ExistenciasArticulo < 10)
                    {
                        txtBoxListar.Text += item.ToString() + "\n";
                    }
                }
            }
            else //Listar por categoria 
            {
                foreach (Articulo item in articulos)
                {
                    switch (cmboBoxCategoriaListar.Text) //Miramos que categoria esta seleccionada
                    {
                        case "Informática":
                            if (item.CategoriaArticulo == "Informática")
                            {
                                txtBoxListar.Text += item.ToString() + "\n";
                            }
                            break;

                        case "Imagen":
                            if (item.CategoriaArticulo == "Imagen")
                            {
                                txtBoxListar.Text += item.ToString() + "\n";
                            }
                            break;

                        case "Telefonía":
                            if (item.CategoriaArticulo == "Telefonía")
                            {
                                txtBoxListar.Text += item.ToString() + "\n";
                            }
                            break;

                        case "Sonido":
                            if (item.CategoriaArticulo == "Sonido")
                            {
                                txtBoxListar.Text += item.ToString() + "\n";
                            }
                            break;

                        default:
                            break;
                    }
                }
            }
        }

        //Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Autor
        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Antonio Oliva Carceles 2DAM");
        }

        //Pedidos
        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarBox.Visible = false;
            AltasCosultasBox.Visible = false;

            txtCantidad.Text = "";
            txtIDPedido.Text = "";
            PedidosBox.Visible = true;
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtIDPedido.Text, out int id) && Int32.TryParse(txtCantidad.Text, out int cantidad))
            {
                foreach (Articulo item in articulos)
                {
                    if (item.CodigoArticulo == id)
                    {
                        MessageBox.Show(item.ActualizarExistencias(cantidad));
                    }
                }
            }
        }

        //Metodo para limpiar campos del formulario de insertar y consultas
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
    }
}
