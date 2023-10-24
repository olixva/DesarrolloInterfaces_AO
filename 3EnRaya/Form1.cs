using System;
using System.Windows.Forms;

namespace _3EnRaya
{
    public partial class Juego : Form
    {
        private static char[,] tablero = new char[3, 3];

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
            if (PonerFicha((Button)sender, 0, 0) && !ComprobarLleno())
            {
                if (comprobarGanador(jugador1))
                {
                    lblUsuario.Text = "HA GANADO JUGADOR 1";
                    tablePanelTablero.Enabled = false;
                }
                else if (comprobarGanador(jugador2))
                {
                    lblUsuario.Text = "HA GANADO JUGADOR 2";
                    tablePanelTablero.Enabled = false;
                }
            }
            else if (ComprobarLleno())
            {
                lblUsuario.Text = "EMPATE :)";
            }
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            if (PonerFicha((Button)sender, 0, 1) && !ComprobarLleno())
            {
                if (comprobarGanador(jugador1))
                {
                    lblUsuario.Text = "HA GANADO JUGADOR 1";
                    tablePanelTablero.Enabled = false;
                }
                else if (comprobarGanador(jugador2))
                {
                    lblUsuario.Text = "HA GANADO JUGADOR 2";
                    tablePanelTablero.Enabled = false;
                }
            }
            else if (ComprobarLleno())
            {
                lblUsuario.Text = "EMPATE :)";
            }
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            if (PonerFicha((Button)sender, 0, 2) && !ComprobarLleno())
            {
                if (comprobarGanador(jugador1))
                {
                    lblUsuario.Text = "HA GANADO JUGADOR 1";
                    tablePanelTablero.Enabled = false;
                }
                else if (comprobarGanador(jugador2))
                {
                    lblUsuario.Text = "HA GANADO JUGADOR 2";
                    tablePanelTablero.Enabled = false;
                }
            }
            else if (ComprobarLleno())
            {
                lblUsuario.Text = "EMPATE :)";
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (PonerFicha((Button)sender, 1, 0) && !ComprobarLleno())
            {
                if (comprobarGanador(jugador1))
                {
                    lblUsuario.Text = "HA GANADO JUGADOR 1";
                    tablePanelTablero.Enabled = false;
                }
                else if (comprobarGanador(jugador2))
                {
                    lblUsuario.Text = "HA GANADO JUGADOR 2";
                    tablePanelTablero.Enabled = false;
                }
            }
            else if (ComprobarLleno())
            {
                lblUsuario.Text = "EMPATE :)";
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (PonerFicha((Button)sender, 1, 1) && !ComprobarLleno())
            {
                if (comprobarGanador(jugador1))
                {
                    lblUsuario.Text = "HA GANADO JUGADOR 1";
                    tablePanelTablero.Enabled = false;
                }
                else if (comprobarGanador(jugador2))
                {
                    lblUsuario.Text = "HA GANADO JUGADOR 2";
                    tablePanelTablero.Enabled = false;
                }
            }
            else if (ComprobarLleno())
            {
                lblUsuario.Text = "EMPATE :)";
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (PonerFicha((Button)sender, 1, 2) && !ComprobarLleno())
            {
                if (comprobarGanador(jugador1))
                {
                    lblUsuario.Text = "HA GANADO JUGADOR 1";
                    tablePanelTablero.Enabled = false;
                }
                else if (comprobarGanador(jugador2))
                {
                    lblUsuario.Text = "HA GANADO JUGADOR 2";
                    tablePanelTablero.Enabled = false;
                }
            }
            else if (ComprobarLleno())
            {
                lblUsuario.Text = "EMPATE :)";
            }
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            if (PonerFicha((Button)sender, 2, 0) && !ComprobarLleno())
            {
                if (comprobarGanador(jugador1))
                {
                    lblUsuario.Text = "HA GANADO JUGADOR 1";
                    tablePanelTablero.Enabled = false;
                }
                else if (comprobarGanador(jugador2))
                {
                    lblUsuario.Text = "HA GANADO JUGADOR 2";
                    tablePanelTablero.Enabled = false;
                }
            }
            else if (ComprobarLleno())
            {
                lblUsuario.Text = "EMPATE :)";
            }
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (PonerFicha((Button)sender, 2, 1) && !ComprobarLleno())
            {
                if (comprobarGanador(jugador1))
                {
                    lblUsuario.Text = "HA GANADO JUGADOR 1";
                    tablePanelTablero.Enabled = false;
                }
                else if (comprobarGanador(jugador2))
                {
                    lblUsuario.Text = "HA GANADO JUGADOR 2";
                    tablePanelTablero.Enabled = false;
                }
            }
            else if (ComprobarLleno())
            {
                lblUsuario.Text = "EMPATE :)";
            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (PonerFicha((Button)sender, 2, 2) && !ComprobarLleno())
            {
                if (comprobarGanador(jugador1))
                {
                    lblUsuario.Text = "HA GANADO JUGADOR 1";
                    tablePanelTablero.Enabled = false;
                }
                else if (comprobarGanador(jugador2))
                {
                    lblUsuario.Text = "HA GANADO JUGADOR 2";
                    tablePanelTablero.Enabled = false;
                }
            }
            else if (ComprobarLleno())
            {
                lblUsuario.Text = "EMPATE :)";
            }
        }

        private bool PonerFicha(Button btn, int x, int y)
        {
            if (btn.Text == String.Empty)
            {
                if (actual == Jugador.jugador1)
                {
                    btn.Text = jugador1.ToString();
                    tablero[x, y] = jugador1;
                    actual = Jugador.jugador2;

                    lblUsuario.Text = $"Juega usuario 2";
                }
                else
                {
                    btn.Text = jugador2.ToString();
                    tablero[x, y] = jugador2;
                    actual = Jugador.jugador1;

                    lblUsuario.Text = $"Juega usuario 1";
                }
                return true;
            }
            return false;
        }

        public bool ComprobarLleno()
        {
            for (int fila = 0; fila < tablero.GetLength(0); fila++)
            {
                for (int columna = 0; columna < tablero.GetLength(1); columna++)
                {
                    if (tablero[fila, columna] == '\0')
                    {
                        return false;
                    }
                }
            }

            // Si llegamos hasta aquí, el tablero esta lleno
            return true;
        }
        private bool comprobarGanador(char jugador)
        {
            // Comprobar filas
            for (int fila = 0; fila < 3; fila++)
            {
                if (tablero[fila, 0] == jugador && tablero[fila, 1] == jugador && tablero[fila, 2] == jugador)
                {
                    return true;
                }
            }

            // Comprobar columnas
            for (int columna = 0; columna < 3; columna++)
            {
                if (tablero[0, columna] == jugador && tablero[1, columna] == jugador && tablero[2, columna] == jugador)
                {
                    return true;
                }
            }

            // Comprobar diagonal de izquierda a derecha
            if (tablero[0, 0] == jugador && tablero[1, 1] == jugador && tablero[2, 2] == jugador)
            {
                return true;
            }

            // Comprobar diagonal de derecha a izquierda
            if (tablero[0, 2] == jugador && tablero[1, 1] == jugador && tablero[2, 0] == jugador)
            {
                return true;
            }

            return false; // Nadie ha ganado
        }
    }
}
