using System;
using System.Windows.Forms;

namespace hoja3EjerciciosC_
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void imgVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = string.Empty;

            bool usuarioEncontrado = false;
            for (int i = 0; i < Altas.alumnosCreados; i++)
            {
                Altas.Alumno alumno = Altas.alumnos[i];
                if (txtNombre.Text.ToLower() == alumno.nombre.ToLower())
                {
                    lblUsuario.Text += $"\n Id: {alumno.idAlumno} Nombre: {alumno.nombre} " +
                    $"Apellido: {alumno.apellido} Telefono: {alumno.telefono} " +
                    $"Email: {alumno.email} Curso: {alumno.curso}";

                    lblUsuario.Visible = true;
                    usuarioEncontrado = true;
                }
            }
            if (!usuarioEncontrado)
            {
                lblNoEncontado.Visible = true;
            }
        }
    }
}
