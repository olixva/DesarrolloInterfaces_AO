namespace Hoja1Ejercicios
{
    public partial class FrmAdivinar : Form
    {
        static int nAleatorio;
        public FrmAdivinar()
        {
            InitializeComponent();
            nAleatorio = new Random().Next(1, 101);
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            Int32.TryParse(txtNum.Text, out int n);
            if (e.KeyCode == Keys.Enter)
            {
                if (n == nAleatorio)
                {
                    lblMensaje.ForeColor = Color.Green;
                    lblMensaje.Text = "         CORRECTO :)";
                    lblMensaje.Visible = true;
                    lblInfo.Visible = false;
                }
                else if (Int32.Parse(lblVidas.Text) > 1)
                {
                    lblMensaje.Visible = true;

                    lblVidas.Text = (Int32.Parse(lblVidas.Text) - 1).ToString();

                    if (n > nAleatorio)
                    {
                        lblInfo.Text = "Te has pasado :(";
                        lblInfo.Visible = true;
                    }
                    else
                    {
                        lblInfo.Text = "Te has quedado corto :(";
                        lblInfo.Visible = true;
                    }
                    txtNum.Text = "";
                }
                else
                {
                    lblVidas.Text = "0";
                    lblMensaje.Text = "Has perdido";

                    txtNum.Visible = false;
                    lblInfo.Visible = false;
                    lblAdivina.Visible = false;
                }
            }
        }

        private void imgVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
