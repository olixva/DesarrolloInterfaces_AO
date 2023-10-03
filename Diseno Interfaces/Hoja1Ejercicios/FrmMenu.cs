using PruebaSuma;

namespace Hoja1Ejercicios
{
    public partial class FrmMenu : Form
    {
        public static int n1s;
        public static int n2s;
        public FrmMenu()
        {
            InitializeComponent();
        }

        public static Boolean Parse(String str1, String str2)
        {
            if (Int32.TryParse(str1, out int n1) && (Int32.TryParse(str2, out int n2)))
            {
                n1s = n1;
                n2s = n2;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            switch (txtOpcion.Text)
            {
                case "1":
                case "Calculadora":
                    lblError.Visible = false;

                    FrmCalculadora frmCalc = new FrmCalculadora();
                    frmCalc.Show();
                    break;

                case "2":
                case "Area":
                    lblError.Visible = false;

                    FrmArea frmArea = new FrmArea();
                    frmArea.Show();
                    break;

                case "3":
                case "Funciones":
                    lblError.Visible = false;

                    FrmFunciones frmFunc = new FrmFunciones();
                    frmFunc.Show();
                    break;
                default:
                    lblError.Visible = true;
                    break;

            }
        }
    }
}
