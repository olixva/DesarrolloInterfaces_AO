using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CompraInteractiva
{
    public partial class Presupuesto : Form
    {
        public Presupuesto(List<String> pedido, String metodoPago, int total)
        {
            InitializeComponent();

            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox.Text += "------------------------------------------\n";
            richTextBox.Text += "Factura de Compra           \n";
            richTextBox.Text += "------------------------------------------\n\n";

            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox.Text += $"{PadRight("Descripción", 40)} {PadLeft("Precio", 10)}\n";
            richTextBox.Text += "------------------------------------------\n";

            foreach (var item in pedido)
            {
                if (item != null)
                {
                    string[] parts = item.Split(new[] { " (" }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length == 2)
                    {
                        string nombre = parts[0];
                        string precio = parts[1].Trim(')');
                        richTextBox.Text += $"{PadRight(nombre, 40)} {PadLeft(precio, 10)}\n";
                    }
                    else
                    {
                        richTextBox.Text += $"{item}\n";
                    }
                }

            }

            richTextBox.Text += "------------------------------------------\n";
            richTextBox.Text += $"{PadRight("Subtotal", 40)} {PadLeft($"{total * 0.79:0.00}$", 10)}\n";
            richTextBox.Text += $"{PadRight("IVA (21%)", 40)} {PadLeft($"{total * 0.21:0.00}$", 10)}\n";
            richTextBox.Text += $"{PadRight("Total", 40)} {PadLeft($"{total:0.00}$", 10)}\n";
            richTextBox.Text += "------------------------------------------\n\n";

            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox.Text += $"Método de pago: {metodoPago}\n";
        }

        // Metodo para centrar el texto
        private string PadRight(string str, int length)
        {
            return str.PadRight(length - (length - str.Length) / 2);
        }

        private string PadLeft(string str, int length)
        {
            return str.PadLeft(length - (length - str.Length) / 2);
        }

        // Botones de guardar y abrir
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            File.WriteAllText(saveFileDialog.FileName, richTextBox.Text);
        }

        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            richTextBox.Text = File.ReadAllText(openFileDialog.FileName);
        }
    }
}
