using Hoja1Ejercicios;

namespace PruebaSuma
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }


        private void btnSuma_Click(object sender, EventArgs e)
        {
            int resultado;
            if (FrmMenu.Parse(txtBoxN1.Text, txtBoxN2.Text))
            {
                txtBoxN1.Text = "";
                txtBoxN2.Text = "";
                lblError.Visible = false;

                resultado = FrmMenu.n1s + FrmMenu.n2s;
                lblResultado.Text = resultado.ToString();
                lblResultado.Visible = true;
            }
            else
            {
                lblResultado.Visible = false;
                lblError.Visible = true;

            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            int resultado;
            if (FrmMenu.Parse(txtBoxN1.Text, txtBoxN2.Text))
            {
                txtBoxN1.Text = "";
                txtBoxN2.Text = "";
                lblError.Visible = false;

                resultado = FrmMenu.n1s - FrmMenu.n2s;
                lblResultado.Text = resultado.ToString();
                lblResultado.Visible = true;
            }
            else
            {
                lblResultado.Visible = false;
                lblError.Visible = true;

            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            int resultado;
            if (FrmMenu.Parse(txtBoxN1.Text, txtBoxN2.Text))
            {
                lblError.Visible = false;
                txtBoxN1.Text = "";
                txtBoxN2.Text = "";

                resultado = FrmMenu.n1s * FrmMenu.n2s;
                lblResultado.Text = resultado.ToString();
                lblResultado.Visible = true;
            }
            else
            {
                lblResultado.Visible = false;
                lblError.Visible = true;

            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int resultado;
            if (FrmMenu.Parse(txtBoxN1.Text, txtBoxN2.Text))
            {

                lblError.Visible = false;
                txtBoxN1.Text = "";
                txtBoxN2.Text = "";

                if (FrmMenu.n2s == 0)
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Infinito";
                }
                else
                {
                    resultado = FrmMenu.n1s / FrmMenu.n2s;
                    lblResultado.Text = resultado.ToString();
                    lblResultado.Visible = true;
                }
            }
            else
            {
                lblResultado.Visible = false;
                lblError.Visible = true;
            }
        }

        private void imgVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}