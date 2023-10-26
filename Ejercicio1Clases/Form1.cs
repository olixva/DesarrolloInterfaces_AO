using System.Windows.Forms;

namespace Ejercicio1Clases
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void altasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AltasCosultasBox.Visible = true;
        }
    }
}
