using System;
using System.Windows.Forms;

namespace ADONetExample
{
    public partial class Navegacion : Form
    {
        public Navegacion()
        {
            InitializeComponent();
        }

        private void btnGoAdd_Click(object sender, EventArgs e)
        {
            Form frm = new NewCustomer();
            frm.Show();
        }

        private void btnGoToFillOrCancell_Click(object sender, EventArgs e)
        {
            Form frm = new FillOrCancel();
            frm.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
