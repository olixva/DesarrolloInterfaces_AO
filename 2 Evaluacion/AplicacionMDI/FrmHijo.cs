using System.IO;
using System.Windows.Forms;

namespace AplicacionMDI
{
    public partial class FrmHijo : Form
    {
        private static int contador = 0;

        // Indica si el documento esta guardado en disco
        private bool guardado;
        // Indica si el documento ha sufrido cambios desde la ultima vez que se guardo
        private bool cambios;
        // Indica la ruta del archivo en disco
        private string ruta;
        public bool Guardado { get => guardado; set => guardado = value; }
        public bool Cambios { get => cambios; set => cambios = value; }

        public FrmHijo()
        {
            InitializeComponent();
            contador++;

            this.Text = "Documento sin titulo " + contador;

            guardado = false;
            cambios = false;
        }

        public FrmHijo(string nombre)
        {
            InitializeComponent();
            this.Text = nombre;

            guardado = false;
            cambios = false;
        }

        //Metodo que carga un archivo dada una ruta
        public void CargarArchivo(string ruta)
        {
            this.rtbDocumento.LoadFile(ruta, RichTextBoxStreamType.PlainText);
            guardado = true;
            cambios = false;
        }

        //Metodo que pide la ruta del archivo y lo guarda
        public void CrearArchivo()
        {
            saveFileDialog.FileName = this.Text;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.GuardarArchivo(saveFileDialog.FileName);
            }
        }

        //Metodo que comprueba si hay cambios en el documento y lo guarda
        public void GuardarCambios()
        {
            if (cambios)
            {
                GuardarArchivo(ruta);
                cambios = false;
            }
        }

        //Metodo que crea un nuevo archivo o sobreescribe (Guarda cambios) dada una ruta
        public void GuardarArchivo(string ruta)
        {
            this.rtbDocumento.SaveFile(ruta, RichTextBoxStreamType.PlainText);
            guardado = true;
            this.ruta = ruta;
            cambios = false;

            this.Text = Path.GetFileName(ruta);
        }

        //Cuando se modifica el documento cambia el estado de cambios
        private void rtbDocumento_TextChanged(object sender, System.EventArgs e)
        {
            this.cambios = true;
        }

        //Cuando se cierra el formulario llama al metodo CerrarFormulario
        private void FrmHijo_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario(e);
        }

        //Comprueba si hay cambios y si el documento esta guardado en disco
        internal void CerrarFormulario(FormClosingEventArgs e)
        {
            if (cambios && !guardado)
            {
                CerrarFormularioNoGuardado(e);
            }
            else if (cambios && guardado)
            {
                CerrarFormularioGuardado(e);
            }
        }

        //Si el coumento no esta guardado en disco pregunta si se quiere guardar en disco
        private void CerrarFormularioNoGuardado(FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea guardar el documento?", Path.GetFileName(ruta), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    CrearArchivo();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        //Si el documento esta guardado en disco pregunta si se quieren guardar los cambios
        private void CerrarFormularioGuardado(FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea guardar los cambios?", "Done", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    GuardarCambios();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            rtbDocumento.Copy();
        }

        private void cortarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            rtbDocumento.Cut();
        }

        private void pegarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            rtbDocumento.Paste();
        }
    }
}

