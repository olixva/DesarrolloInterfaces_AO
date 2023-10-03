namespace Hoja1Ejercicios
{
    public partial class FrmFunciones : Form
    {
        public FrmFunciones()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtNum.Text, out int n) && (n > 0))
            {
                txtNum.Text = "";
                lblError.Visible = false;

                lblResFibo.Text = (CalcularFibonacci(n)).ToString();
                lblResFibo.Visible = true;

                if (n > 14)
                {
                    lblResFac.Text = "Demasiado grande";
                    lblResFac.Visible = true;
                }
                else
                {
                    lblResFac.Text = (CalcularFactorial(n)).ToString();
                    lblResFac.Visible = true;
                }

            }
            else
            {
                lblResFac.Visible = false;
                lblResFibo.Visible = false;
                lblError.Visible = true;
            }
        }

        private int CalcularFibonacci(int n)
        {
            if ((n == 1) || (n == 2))
            {
                return 1;
            }
            else
            {
                return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
            }
        }

        private int CalcularFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            int resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
        private void imgVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
