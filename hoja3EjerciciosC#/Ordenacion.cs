using System;
using System.Windows.Forms;

namespace hoja3EjerciciosC_
{
    public partial class Ordenacion : Form
    {
        public Ordenacion()
        {
            InitializeComponent();
        }

        private void imgVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Array.Sort(Altas.alumnos, (a1, a2) => a1.apellido.CompareTo(a2.apellido));

            lblOrdenado.Visible = true;
            btnOrdenar.Enabled = false;
        }
    }
}
