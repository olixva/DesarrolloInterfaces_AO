using System;
using System.Windows.Forms;

namespace hoja2EjerciciosC_
{
    public partial class Ejercicio1 : Form
    {
        private static int[] numeros = new int[10];
        private static int indice = 0;
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void txtNumeros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Int32.TryParse(txtIntroNum.Text, out int n))
            {

                numeros[indice] = n;
                listBoxNumeros.Items.Add(n);
                indice++;
                txtIntroNum.Text = "";


                if (esPrimo(n))
                {
                    lblEsPrimo.Text = n.ToString() + " es Primo";
                }
                else
                {
                    lblEsPrimo.Text = n.ToString() + " no es Primo";
                }
                lblEsPrimo.Visible = true;

                if (indice == 10)
                {
                    txtIntroNum.Enabled = false;
                    btnOrdCacl.Enabled = true;
                    btnBuscar.Enabled = true;
                }
            }
        }

        private void btnOrdCacl_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private bool esPrimo(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
