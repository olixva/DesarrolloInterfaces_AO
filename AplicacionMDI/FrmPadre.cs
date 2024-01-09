using System;
using System.Windows.Forms;

namespace AplicacionMDI
{
    public partial class FrmPadre : Form
    {

        Form hijoActivo;
        RichTextBox cajaTextoActiva;

        public FrmPadre()
        {
            InitializeComponent();
        }

        // Crear un nuevo archivo
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crearArchivo();
        }

        private void nuevoToolStripButton_Click(object sender, EventArgs e)
        {
            crearArchivo();
        }

        private void crearArchivo()
        {
            FrmHijo frmHijo = new FrmHijo();
            frmHijo.MdiParent = this;
            frmHijo.Show();
        }

        // Funcion de copiar
        private void copiarToolStripButton_Click(object sender, EventArgs e)
        {
            actualizarHijoActivo();

        }

        // Metodo para cambiar color de fondo de las cajas
        private void cambiarColorFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizarHijoActivo();
            colorDialog.ShowDialog();
            cajaTextoActiva.BackColor = colorDialog.Color;
        }

        // Metodo para actualizar el hijo activo
        private void actualizarHijoActivo()
        {
            hijoActivo = this.ActiveMdiChild;
            cajaTextoActiva = (RichTextBox)hijoActivo.ActiveControl;
        }

        //Abrir un archivo
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirArchivo();
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            AbrirArchivo();
        }

        private void AbrirArchivo()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FrmHijo frmHijo = new FrmHijo(openFileDialog.SafeFileName);
                frmHijo.MdiParent = this;

                frmHijo.Show();
                frmHijo.CargarArchivo(openFileDialog.FileName);
            }
        }

        // Guardar un archivo
        private void guardarcomoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizarHijoActivo();
            GuardarArchivo();
        }

        private void GuardarArchivo()
        {
            saveFileDialog.FileName = hijoActivo.Text;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ((FrmHijo)hijoActivo).GuardarArchivo(saveFileDialog.FileName);
            }
        }

    }
}
