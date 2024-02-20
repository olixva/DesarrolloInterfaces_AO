using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Examen_AO
{
    public partial class AltaPedidoDetalles : Form
    {
        private DateTime fecha = DateTime.Now;
        public AltaPedidoDetalles()
        {
            InitializeComponent();
            txtFecha.Text = fecha.ToShortDateString();
            txtCodPed.Text = (Pedido.pedidos.Count + 1).ToString();
        }

        // Cancelar pedido
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Guardar pedido
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Comprobamos que los campos no estén vacíos
            if (txtCodClie.Text == "")
            {
                MessageBox.Show("Introduce un codigo de cliente");
                return;
            }

            // Creamos el pedido
            Pedido pedido = new Pedido(Int32.Parse(txtCodPed.Text), Int32.Parse(txtCodClie.Text), fecha);
            Pedido.pedidos.Add(pedido);

            // Habilitamos los detalles
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            txtCodClie.Enabled = false;
            grpDetallesPedido.Enabled = true;
        }

        // Al cargar el formulario
        private void AltaPedidoDetalles_Load(object sender, EventArgs e)
        {
            txtCodClie.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            grpDetallesPedido.Enabled = false;
        }

        // Controlamos el evento para que no deje introducir letras
        private void txtCodClie_TextChanged(object sender, EventArgs e)
        {
            ComprobarNumericoTxtBox(txtCodClie);
        }

        private void txtCodPro_TextChanged(object sender, EventArgs e)
        {
            ComprobarNumericoTxtBox(txtCodPro);
        }

        private void txtCantProd_TextChanged(object sender, EventArgs e)
        {
            ComprobarNumericoTxtBox(txtCantProd);
        }

        private void ComprobarNumericoTxtBox(TextBox txt)
        {
            if (Regex.IsMatch(txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Introduce solo números");
                txt.Text = Regex.Replace(txt.Text, "[^0-9]", "");
            }
        }

        // Agregar detalles
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            // Comprobamos que los campos no estén vacíos 
            if (txtCodPro.Text == "" | txtCantProd.Text == "")
            {
                MessageBox.Show("Debes rellenar todos los campos");
                return;
            }

            // Compromabos que la cantidad no sea 0
            if (txtCantProd.Text == "0")
            {
                MessageBox.Show("La cantidad no puede ser 0");
                return;
            }

            Producto producto = Producto.BuscarProducto(Int32.Parse(txtCodPro.Text));
            // Comprobamos que el producto exista
            if (producto == null)
            {
                MessageBox.Show("El producto no existe");
                return;
            }

            // Comprobamos que la cantidad no sea mayor que el stock
            if (producto.StockPro < Int32.Parse(txtCantProd.Text))
            {
                MessageBox.Show($"No hay suficiente stock\nStock disponible: {producto.StockPro}");
                txtCantProd.Focus();
                return;
            }

            // Creamos el detalle
            DetallePed.detallesPeds.Add(new DetallePed(Int32.Parse(txtCodPed.Text), Int32.Parse(txtCodPro.Text), Int32.Parse(txtCantProd.Text)));

            // Restamos la cantidad del stock
            producto.StockPro -= Int32.Parse(txtCantProd.Text);
            MessageBox.Show($"Detalle de pedido guardado\nCodigo producto {producto.CodPro}\nCantidad pedida: {txtCantProd.Text}\nStock restante: {producto.StockPro}");

            // Borramos los campos
            txtCodPro.Text = "";
            txtCantProd.Text = "";
            txtCodPro.Focus();

        }

    }
}
