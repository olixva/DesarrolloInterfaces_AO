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

        // Metodo para actualizar el hijo activo
        private void ActualizarHijoActivo()
        {
            hijoActivo = this.ActiveMdiChild;
            cajaTextoActiva = (RichTextBox)hijoActivo?.ActiveControl;
        }

        // Crear un nuevo archivo
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearArchivo();
            ActualizarHijoActivo();
        }

        private void nuevoToolStripButton_Click(object sender, EventArgs e)
        {
            CrearArchivo();
            ActualizarHijoActivo();
        }

        private void CrearArchivo()
        {
            FrmHijo frmHijo = new FrmHijo();
            frmHijo.MdiParent = this;
            frmHijo.Show();
        }

        //Abrir un archivo
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirArchivo();
            ActualizarHijoActivo();
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            AbrirArchivo();
            ActualizarHijoActivo();
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
            ActualizarHijoActivo();
            GuardarArchivo();
        }

        private void GuardarArchivo()
        {
            if (hijoActivo != null)
            {
                saveFileDialog.FileName = hijoActivo.Text;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ((FrmHijo)hijoActivo).GuardarArchivo(saveFileDialog.FileName);
                }
            }

        }

        //Guardar cambios
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarHijoActivo();
            GuardarCambios();
        }
        private void guardarToolStripButton_Click(object sender, EventArgs e)
        {
            ActualizarHijoActivo();
            GuardarCambios();
        }

        private void GuardarCambios()
        {
            if (((FrmHijo)hijoActivo).Guardado)
            {
                ((FrmHijo)hijoActivo).GuardarCambios();
            }
            else
            {
                GuardarArchivo();
            }
        }

        //Editar

        //Desahacer
        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarHijoActivo();
            cajaTextoActiva?.Undo();
        }

        //Rehacer
        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarHijoActivo();
            cajaTextoActiva?.Redo();
        }

        //Cortar
        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cortar();
        }

        private void cortarToolStripButton_Click(object sender, EventArgs e)
        {
            Cortar();
        }

        private void Cortar()
        {
            ActualizarHijoActivo();
            cajaTextoActiva?.Cut();
        }

        //Copiar
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void copiarToolStripButton_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void Copiar()
        {
            ActualizarHijoActivo();
            cajaTextoActiva?.Copy();
        }

        //Pegar
        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pegar();
        }

        private void pegarToolStripButton_Click(object sender, EventArgs e)
        {
            Pegar();
        }

        private void Pegar()
        {
            ActualizarHijoActivo();
            cajaTextoActiva?.Paste();
        }


        //Seleccionar todo
        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarHijoActivo();
            cajaTextoActiva?.SelectAll();
        }

        //Formato

        //Cambiar color de fondo de las cajas
        private void cambiarColorFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarHijoActivo();
            colorDialog.ShowDialog();
            cajaTextoActiva.BackColor = colorDialog.Color;
        }

        //Cambiar tipo de fuente
        private void colorTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarHijoActivo();
            colorDialog.ShowDialog();
            cajaTextoActiva.ForeColor = colorDialog.Color;
        }

        //Cambiar fondo del texto
        private void fondoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarHijoActivo();
            colorDialog.ShowDialog();
            cajaTextoActiva.SelectionBackColor = colorDialog.Color;
        }

        //Cambiar tipo de fuente
        private void formatoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarHijoActivo();
            fontDialog.ShowDialog();
            cajaTextoActiva.SelectionFont = fontDialog.Font;
        }

        //Opciones de ventana
        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horixontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        //Al cerrar el formulario o salir 
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormularios();
        }
        private void FrmPadre_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormularios();
        }

        private void CerrarFormularios()
        {
            foreach (Form frm in this.MdiChildren)
            {
                ((FrmHijo)frm).CerrarFormulario();
            }
        }
    }
}
