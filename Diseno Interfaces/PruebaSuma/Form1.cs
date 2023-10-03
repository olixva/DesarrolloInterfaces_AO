namespace PruebaSuma
{
    public partial class Calculadora : Form
    {
        static int n1s = 0;
        static int n2s = 0;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int resultado;
            if (parse(txtBoxN1.Text, txtBoxN2.Text))
            {
                txtBoxN1.Text = "";
                txtBoxN2.Text = "";
                labelError.Visible = false;

                resultado = n1s + n2s;
                labelResultado.Text = resultado.ToString();
                labelResultado.Visible = true;
            }
            else
            {
                labelResultado.Visible = false;
                labelError.Visible = true;

            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            int resultado;
            if (parse(txtBoxN1.Text, txtBoxN2.Text))
            {
                txtBoxN1.Text = "";
                txtBoxN2.Text = "";
                labelError.Visible = false;

                resultado = n1s - n2s;
                labelResultado.Text = resultado.ToString();
                labelResultado.Visible = true;
            }
            else
            {
                labelResultado.Visible = false;
                labelError.Visible = true;

            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            int resultado;
            if (parse(txtBoxN1.Text, txtBoxN2.Text))
            {
                labelError.Visible = false;
                txtBoxN1.Text = "";
                txtBoxN2.Text = "";

                resultado = n1s * n2s;
                labelResultado.Text = resultado.ToString();
                labelResultado.Visible = true;
            }
            else
            {
                labelResultado.Visible = false;
                labelError.Visible = true;

            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int resultado;
            if (parse(txtBoxN1.Text, txtBoxN2.Text))
            {

                labelError.Visible = false;
                txtBoxN1.Text = "";
                txtBoxN2.Text = "";

                if (n2s == 0)
                {
                    labelResultado.Visible = true;
                    labelResultado.Text = "Infinito";
                }
                else
                {
                    resultado = n1s / n2s;
                    labelResultado.Text = resultado.ToString();
                    labelResultado.Visible = true;
                }
            }
            else
            {
                labelResultado.Visible = false;
                labelError.Visible = true;
            }
        }

        public Boolean parse(String str1, String str2)
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
    }
}