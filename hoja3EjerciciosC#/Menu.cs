using System;
using System.Windows.Forms;

namespace hoja3EjerciciosC_
{
    public partial class Menu : Form
    {
        private Altas altas = new Altas();
        private Consultas consultas = new Consultas();
        private Listar listar = new Listar();
        private Ordenacion ordenacion = new Ordenacion();
        public Menu()
        {
            InitializeComponent();
        }

        private void lblAltas_Click(object sender, EventArgs e)
        {
            altas.Show();
        }

        private void lblConsultas_Click(object sender, EventArgs e)
        {
            consultas.Show();
        }

        private void lblListar_Click(object sender, EventArgs e)
        {
            listar.cargarUsuarios();
            listar.Show();
        }

        private void lblOrdenacion_Click(object sender, EventArgs e)
        {
            ordenacion.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
