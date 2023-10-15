using System;
using System.Windows.Forms;

namespace hoja3EjerciciosC_
{
    public partial class Altas : Form
    {
        public static Alumno[] alumnos = new Alumno[3];
        public static int alumnosCreados = 0;
        public Altas()
        {
            InitializeComponent();
        }

        public struct Alumno
        {
            public int idAlumno;
            public String nombre;
            public String apellido;
            public long telefono;
            public String email;
            public String curso;

            public Alumno(string nombre, string apellido, long telefono, string email, string curso) : this()
            {
                this.idAlumno = alumnosCreados;
                alumnos[alumnosCreados] = this;

                this.nombre = nombre;
                this.apellido = apellido;
                this.telefono = telefono;
                this.email = email;
                this.curso = curso;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String email = txtEmail.Text;
            String curso = txtCurso.Text;

            if (long.TryParse(txtTelefono.Text, out long telefono))
            {
                alumnos[alumnosCreados] = new Alumno(nombre, apellido, telefono, email, curso);

                lblAluCreados.Text = $"Alumnos creados {++alumnosCreados} / 3";
                lblNotifi.Text = "Alumno creado correctamente.";
                lblNotifi.ForeColor = System.Drawing.Color.Green;
                lblAluCreados.Visible = true;
                lblNotifi.Visible = true;
            }
            else
            {
                lblNotifi.ForeColor = System.Drawing.Color.Red;
                lblNotifi.Text = "Telefono en formato no valido";
                lblNotifi.Visible = true;
                errorAlta.SetError(txtTelefono, "Telefono no valido");
            }

            if (alumnosCreados == 3)
            {
                btnCrear.Enabled = false;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
