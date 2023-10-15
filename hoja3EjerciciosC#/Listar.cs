using System;
using System.Windows.Forms;

namespace hoja3EjerciciosC_
{
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
        }

        private void imgVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void cargarUsuarios()
        {
            foreach (Altas.Alumno alumno in Altas.alumnos)
            {
                lblUsuarios.Text += $"\n Id: {alumno.idAlumno} Nombre: {alumno.nombre} " +
                    $"Apellido: {alumno.apellido} Telefono: {alumno.telefono} " +
                    $"Email: {alumno.email} Curso: {alumno.curso}";
            }
        }

    }
}
