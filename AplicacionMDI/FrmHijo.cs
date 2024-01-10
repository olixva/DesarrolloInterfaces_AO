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

        public void CargarArchivo(string ruta)
        {
            this.rtbDocumento.LoadFile(ruta, RichTextBoxStreamType.PlainText);
            guardado = true;
            cambios = false;
        }

        public void GuardarArchivo(string ruta)
        {
            this.rtbDocumento.SaveFile(ruta, RichTextBoxStreamType.PlainText);
            guardado = true;
            this.ruta = ruta;
            cambios = false;

            this.Text = Path.GetFileName(ruta);
        }

        public void GuardarCambios()
        {
            if (cambios)
            {
                GuardarArchivo(ruta);
                cambios = false;
            }
        }

        private void rtbDocumento_TextChanged(object sender, System.EventArgs e)
        {
            this.cambios = true;
        }

        internal void CerrarFormulario()
        {
            if (cambios && guardado)
            {
                DialogResult result = MessageBox.Show("Desea guardar los cambios?", Path.GetFileName(ruta), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:
                        GuardarCambios();
                        Application.Exit();
                        break;
                    case DialogResult.No:
                        Application.Exit();
                        break;
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void FrmHijo_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            CerrarFormulario();
        }
    }
}
