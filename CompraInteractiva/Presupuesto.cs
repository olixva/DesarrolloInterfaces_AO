using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CompraInteractiva
{
    public partial class Presupuesto : Form
    {
        public Presupuesto(List<String> pedido, String metodoPago, int total)
        {
            InitializeComponent();
            foreach (var item in pedido)
            {
                richTextBox.Text += item + "\n";
            }
            richTextBox.Text += "\n\n\nTotal = " + total + "$";
            richTextBox.Text += "\nIVA (21%) = " + (total * 0.21) + "$";
            richTextBox.Text += "\n\nMetodo de pago = " + metodoPago;
        }
    }
}
