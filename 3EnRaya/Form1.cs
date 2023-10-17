using System;
using System.Windows.Forms;

namespace _3EnRaya
{
    public partial class Juego : Form
    {

        private static char jugador1 = 'X';
        private static char jugador2 = 'O';

        private static Jugador actual;
        private enum Jugador
        {
            jugador1,
            jugador2
        }
        public Juego()
        {
            InitializeComponent();
            actual = Jugador.jugador1;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            if (PonerFicha((Button)sender))
            {
                comprobarGanador();
            }

        }

        private void btn01_Click(object sender, EventArgs e)
        {
            ponerFicha((Button)sender);
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            ponerFicha((Button)sender);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            ponerFicha((Button)sender);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            ponerFicha((Button)sender);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            ponerFicha((Button)sender);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            ponerFicha((Button)sender);
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            PonerFicha((Button)sender);
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            PonerFicha((Button)sender);
        }

        private bool PonerFicha(Button btn)
        {
            if (btn.Text == String.Empty)
            {
                if (actual == Jugador.jugador1)
                {
                    btn.Text = jugador1.ToString();
                    actual = Jugador.jugador2;
                    lblUsuario.Text = $"Juega usuario 2";
                }
                else
                {
                    btn.Text = jugador2.ToString();
                    actual = Jugador.jugador1;
                    lblUsuario.Text = $"Juega usuario 1";
                }
                return true;
            }
            return false;
        }

        private void comprobarGanador()
        {

        }
    }
}
