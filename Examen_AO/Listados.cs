using System.Windows.Forms;

namespace Examen_AO
{
    public partial class Listados : Form
    {
        public Listados()
        {
            InitializeComponent();
        }

        // Al cargar el formulario, rellenamos el combo con los productos
        private void Listados_Load(object sender, System.EventArgs e)
        {
            foreach (Pedido p in Pedido.pedidos)
            {
                cmbNPedido.Items.Add(p.CodPedi);
            }

            richTextBox.Text = "Seleccione un pedido para ver sus detalles";
        }

        private void cmbNPedido_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            richTextBox.Clear();

            Pedido pedido = Pedido.pedidos[cmbNPedido.SelectedIndex];

            richTextBox.AppendText($"Pedido: {pedido.CodPedi} \t Cliente: {pedido.CodCliPedi}\n\n");
            richTextBox.AppendText($"Codigo \t Producto \t Cantidad \t Precio\n");

            foreach (DetallePed dp in DetallePed.detallesPeds)
            {
                if (dp.CodPediDetal == pedido.CodPedi)
                {
                    Producto producto = Producto.BuscarProducto(dp.CodProDetal);
                    richTextBox.AppendText($"\n{dp.CodProDetal} \t {producto.NombPro} \t {dp.CantidadDetal} \t \t {producto.PrecioPro}");
                }
            }
        }

        // Guardar listado en fichero
        private void btnGuardar_Click(object sender, System.EventArgs e)
        {

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = saveFileDialog.FileName;

                richTextBox.SaveFile(ruta, RichTextBoxStreamType.PlainText);
            }
        }

        // Abre un listado desde fichero
        public void AbrirListado(string ruta)
        {
            richTextBox.LoadFile(ruta, RichTextBoxStreamType.PlainText);
        }

        // Cerrar formulario
        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }
    }
}
