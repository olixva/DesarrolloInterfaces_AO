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


                if (EsPrimo(n))
                {
                    lblEsPrimo.Text = $"{n} es Primo";
                }
                else
                {
                    lblEsPrimo.Text = $"{n} no es Primo";
                }
                lblEsPrimo.Visible = true;

                if (indice == 10)
                {
                    txtIntroNum.Enabled = false;
                    txtBuscar.Enabled = true;
                    btnOrdCacl.Enabled = true;
                    btnBuscar.Enabled = true;
                }
            }
        }

        private void btnOrdCacl_Click(object sender, EventArgs e)
        {
            float media = 0f;

            lblNPrimo.Visible = false;
            lblEsPrimo.Visible = false;

            Ordenar(numeros);
            listBoxNumeros.Items.Clear();
            foreach (int n in numeros)
            {
                listBoxNumeros.Items.Add(n);
                media += n;
            }
            media /= 10;
            lblMayor.Text = $"El numero mayor es: {numeros[9]}";
            lblMenor.Text = $"El numero menor es: {numeros[0]}";
            lblMedia.Text = $"La media es {media}";
            lblMayor.Visible = true;
            lblMenor.Visible = true;
            lblMedia.Visible = true;

            btnOrdCacl.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtBuscar.Text, out int buscar))
            {
                int i = 0;
                foreach (int n in numeros)
                {
                    if (n == buscar)
                    {
                        i++;
                    }
                }
                lblRepite.Text = $"El numero {buscar} se repite: {i} veces";
                lblRepite.Visible = true;
            }

        }

        private bool EsPrimo(int n)
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

        private void Ordenar(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
