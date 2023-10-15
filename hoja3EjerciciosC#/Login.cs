using System;
using System.Threading;
using System.Windows.Forms;

namespace hoja3EjerciciosC_
{
    public partial class Login : Form
    {
        private static String[,] usuarios = new string[4, 2];
        private int intentos = 3;
        public Login()
        {
            InitializeComponent();
            for (int i = 0; i < usuarios.GetLength(0) - 1; i++)
            {
                usuarios[i, 0] = $"user{i + 1}";
                usuarios[i, 1] = $"pass{i + 1}";
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            bool usuarioValido = false;

            for (int i = 0; i < usuarios.GetLength(0); i++)
            {
                if (txtUser.Text == usuarios[i, 0])
                {
                    usuarioValido = true;
                    if (txtPass.Text == usuarios[i, 1])
                    {
                        lblIntentos.Visible = false;
                        errorLogin.SetError(txtPass, "");
                        errorLogin.SetError(txtUser, "");
                        (new Menu()).Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        errorLogin.SetError(txtPass, "Contraseña Incorrecta");
                        errorLogin.SetError(txtUser, "");
                        lblIntentos.Text = $"Te quedan {--intentos} intento/s.";
                        lblIntentos.Visible = true;
                    }
                    break;
                }
            }

            if (!usuarioValido)
            {
                errorLogin.SetError(txtUser, "Usuario no existe");
                errorLogin.SetError(txtPass, "");
                lblIntentos.Text = $"Te quedan {--intentos} intento/s.";
                lblIntentos.Visible = true;
            }

            if (intentos == 0)
            {
                lblIntentos.Text = "Has agotado todos los intentos";
                Application.DoEvents();
                Thread.Sleep(3000);
                Application.Exit();
            }
        }
    }
}
