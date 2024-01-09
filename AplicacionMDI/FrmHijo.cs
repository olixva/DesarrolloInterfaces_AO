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
            cambios = false;

            this.Text = Path.GetFileName(ruta);
        }


    }
}
