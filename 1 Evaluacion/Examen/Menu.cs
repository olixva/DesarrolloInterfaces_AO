using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Examen
{
    public partial class Menu : Form
    {

        private static List<Cliente> clientes;
        private static int intentos;
        public Menu()
        {
            InitializeComponent();
            clientes = new List<Cliente>();
            intentos = 0;
        }

        //Opciones de menu

        //Cliente
        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpConsulta.Visible = false;
            grpCajero.Visible = false;
            grpBloq.Visible = false;
            LimpiarCamposAlta();
            grpAltas.Visible = true;
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpAltas.Visible = false;
            grpCajero.Visible = false;
            grpBloq.Visible = false;
            LimpiarCamposConsulta();
            grpConsulta.Visible = true;

        }

        //Cajero
        private void cajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpAltas.Visible = false;
            grpConsulta.Visible = false;
            grpBloq.Visible = false;
            LimpiarCamposCajero();
            grpCajero.Visible = true;
        }

        //Tarjeta 
        private void bloquearDesbloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpAltas.Visible = false;
            grpConsulta.Visible = false;
            grpCajero.Visible = false;
            LimpiarCamposBloqueo();
            grpBloq.Visible = true;
        }

        //Autor
        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Antonio Oliva Carceles 05/12/2023 ---> 2DAM ");
        }

        //Cerrar
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Altas cliente

        //Funcion que limpia los campos de texto del formulario alta
        private void LimpiarCamposAlta()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtClave.Text = "";
            txtSaldo.Text = "";
        }

        //Funcion que crea un cliente si los datos son correctos al pulsar el boton
        private void btnCrear_Click(object sender, EventArgs e)
        {
            String dni = "";
            String nombre = "";
            int clave = -1;
            double saldo = -1;

            //Comprobamos que los campos String no estan vacios
            if (ValidarString(txtDni))
            {
                dni = txtDni.Text;
            }

            if (ValidarString(txtNombre))
            {
                nombre = txtNombre.Text;
            }

            //Comprobamos que la contraseña es un numero y tiene 4 digitos

            clave = ValidarContrasena(txtClave);

            //Comprobamos que el saldo es un numero

            if (Double.TryParse(txtSaldo.Text, out double saldoAux))
            {
                saldo = saldoAux;
                errorProvider.SetError(txtSaldo, "");
            }
            else
            {
                errorProvider.SetError(txtSaldo, "El saldo debe ser numerico");
            }

            //Si todos los datos estan bien creamos el cliente
            if (dni != "" && nombre != "" && saldo != -1 && clave != -1)
            {
                clientes.Add(new Cliente(dni, nombre, clave, saldo));
                LimpiarCamposAlta();
                MessageBox.Show("Usuario creado correctamente");
            }
            else
            {
                MessageBox.Show("El usuario no se ha creado, comprueba los datos y prueba de nuevo");
            }
        }

        //Funcion que comprueba que el string no es null y no esta vacio
        private bool ValidarString(TextBox sender)
        {
            if (sender.Text != null && sender.Text != "")
            {
                errorProvider.SetError(sender, "");
                return true;
            }
            else
            {
                errorProvider.SetError(sender, "El campo no puede estar vacio");
                return false;
            }
        }

        //Funcion que comprueba que la contrasena es un numero de 4 digitos y la 
        //devuelve con el formato adecuado
        private int ValidarContrasena(TextBox sender)
        {
            if ((Int32.TryParse(sender.Text, out int clave)) && (sender.Text.Length == 4))
            {
                errorProvider.SetError(sender, "");
                return clave;
            }
            else
            {
                errorProvider.SetError(sender, "La clave debe tener 4 digitos numericos");
                return -1;
            }
        }


        //Consultas

        //Funcion que limpia los campos del formulario consulta
        private void LimpiarCamposConsulta()
        {
            txtNombreConsulta.Text = "";
            rtxtConsulta.Text = "";
            checkBloqueado.Checked = false;
        }

        //Funcion que busca un cliente y muestra sus datos al pulsar el boton
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String nombreBuscar = txtNombreConsulta.Text;

            foreach (Cliente cliente in clientes)
            {
                //Comprobamos si el nombre es igual 
                if (cliente.NombreCli == nombreBuscar)
                {
                    rtxtConsulta.Text = cliente.ToString();

                    if (cliente.BloqueoCli)
                    {
                        checkBloqueado.Checked = true;
                    }
                    else
                    {
                        checkBloqueado.Checked = false;
                    }

                    break;
                }
            }
        }

        //Cajero
        private void LimpiarCamposCajero()
        {
            intentos = 0;
            txtDniCajero.Text = "";
            txtClaveCajero.Text = "";
            txtDniCajero.Enabled = true;
            btnCajero.Visible = true;
            btnIniciar.Visible = false;
            txtClaveCajero.Enabled = false;
            txtDniCajero.Focus();
        }

        //Funcion que comprueba que el cliente existe y no esta bloqueado
        private void btnCajero_Click(object sender, EventArgs e)
        {
            String dni = txtDniCajero.Text;
            bool existe = false;
            foreach (Cliente cliente in clientes)
            {
                if (cliente.DniCli == dni) //Comprobamos si el cliente existe y no esta bloqueado
                {
                    existe = true;
                    if (!cliente.BloqueoCli)
                    {
                        txtClaveCajero.Enabled = true;
                        btnIniciar.Visible = true;
                        txtDniCajero.Enabled = false;
                        btnCajero.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("El cliente esta bloqueado, desbloqueelo y vuelva a intentarlo");
                    }
                }
            }

            if (!existe)
            {
                MessageBox.Show("El cliente no existe, compruebe el DNI y vuelva a intentarlo");
            }

        }

        //Funcion que comprueba que la contrasena este bien, si esta mal notifia
        // el fallo y si esta bien inicia sesion
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            String dni = txtDniCajero.Text;
            int clave = ValidarContrasena(txtClaveCajero);

            //Si la clave no tiene el formato no hacemos nada
            if (clave != -1)
            {
                foreach (Cliente cliente in clientes)
                {
                    if (cliente.DniCli == dni)
                    {
                        if (cliente.ClaveCli == clave) //Si la clave esta bien iniciamos sesion 
                        {
                            IniciarSesion(cliente);
                        }
                        else //Si la clave esta mal notificamos el fallo
                        {
                            NotificarFallo(cliente);
                        }
                    }
                }
            }
        }

        //Funcion que notifica el fallo de la clave y bloquea al cliente si se superan los 3 intentos
        private void NotificarFallo(Cliente cliente)
        {
            intentos++;
            if (intentos == 3)
            {
                cliente.BloquearCliente();
                MessageBox.Show("Ha superado el numero de intentos, el cliente ha sido bloqueado");
                LimpiarCamposCajero();
            }
            else
            {
                MessageBox.Show($"La clave es incorrecta, vuelva a intentarlo, lleva {intentos} intentos.");
            }
        }

        //Funcion que inicia sesion y abre la cuenta del cliente
        private void IniciarSesion(Cliente cliente)
        {
            MessageBox.Show("Bienvenido " + cliente.NombreCli);
            LimpiarCamposCajero();
            CuentaCliente cuentaCliente = new CuentaCliente(cliente, this);
            this.Hide();
            cuentaCliente.Show();
        }
        private void btnCancelarCajero_Click(object sender, EventArgs e)
        {
            LimpiarCamposCajero();
        }

        //Bloquear Y Desbloquear

        private void LimpiarCamposBloqueo()
        {
            txtDniBloq.Text = "";
            txtDniBloq.Enabled = true;
            txtClaveBloq.Text = "";
            txtClaveBloq.Enabled = false;
            btnBloquear.Visible = false;
            btnValidarBloq.Visible = true;
        }

        //Funcion que comprueba que el cliente existe y muestra el boton de Bloquear/Desbloquear
        private void btnValidarBloq_Click(object sender, EventArgs e)
        {
            String dni = txtDniBloq.Text;
            bool existe = false;
            foreach (Cliente cliente in clientes)
            {
                if (cliente.DniCli == dni) //Comprobamos si el cliente existe
                {
                    existe = true;
                    btnValidarBloq.Visible = false;
                    txtClaveBloq.Enabled = true;

                    if (cliente.BloqueoCli) //Dependiendo del estado del cliente mostramos el boton
                    {
                        btnBloquear.Text = "Desbloquear";
                    }
                    else
                    {
                        btnBloquear.Text = "Bloquear";
                    }
                    txtDniBloq.Enabled = false;
                    txtClaveBloq.Enabled = true;
                    btnBloquear.Visible = true;
                }
            }

            if (!existe)
            {
                MessageBox.Show("El cliente no existe, compruebe el DNI y vuelva a intentarlo");
            }
        }

        //Funcion que bloquea o desbloquea al cliente si la clave es correcta
        private void btnBloquear_Click(object sender, EventArgs e)
        {
            //Comprobamos que la clave esta correcta y realizamos la accion
            String dni = txtDniBloq.Text;
            int clave = ValidarContrasena(txtClaveBloq);

            if (clave != -1) //Si la clave no tiene el formato correcto no hacemos nada
            {
                foreach (Cliente cliente in clientes)
                {
                    if (cliente.DniCli == dni)
                    {
                        if (cliente.ClaveCli == clave) //Si la clave esta bien realizamos la accion
                        {
                            if (cliente.BloqueoCli) //Si el cliente esta bloqueado lo desbloqueamos
                            {
                                cliente.DesbloquearCliente();
                                MessageBox.Show("El cliente ha sido desbloqueado");
                            }
                            else //Si el cliente no esta bloqueado lo bloqueamos
                            {
                                cliente.BloquearCliente();
                                MessageBox.Show("El cliente ha sido bloqueado");
                            }
                            LimpiarCamposBloqueo();
                        }
                        else //Si la clave esta mal lo comunicamos
                        {
                            MessageBox.Show("Clave incorrecta");
                        }
                    }
                }
            }
        }

        private void btnCancelarBloq_Click(object sender, EventArgs e)
        {
            LimpiarCamposBloqueo();
        }
    }
}
