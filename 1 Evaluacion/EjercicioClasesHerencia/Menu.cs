﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EjercicioClasesHerencia
{
    public partial class Menu : Form
    {

        private List<Cuenta> cuentasList = new List<Cuenta>();
        public Menu()
        {
            InitializeComponent();
        }

        //Altas
        private void altaDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpBoxAltas.Visible = true;

            grpBoxConsultas.Visible = false;
            grpOperaciones.Visible = false;
            grpTrasferencias.Visible = false;
        }

        private void radioBtnPersonal_CheckedChanged(object sender, EventArgs e)
        {
            txtInteres.Enabled = radioBtnEmpresa.Checked;
            txtMesesCredito.Enabled = radioBtnEmpresa.Checked;
            txtTopeCredito.Enabled = radioBtnEmpresa.Checked;

            txtInteres.Text = "";
            txtMesesCredito.Text = "";
            txtTopeCredito.Text = "";

            error.SetError(txtTopeCredito, "");
            error.SetError(txtMesesCredito, "");
            error.SetError(txtInteres, "");
        }

        private void radioBtnEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            txtInteres.Enabled = radioBtnEmpresa.Checked;
            txtMesesCredito.Enabled = radioBtnEmpresa.Checked;
            txtTopeCredito.Enabled = radioBtnEmpresa.Checked;
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            bool valida = true;

            String titular = txtTitular.Text;
            String dni = txtDni.Text;

            if (radioBtnPersonal.Checked == true) //Cuenta tipo personal
            {
                cuentasList.Add(new Cuenta(titular, dni));

                MessageBox.Show("Cuenta creada correctamente");
                txtNCuenta.Text = (Int32.Parse(txtNCuenta.Text) + 1).ToString();
            }
            else //Cuenta de empresa
            {
                if (!long.TryParse(txtInteres.Text, out long intereses))
                {
                    error.SetError(txtInteres, "Formato invalido");
                    valida = false;
                }
                if (!Int32.TryParse(txtMesesCredito.Text, out int mesesCredito))
                {
                    error.SetError(txtMesesCredito, "Formato invalido");
                    valida = false;
                }

                if (!Double.TryParse(txtTopeCredito.Text, out double topeCredito))
                {
                    error.SetError(txtTopeCredito, "Formato invalido");
                    valida = false;
                }

                if (valida) //Si los datos son validos lo creamos
                {
                    cuentasList.Add(new CuentaEmpresa(titular, dni, intereses, mesesCredito, topeCredito));
                    MessageBox.Show("Cuenta creada correctamente");
                    txtNCuenta.Text = (Int32.Parse(txtNCuenta.Text) + 1).ToString();

                    error.SetError(txtTopeCredito, "");
                    error.SetError(txtMesesCredito, "");
                    error.SetError(txtInteres, "");
                }
            }
        }

        //Consultas

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (radioNumero.Checked) //Buscamos por numero de cuenta
            {
                foreach (Cuenta cuenta in cuentasList)
                {
                    if (cuenta.NumeroCuenta.ToString() == txtNumeroBuscar.Text)
                    {
                        MessageBox.Show(cuenta.ToString());
                    }
                }
            }
            else //Buscamos por DNI
            {
                foreach (Cuenta cuenta in cuentasList)
                {
                    if (cuenta.Dni == txtDNIBuscar.Text)
                    {
                        MessageBox.Show(cuenta.ToString());
                    }
                }
            }
        }

        //Por numero de cuenta
        private void porNCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpBoxConsultas.Visible = true;

            grpBoxAltas.Visible = false;
            grpOperaciones.Visible = false;
            grpTrasferencias.Visible = false;

            radioNumero.Checked = true;
        }
        private void radioNumero_CheckedChanged(object sender, EventArgs e)
        {
            txtNumeroBuscar.Enabled = true;
            txtDNIBuscar.Enabled = false;
            txtDNIBuscar.Text = "";
        }

        //Por DNI
        private void porDNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpBoxConsultas.Visible = true;

            grpBoxAltas.Visible = false;
            grpOperaciones.Visible = false;
            grpTrasferencias.Visible = false;

            radioDNI.Checked = true;
        }

        private void radioDNI_CheckedChanged(object sender, EventArgs e)
        {
            txtDNIBuscar.Enabled = true;
            txtNumeroBuscar.Enabled = false;
            txtNumeroBuscar.Text = "";
        }

        //Operaciones
        private void btnIngresarSacar_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtImporte.Text, out double importe))
            {
                error.SetError(txtImporte, "Formato invalido");
                return;
            }

            bool encontrada = false;

            if (radioReintegro.Checked) //Reintegro
            {
                foreach (Cuenta cuenta in cuentasList)
                {
                    if (cuenta.NumeroCuenta.ToString().Equals(txtNumeroOpraciones.Text))
                    {
                        encontrada = true; //La cuenta existe
                        if (cuenta.Reintegro(importe))
                        {
                            MessageBox.Show("Reintegro realizado correctamente");
                            error.SetError(txtImporte, "");
                        }
                        else
                        {
                            MessageBox.Show("Reintegro no realizado, saldo insuficiente");
                        }
                    }
                }
            }
            else //Ingreso
            {
                foreach (Cuenta cuenta in cuentasList)
                {
                    if (cuenta.NumeroCuenta.ToString().Equals(txtNumeroOpraciones.Text))
                    {
                        encontrada = true;
                        if (cuenta.Ingreso(importe))
                        {
                            MessageBox.Show("Ingreso realizado correctamente");
                            error.SetError(txtImporte, "");
                        }
                        else
                        {
                            MessageBox.Show("El importe no puede ser negativo");
                        }
                    }
                }
            }

            if (!encontrada)
            {
                MessageBox.Show("La cuenta no existe");
            }
        }
        //Ingreso
        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpOperaciones.Visible = true;

            grpBoxAltas.Visible = false;
            grpBoxConsultas.Visible = false;
            grpTrasferencias.Visible = false;

            radioIngreso.Checked = true;
        }
        private void radioIngreso_CheckedChanged(object sender, EventArgs e)
        {
            btnIngresarSacar.Text = "Ingresar";
        }

        //Reintegro
        private void reintegroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpOperaciones.Visible = true;

            grpBoxAltas.Visible = false;
            grpBoxConsultas.Visible = false;
            grpTrasferencias.Visible = false;

            radioReintegro.Checked = true;
        }

        private void radioReintegro_CheckedChanged(object sender, EventArgs e)
        {
            btnIngresarSacar.Text = "Sacar";
        }

        //Trasferencias

        private void brnTrasferir_Click(object sender, EventArgs e)
        {
            //Comprobamos que ambas cuentas existan
            Cuenta cuentaOrigen = null;
            Cuenta cuentaDestino = null;

            foreach (Cuenta cuenta in cuentasList)
            {
                if (cuenta.NumeroCuenta.ToString().Equals(txtNOrigen.Text))
                {
                    cuentaOrigen = cuenta;
                }
                else if (cuenta.NumeroCuenta.ToString().Equals(txtNDestino.Text))
                {
                    cuentaDestino = cuenta;
                }
            }

            //Comprobamos que las cuentas existen
            if (cuentaDestino != null && cuentaOrigen != null)
            {
                //Comprobamos que el importe sea valido
                if (!Double.TryParse(txtImporteTrasf.Text, out double importe))
                {
                    error.SetError(txtImporteTrasf, "Formato invalido");
                    return;
                }

                error.SetError(txtImporteTrasf, "");

                //Comprobamos si se puede hacer la trasferencia
                if (cuentaOrigen.Trasferencia(cuentaDestino, importe))
                {
                    MessageBox.Show("Trasferencia realizada correctamente"); //Se hace la trasferencia
                }
                else
                {
                    MessageBox.Show("Trasferencia no realizada, saldo insuficiente"); //No se hace
                }
            }
            else //Alguna de las cuentas no existen
            {
                MessageBox.Show("Cuenta de Origen o de Destino no existe");
            }

        }
        private void entreCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpTrasferencias.Visible = true;

            grpBoxAltas.Visible = false;
            grpBoxConsultas.Visible = false;
            grpOperaciones.Visible = false;
        }

        //Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
