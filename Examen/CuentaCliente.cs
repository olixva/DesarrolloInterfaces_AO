using System.Windows.Forms;

namespace Examen
{
    public partial class CuentaCliente : Form
    {
        private Cliente clienteActual;
        private Menu menuPadre;
        //Constructor con el cliente que tiene la sesion iniciada
        public CuentaCliente(Cliente cliente, Menu menu)
        {
            InitializeComponent();
            clienteActual = cliente;
            menuPadre = menu;
            this.Text = "Cuenta de " + clienteActual.NombreCli;
        }

        //Salir de la cuenta
        private void salirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            menuPadre.Show();
            this.Close();
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            grpCambiarClave.Visible = true;
        }

        //Cambiar la contraseña

        //Mostrar o ocultar contraseñas
        private void checkClaves_CheckedChanged(object sender, System.EventArgs e)
        {
            txtPassActual.UseSystemPasswordChar = !checkClaves.Checked;
            txtPassNueva1.UseSystemPasswordChar = !checkClaves.Checked;
            txtPassNueva2.UseSystemPasswordChar = !checkClaves.Checked;
        }

        //Limpiar los campos
        private void LimpiarCampos()
        {
            txtPassActual.Text = "";
            txtPassNueva1.Text = "";
            txtPassNueva2.Text = "";
            btnCambiar.Enabled = false;
            txtPassActual.Enabled = true;
            btnValidarActual.Visible = true;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            LimpiarCampos();
        }


        //Validar la contraseña actual
        private void btnValidarActual_Click(object sender, System.EventArgs e)
        {
            //Pasamos la clave a int para poder compararla controlando errores
            if (!int.TryParse(txtPassActual.Text, out int claveActual))
            {
                MessageBox.Show("La contraseña no esta en el formato adecuado");
                return;
            }

            //Si la clave es correcta, mostramos los campos para cambiar la contraseña
            if (claveActual == clienteActual.ClaveCli)
            {
                btnCambiar.Visible = true;
                btnValidarActual.Visible = false;

                txtPassActual.Enabled = false;
                txtPassNueva1.Enabled = true;
                txtPassNueva2.Enabled = true;
                btnCambiar.Enabled = true;
            }
            else
            {
                MessageBox.Show("La contraseña actual no es correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassActual.Text = "";
                txtPassActual.Focus();
            }
        }

        //Cambiar la contraseña del cliente
        private void btnCambiar_Click(object sender, System.EventArgs e)
        {
            //Pasamos las claves a int para poder compararlas controlando errores
            if (!int.TryParse(txtPassNueva1.Text, out int claveNueva1) || !int.TryParse(txtPassNueva2.Text, out int claveNueva2))
            {
                MessageBox.Show("La contraseña no esta en el formato adecuado");
                return;
            }

            //Si las claves son iguales, cambiamos la clave del cliente
            if (claveNueva1 == claveNueva2)
            {
                clienteActual.ClaveCli = claveNueva1;
                MessageBox.Show("La contraseña se ha cambiado correctamente", "Contraseña cambiada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
