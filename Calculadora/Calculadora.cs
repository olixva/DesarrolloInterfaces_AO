using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {

        private bool encendida = false;

        private bool coma = false;
        private bool positivo = true;

        static Double? resultadoAnterior = null;
        static Operacion hacer = Operacion.NADA;

        public Calculadora()
        {
            InitializeComponent();
        }

        //Encender o apagar
        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (encendida)
            {
                btnOnOff.Text = "On";

            }
            else
            {
                btnOnOff.Text = "Off";
            }

            encendida = !encendida;

            btn0.Enabled = encendida;
            btn1.Enabled = encendida;
            btn2.Enabled = encendida;
            btn3.Enabled = encendida;
            btn4.Enabled = encendida;
            btn5.Enabled = encendida;
            btn6.Enabled = encendida;
            btn7.Enabled = encendida;
            btn8.Enabled = encendida;
            btn9.Enabled = encendida;
            btnC.Enabled = encendida;
            btnComa.Enabled = encendida;
            btnDiv.Enabled = encendida;
            btnIgual.Enabled = encendida;
            btnMas.Enabled = encendida;
            btnMenos.Enabled = encendida;
            btnMulti.Enabled = encendida;
            btnPosNeg.Enabled = encendida;

            txtNumeros.Text = "0";
            resultadoAnterior = null;
            coma = false;
            positivo = true;
        }

        //Borrar 
        private void btnC_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = "0";
            resultadoAnterior = null;
            coma = false;
            positivo = true;
        }

        //Poner positivo o negativo
        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            if (positivo)
            {
                txtNumeros.Text = "-" + txtNumeros.Text;
                positivo = false;
            }
            else
            {
                txtNumeros.Text = txtNumeros.Text.Substring(1);
                positivo = true;
            }
        }

        //Pulsar cualquier numero
        private void btn_Click(object sender, EventArgs e)
        {
            PonerNumero(((Button)sender).Text);
        }

        private void PonerNumero(String numero)
        {
            if (txtNumeros.Text == "0")
            {
                txtNumeros.Text = numero;
            }
            else if (hacer == Operacion.NADA)
            {
                txtNumeros.Text += numero;
            }
            else
            {
                Operar(Double.Parse(txtNumeros.Text));
            }

        }

        //Pulsar la coma

        private void btnComa_Click(object sender, EventArgs e)
        {
            if (!coma)
            {
                txtNumeros.Text += ",";
                coma = true;
            }
        }

        //Operaciones

        //Suma
        private void btnMas_Click(object sender, EventArgs e)
        {
            hacer = Operacion.SUMA;
        }

        //Resta
        private void btnMenos_Click(object sender, EventArgs e)
        {
            hacer = Operacion.RESTA;
        }

        //Multiplicacion
        private void btnMulti_Click(object sender, EventArgs e)
        {
            hacer = Operacion.MULTIPLICACION;
        }

        //Division
        private void btnDiv_Click(object sender, EventArgs e)
        {
            hacer = Operacion.DIVISION;
        }

        //Igual
        private void btnIgual_Click(object sender, EventArgs e)
        {
        }

        //Metodo que hace las operaciones
        private void Operar(Double numero)
        {
            switch (hacer)
            {

                case Operacion.SUMA:
                    resultadoAnterior = resultadoAnterior + numero;
                    hacer = Operacion.NADA;
                    break;
                case Operacion.RESTA:
                    resultadoAnterior = resultadoAnterior - numero;
                    hacer = Operacion.NADA;
                    break;
                case Operacion.MULTIPLICACION:
                    resultadoAnterior = resultadoAnterior * numero;
                    hacer = Operacion.NADA;
                    break;
                case Operacion.DIVISION:
                    resultadoAnterior = resultadoAnterior / numero;
                    hacer = Operacion.NADA;
                    break;
                case Operacion.IGUAL:

                    break;
            }
        }
    }
}
