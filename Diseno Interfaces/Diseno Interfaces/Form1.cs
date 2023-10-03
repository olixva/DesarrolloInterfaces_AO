namespace Diseno_Interfaces
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }


        private void btnSi_Click(object sender, EventArgs e)
        {
            lblPeticion.ForeColor = Color.Blue;
            lblPeticion.Text = "Gracias :)";
            btnNo.Visible = false;
            btnSi.Visible = false;
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int x = random.Next(0, this.ClientSize.Width - btnNo.Width);
            int y = random.Next(0, this.ClientSize.Height - btnNo.Height);

            btnNo.Location = new System.Drawing.Point(x, y);
        }

        private void btnSi_MouseHover(object sender, EventArgs e)
        {
            btnSi.Text = "Esta es la opcion buena";
        }

        private void btnSi_MouseLeave(object sender, EventArgs e)
        {
            btnSi.Text = "Si";
            btnSi.Size = new System.Drawing.Size(113, 87);
        }

        private void btnNo_MouseHover(object sender, EventArgs e)
        {
            btnNo.Text = "Esta NO es la opcion buena";
        }

        private void btnNo_MouseLeave(object sender, EventArgs e)
        {
            btnNo.Text = "No";
            btnNo.Size = new System.Drawing.Size(113, 87);
        }
    }
}
