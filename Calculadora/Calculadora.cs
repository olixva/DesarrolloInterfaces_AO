using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {

        private bool encendida = false;

        private bool coma = false;
        private bool positivo = true;
        private bool nuevaOperacion = false;
        private bool primeraOperacion = true;


        private Double? resultadoAnterior = null;
        private Double? operando = null;
        private Operacion hacer = Operacion.NADA;


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

            limpiar();
        }

        //Borrar 
        private void btnC_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtNumeros.Text = "0";
            resultadoAnterior = null;

            coma = false;
            positivo = true;

            nuevaOperacion = false;
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
            else if (nuevaOperacion)
            {
                txtNumeros.Text = numero;
                nuevaOperacion = false;
            }
            else
            {
                txtNumeros.Text += numero;
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

        private void btnOperacion_Click(object sender, EventArgs e)
        {

            // Establece la nueva operación y muestra el resultado de la anterior
            if (sender == btnMas)
            {
                Operar(Double.Parse(txtNumeros.Text));
                hacer = Operacion.SUMA;
                nuevaOperacion = true;

                mostrarResultado();

            }


            else if (sender == btnMenos)
            {
                Operar(Double.Parse(txtNumeros.Text));
                hacer = Operacion.RESTA;
                nuevaOperacion = true;

                mostrarResultado();
            }

            else if (sender == btnMulti)
            {
                Operar(Double.Parse(txtNumeros.Text));
                hacer = Operacion.MULTIPLICACION;
                nuevaOperacion = true;

                mostrarResultado();
            }

            else if (sender == btnDiv)
            {
                Operar(Double.Parse(txtNumeros.Text));
                hacer = Operacion.DIVISION;
                nuevaOperacion = true;

                mostrarResultado();
            }

            else if (sender == btnIgual)
            {
                nuevaOperacion = true;

                mostrarResultado();
            }
        }

        //Mostrar resultado
        private void mostrarResultado()
        {
            if (!primeraOperacion)
            {
                txtNumeros.Text = resultadoAnterior.ToString();
            }
        }


        //Metodo que hace las operaciones
        private void Operar(Double numero)
        {
            switch (hacer)
            {
                case Operacion.SUMA:

                    operando = double.Parse(txtNumeros.Text);
                    resultadoAnterior = resultadoAnterior + operando;

                    break;

                case Operacion.RESTA:
                    operando = double.Parse(txtNumeros.Text);
                    resultadoAnterior = resultadoAnterior - operando;
                    break;
                case Operacion.MULTIPLICACION:
                    operando = double.Parse(txtNumeros.Text);
                    resultadoAnterior = resultadoAnterior * operando;
                    break;
                case Operacion.DIVISION:
                    operando = double.Parse(txtNumeros.Text);
                    resultadoAnterior = resultadoAnterior / operando;
                    break;

                case Operacion.IGUAL:
                    break;

                default:

                    if (primeraOperacion)
                    {
                        resultadoAnterior = double.Parse(txtNumeros.Text);
                        primeraOperacion = false;
                    }

                    break;
            }
        }
    }
}