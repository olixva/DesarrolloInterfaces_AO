using System;
using System.Windows.Forms;

namespace Examen_AO
{
    public partial class Menu : Form
    {
        Listados listados;
        AltaPedidoDetalles altasPedidosDet;
        BaseDatos baseDatos;
        public Menu()
        {
            InitializeComponent();
            listados = new Listados();
            listados.MdiParent = this;
            altasPedidosDet = new AltaPedidoDetalles();
            altasPedidosDet.MdiParent = this;
        }

        // Acerca de
        private void acercaDe10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Antonio Oliva Carceles\nPuesto 10");
        }

        // Crear productos demo
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto.CrearProductosDemo();

            productosToolStripMenuItem.Enabled = false;
            pedidosYDetallesToolStripMenuItem.Enabled = true;
        }

        // Abrir Pedidos y detalles
        private void pedidosYDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Si el formulario se ha cerrado, lo volvemos a crear
            if (altasPedidosDet.IsDisposed)
            {
                altasPedidosDet = new AltaPedidoDetalles();
                altasPedidosDet.MdiParent = this;
            }

            altasPedidosDet.Show();
        }

        // Listados
        // Abrir formulario
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Si el formulario se ha cerrado, lo volvemos a crear
            if (listados.IsDisposed)
            {
                listados = new Listados();
                listados.MdiParent = this;
            }

            listados.Show();
        }

        // Abrir listado
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = openFileDialog.FileName;

                // Si el formulario se ha cerrado, lo volvemos a crear
                if (listados.IsDisposed)
                {
                    listados = new Listados();
                    listados.MdiParent = this;
                }

                listados.Show();
                listados.AbrirListado(ruta);
            }
        }

        // Abrir Base de datos
        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Si el formulario se ha cerrado, lo volvemos a crear
            if (baseDatos == null || baseDatos.IsDisposed)
            {
                baseDatos = new BaseDatos();
                baseDatos.MdiParent = this;
            }

            baseDatos.Show();
        }
    }
}
