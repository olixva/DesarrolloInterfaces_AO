namespace Hoja1Ejercicios
{
    public partial class FrmArea : Form
    {
        public FrmArea()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rbtnCuadrado.Checked || rbtnRectangulo.Checked)
            {
                if (FrmMenu.Parse(txtBase.Text, txtAltura.Text))
                {
                    txtBase.Text = "";
                    txtAltura.Text = "";
                    lblError.Visible = false;

                    lblResArea.Text = (FrmMenu.n1s * FrmMenu.n2s).ToString();
                    lblResArea.Visible = true;

                    lblResPerimetro.Text = ((FrmMenu.n1s + FrmMenu.n2s) * 2).ToString();
                    lblResPerimetro.Visible = true;
                }
                else
                {
                    lblResArea.Visible = false;
                    lblError.Visible = true;
                }
            }
            else if (rbtnTriangulo.Checked)
            {
                if (FrmMenu.Parse(txtBase.Text, txtAltura.Text))
                {
                    txtBase.Text = "";
                    txtAltura.Text = "";
                    lblError.Visible = false;

                    lblResArea.Text = ((FrmMenu.n1s * FrmMenu.n2s) / 2).ToString();
                    lblResArea.Visible = true;

                    lblResPerimetro.Text = "A saber";
                    lblResPerimetro.Visible = true;
                }
                else
                {
                    lblResArea.Visible = false;
                    lblError.Visible = true;
                }
            }
        }

        private void imgVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}