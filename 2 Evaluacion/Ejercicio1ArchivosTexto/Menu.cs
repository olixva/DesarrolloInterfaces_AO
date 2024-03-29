﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Ejercicio1ArchivosTexto
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //Altas 

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpAltas.Visible = true;
            grpConsulta.Visible = false;
            grpGuardar.Visible = false;
            grpGuardarInicial.Visible = false;
            grpBorrar.Visible = false;
        }

        //Limpiar campos altas
        private void LimpiarAltas()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int id = 0;
            string nombre = "";
            int telefono = 0;

            bool correcto = true;

            //Comprobamos los campos

            //Comprobamos que el ID sea un numero
            if (Int32.TryParse(txtID.Text, out int idNumerico))
            {
                id = idNumerico;
                errorProvider.SetError(txtID, "");
            }
            else
            {
                errorProvider.SetError(txtID, "El ID debe ser un numero");
                correcto = false;
            }

            //Comprobamos que el nombre no este vacio
            if (txtNombre.Text.Length > 0)
            {
                nombre = txtNombre.Text;
                errorProvider.SetError(txtNombre, "");
            }
            else
            {
                errorProvider.SetError(txtNombre, "El nombre no puede estar vacio");
                correcto = false;
            }

            //Comprobamos que el telefono sea un numero
            if (Int32.TryParse(txtTelefono.Text, out int telefonoNumerico))
            {
                telefono = telefonoNumerico;
                errorProvider.SetError(txtTelefono, "");
            }
            else
            {
                errorProvider.SetError(txtTelefono, "El telefono debe ser un numero");
                correcto = false;
            }

            //Si todo es correcto, creamos el contacto
            if (correcto)
            {
                Contacto c = new Contacto(id, nombre, telefono);
                MessageBox.Show("Contacto creado correctamente");
                LimpiarAltas();
            }
        }

        //Consultas
        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpAltas.Visible = false;
            grpConsulta.Visible = true;
            grpGuardar.Visible = false;
            grpGuardarInicial.Visible = false;
            grpBorrar.Visible = false;
        }

        //Limpiar campos consultas
        private void LimpiarConsultas()
        {
            txtNombreConsulta.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreConsulta.Text;

            MessageBox.Show(Contacto.MostrarTelefono(nombre));
            LimpiarConsultas();
        }

        //Guardar/Leer

        private void guardarAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpAltas.Visible = false;
            grpConsulta.Visible = false;
            grpGuardar.Visible = true;
            grpGuardarInicial.Visible = false;
            grpBorrar.Visible = false;

            MostrarAgenda();
        }

        private void MostrarAgenda()
        {
            txtBoxGuardar.Clear();
            foreach (Contacto c in Contacto.contactos)
            {
                txtBoxGuardar.Text += c.ToString();
            }
        }

        //Botones guardar/leer
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        //Guardar

        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            txtBoxGuardar.Text = File.ReadAllText(openFileDialog.FileName);
        }

        //Leer
        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            File.WriteAllText(saveFileDialog.FileName, txtBoxGuardar.Text);
        }

        //Guardar/Leer Inicial
        private void guardarAgendaPorInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpAltas.Visible = false;
            grpConsulta.Visible = false;
            grpGuardar.Visible = false;
            grpBorrar.Visible = false;
            grpGuardarInicial.Visible = true;
        }

        //Controlar que solo se introduzca una unica letra
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es una letra
            if (char.IsLetter(e.KeyChar))
            {
                // Asegura que solo se permita una letra
                txtInicial.Text = e.KeyChar.ToString();
            }
            e.Handled = true; // Indica que hemos manejado el evento y no se propaga más

        }

        //Botones guardar/leer
        private void btnGuardarInicial_Click(object sender, EventArgs e)
        {
            if (txtInicial.Text.Length == 0)
            {
                MessageBox.Show("Introduce una letra");
                return;
            }
            saveFileDialogInicial.ShowDialog();
        }

        private void btnAbrirInicial_Click(object sender, EventArgs e)
        {
            openFileDialogInicial.ShowDialog();
        }

        //Guardar
        private void saveFileDialogInicial_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            StreamWriter sw = new StreamWriter(saveFileDialogInicial.FileName);
            foreach (Contacto c in Contacto.MostrarContactosInicial(txtInicial.Text[0]))
            {
                sw.WriteLine(c.ToString());
            }
            sw.Close();
        }

        //Leer
        private void openFileDialogInicial_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            txtBoxGuardarInicial.Text = File.ReadAllText(openFileDialogInicial.FileName);
        }

        //Mostrar contactos por inicial al escribir
        private void txtInicial_TextChanged(object sender, EventArgs e)
        {
            string texto = "";
            foreach (Contacto c in Contacto.MostrarContactosInicial(txtInicial.Text[0]))
            {
                texto += c.ToString();
            }

            txtBoxGuardarInicial.Text = texto;
        }

        //Borrar
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpAltas.Visible = false;
            grpConsulta.Visible = false;
            grpGuardar.Visible = false;
            grpGuardarInicial.Visible = false;
            grpBorrar.Visible = true;

            txtNombreBorrar.Text = "";
            cargarContactos();
        }

        //Mostrar contactos al escribir
        private void txtNombreBorrar_TextChanged(object sender, EventArgs e)
        {
            listBoxBorrar.Items.Clear();
            foreach (Contacto c in Contacto.MostrarContactosNombre(txtNombreBorrar.Text))
            {
                listBoxBorrar.Items.Add(c);
            }
        }

        //Metodo que borra los contactos seleccionados y actualiza la lista
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxBorrar.SelectedItems.Count; i++)
            {
                Contacto.EliminarContacto((Contacto)listBoxBorrar.SelectedItems[i]);
            }

            txtNombreBorrar.Text = "";
            listBoxBorrar.Items.Clear();
            cargarContactos();
        }

        //Metodo que carga los contactos en el listbox
        private void cargarContactos()
        {
            listBoxBorrar.Items.Clear();

            foreach (Contacto c in Contacto.contactos)
            {
                listBoxBorrar.Items.Add(c);
            }
        }
    }
}
