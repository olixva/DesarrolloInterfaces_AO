using CompraInteractiva.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CompraInteractiva
{
    public partial class Form1 : Form
    {
        private static Dictionary<string, Image> imagenes;
        private int total = 0;
        public Form1()
        {
            InitializeComponent();
            InicializarControles();
            InicilizarImagenes();
        }

        private void InicilizarImagenes()
        {
            //Creamos un clave valor con el nombre y la foto
            imagenes = new Dictionary<string, Image>
            {
                { radioPc.Name, Resources.pc },
                { radioMacintosh.Name, Resources.macintosh },
                { radioPortatil.Name, Resources.portatil },
                { checkContestador.Name, Resources.contestador },
                { checkCalculadora.Name, Resources.calculadora },
                { checkFotoCopiadora.Name, Resources.fotocopiadora },
                { listBoxPerifericos.Items[0].ToString(), Resources.discoDuro },
                { listBoxPerifericos.Items[1].ToString(), Resources.impresora },
                { listBoxPerifericos.Items[2].ToString(), Resources.antena },
                { cmboBoxMetodoPago.Items[0].ToString(), Resources.tarjeta },
                { cmboBoxMetodoPago.Items[1].ToString(), Resources.paypal },
                { cmboBoxMetodoPago.Items[2].ToString(), Resources.bizum }
            };

        }

        private void InicializarControles()
        {
            //Iniciamos los valores de los perifericos 
            listBoxPerifericos.Items.Add("Disco duro adicional (75$)");
            listBoxPerifericos.Items.Add("Impresora (90$)");
            listBoxPerifericos.Items.Add("Antena (50$)");

            //Iniciamos los valores de los metodos de pago
            cmboBoxMetodoPago.Items.Add("Tarjeta");
            cmboBoxMetodoPago.Items.Add("PayPal");
            cmboBoxMetodoPago.Items.Add("Bizum");
        }

        //Cargamos las imagenes de el equipo al dar click
        private void radioPc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPc.Checked)
            {
                pictureEquipo.Image = imagenes[radioPc.Name];
                total += 700;
            }
            else
            {
                total -= 700;
            }
        }

        private void radioMacintosh_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMacintosh.Checked)
            {
                pictureEquipo.Image = imagenes[radioMacintosh.Name];
                total += 100;
            }
            else
            {
                total -= 1000;
            }
        }

        private void radioPortatil_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPortatil.Checked)
            {
                pictureEquipo.Image = imagenes[radioPortatil.Name];
                total += 500;
            }
            else
            {
                total -= 500;
            }
        }

        //Cargamos imagenes de los equipos de oficina
        private void checkContestador_CheckedChanged(object sender, EventArgs e)
        {
            if (checkContestador.Checked)
            {
                pictureContestador.Image = imagenes[checkContestador.Name];
            }
            else
            {
                pictureContestador.Image = null;
            }
        }

        private void checkCalculadora_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCalculadora.Checked)
            {
                pictureCalculadora.Image = imagenes[checkCalculadora.Name];
            }
            else
            {
                pictureCalculadora.Image = null;
            }
        }

        private void checkFotoCopiadora_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFotoCopiadora.Checked)
            {
                pictureFotoCopiadora.Image = imagenes[checkFotoCopiadora.Name];
            }
            else
            {
                pictureFotoCopiadora.Image = null;
            }
        }
    }
}
