using System;
using System.Windows.Forms;

namespace hoja3EjerciciosC_
{
    public partial class Login : Form
    {
        private static String[,] usuarios = new string[4, 2];
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
            for (int i = 0; i < usuarios.GetLength(0); i++)
            {
                if (txtUser.Text == usuarios[i, 0])
                {
                    if (txtPass.Text == usuarios[i, 1])
                    {
                        lblError.Visible = false;
                        errorLogin.SetError(txtPass, "");
                        errorLogin.SetError(txtUser, "");
                        (new Menu()).Show();
                        this.Hide();

                    }
                    else
                    {
                        errorLogin.SetError(txtPass, "Contraseña Incorrecta");
                        errorLogin.SetError(txtUser, "");
                        lblError.Visible = true;
                    }
                    break;
                }
                errorLogin.SetError(txtUser, "Usuario no existe");
                errorLogin.SetError(txtPass, "");
                lblError.Visible = true;
            }
        }
    }
}
