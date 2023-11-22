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

        private String[] equiposElegidos = new string[3];
        private int precioPeriferico;
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
                total += 1000;
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
                equiposElegidos[0] = checkContestador.Text;
                total += 50;

            }
            else
            {
                pictureContestador.Image = null;
                equiposElegidos[0] = null;
                total -= 50;
            }
        }

        private void checkCalculadora_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCalculadora.Checked)
            {
                pictureCalculadora.Image = imagenes[checkCalculadora.Name];
                equiposElegidos[1] = checkCalculadora.Text;
                total += 20;
            }
            else
            {
                pictureCalculadora.Image = null;
                equiposElegidos[1] = null;
                total -= 20;
            }
        }

        private void checkFotoCopiadora_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFotoCopiadora.Checked)
            {
                pictureFotoCopiadora.Image = imagenes[checkFotoCopiadora.Name];
                equiposElegidos[2] = checkFotoCopiadora.Text;
                total += 100;
            }
            else
            {
                pictureFotoCopiadora.Image = null;
                equiposElegidos[2] = null;
                total -= 100;
            }
        }

        //Cargamos imagenes de perifericos
        private void listBoxPerifericos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBoxPerifericos.SelectedIndex)
            {
                case 0:
                    picturePeriferico.Image = imagenes[listBoxPerifericos.Items[0].ToString()];
                    precioPeriferico = 75;
                    break;
                case 1:
                    picturePeriferico.Image = imagenes[listBoxPerifericos.Items[1].ToString()];
                    precioPeriferico = 90;
                    break;
                case 2:
                    picturePeriferico.Image = imagenes[listBoxPerifericos.Items[2].ToString()];
                    precioPeriferico = 50;
                    break;
            }
        }

        //Cargamos imagenes de metodo de pago
        private void cmboBoxMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmboBoxMetodoPago.SelectedIndex)
            {
                case 0:
                    picturePago.Image = imagenes[cmboBoxMetodoPago.Items[0].ToString()];
                    break;
                case 1:
                    picturePago.Image = imagenes[cmboBoxMetodoPago.Items[1].ToString()];
                    break;
                case 2:
                    picturePago.Image = imagenes[cmboBoxMetodoPago.Items[2].ToString()];
                    break;
            }
        }

        //Boton de salir
        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Presupuestos
        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            if (cmboBoxMetodoPago.SelectedIndex == -1)
            {
                errorProvider.SetError(cmboBoxMetodoPago, "Seleccione un metodo de pago");
            }
            else
            {
                mostrarPresupuesto();
                errorProvider.SetError(cmboBoxMetodoPago, "");
            }
        }

        private void mostrarPresupuesto()
        {
            MessageBox.Show((total + precioPeriferico).ToString());
        }
    }
}
