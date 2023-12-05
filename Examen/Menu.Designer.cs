namespace Examen
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpAltas = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblIntroduce = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.checkBloqueado = new System.Windows.Forms.CheckBox();
            this.rtxtConsulta = new System.Windows.Forms.RichTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblIntroduceConsulta = new System.Windows.Forms.Label();
            this.lblNombreConsulta = new System.Windows.Forms.Label();
            this.txtNombreConsulta = new System.Windows.Forms.TextBox();
            this.menuStripMenu = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloquearDesbloquearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpCajero = new System.Windows.Forms.GroupBox();
            this.btnCancelarCajero = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCajero = new System.Windows.Forms.Button();
            this.lblIntroduceCajero = new System.Windows.Forms.Label();
            this.lblClaveCajero = new System.Windows.Forms.Label();
            this.lblDniCajero = new System.Windows.Forms.Label();
            this.txtClaveCajero = new System.Windows.Forms.TextBox();
            this.txtDniCajero = new System.Windows.Forms.TextBox();
            this.grpBloq = new System.Windows.Forms.GroupBox();
            this.btnCancelarBloq = new System.Windows.Forms.Button();
            this.btnBloquear = new System.Windows.Forms.Button();
            this.btnValidarBloq = new System.Windows.Forms.Button();
            this.lblBloq = new System.Windows.Forms.Label();
            this.lblClaveBloq = new System.Windows.Forms.Label();
            this.lblDniBloq = new System.Windows.Forms.Label();
            this.txtClaveBloq = new System.Windows.Forms.TextBox();
            this.txtDniBloq = new System.Windows.Forms.TextBox();
            this.grpAltas.SuspendLayout();
            this.grpConsulta.SuspendLayout();
            this.menuStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.grpCajero.SuspendLayout();
            this.grpBloq.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAltas
            // 
            this.grpAltas.Controls.Add(this.btnCrear);
            this.grpAltas.Controls.Add(this.lblIntroduce);
            this.grpAltas.Controls.Add(this.lblSaldo);
            this.grpAltas.Controls.Add(this.lblClave);
            this.grpAltas.Controls.Add(this.lblNombre);
            this.grpAltas.Controls.Add(this.lblDni);
            this.grpAltas.Controls.Add(this.txtSaldo);
            this.grpAltas.Controls.Add(this.txtClave);
            this.grpAltas.Controls.Add(this.txtNombre);
            this.grpAltas.Controls.Add(this.txtDni);
            this.grpAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAltas.Location = new System.Drawing.Point(76, 85);
            this.grpAltas.Name = "grpAltas";
            this.grpAltas.Size = new System.Drawing.Size(728, 606);
            this.grpAltas.TabIndex = 0;
            this.grpAltas.TabStop = false;
            this.grpAltas.Text = "Altas";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(243, 494);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(118, 55);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblIntroduce
            // 
            this.lblIntroduce.AutoSize = true;
            this.lblIntroduce.Location = new System.Drawing.Point(158, 99);
            this.lblIntroduce.Name = "lblIntroduce";
            this.lblIntroduce.Size = new System.Drawing.Size(409, 26);
            this.lblIntroduce.TabIndex = 8;
            this.lblIntroduce.Text = "Introduce tus datos para darte de alta";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(69, 403);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(80, 26);
            this.lblSaldo.TabIndex = 7;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(69, 329);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(193, 26);
            this.lblClave.TabIndex = 6;
            this.lblClave.Text = "Clave (4 digitos):";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(69, 254);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(103, 26);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(69, 184);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(107, 26);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI/NIE:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(287, 400);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(205, 32);
            this.txtSaldo.TabIndex = 3;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(287, 326);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(205, 32);
            this.txtClave.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(287, 251);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 32);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(287, 181);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(205, 32);
            this.txtDni.TabIndex = 0;
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.checkBloqueado);
            this.grpConsulta.Controls.Add(this.rtxtConsulta);
            this.grpConsulta.Controls.Add(this.btnBuscar);
            this.grpConsulta.Controls.Add(this.lblIntroduceConsulta);
            this.grpConsulta.Controls.Add(this.lblNombreConsulta);
            this.grpConsulta.Controls.Add(this.txtNombreConsulta);
            this.grpConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsulta.Location = new System.Drawing.Point(65, 73);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(739, 599);
            this.grpConsulta.TabIndex = 1;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Consultas";
            this.grpConsulta.Visible = false;
            // 
            // checkBloqueado
            // 
            this.checkBloqueado.AutoSize = true;
            this.checkBloqueado.Enabled = false;
            this.checkBloqueado.Location = new System.Drawing.Point(261, 446);
            this.checkBloqueado.Name = "checkBloqueado";
            this.checkBloqueado.Size = new System.Drawing.Size(227, 30);
            this.checkBloqueado.TabIndex = 15;
            this.checkBloqueado.Text = "Ciente Bloqueado";
            this.checkBloqueado.UseVisualStyleBackColor = true;
            // 
            // rtxtConsulta
            // 
            this.rtxtConsulta.Location = new System.Drawing.Point(78, 277);
            this.rtxtConsulta.Name = "rtxtConsulta";
            this.rtxtConsulta.Size = new System.Drawing.Size(566, 120);
            this.rtxtConsulta.TabIndex = 13;
            this.rtxtConsulta.Text = "";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(295, 512);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 55);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblIntroduceConsulta
            // 
            this.lblIntroduceConsulta.AutoSize = true;
            this.lblIntroduceConsulta.Location = new System.Drawing.Point(186, 111);
            this.lblIntroduceConsulta.Name = "lblIntroduceConsulta";
            this.lblIntroduceConsulta.Size = new System.Drawing.Size(352, 26);
            this.lblIntroduceConsulta.TabIndex = 12;
            this.lblIntroduceConsulta.Text = "Introduce el Nombre a consultar";
            // 
            // lblNombreConsulta
            // 
            this.lblNombreConsulta.AutoSize = true;
            this.lblNombreConsulta.Location = new System.Drawing.Point(158, 180);
            this.lblNombreConsulta.Name = "lblNombreConsulta";
            this.lblNombreConsulta.Size = new System.Drawing.Size(107, 26);
            this.lblNombreConsulta.TabIndex = 11;
            this.lblNombreConsulta.Text = "DNI/NIE:";
            // 
            // txtNombreConsulta
            // 
            this.txtNombreConsulta.Location = new System.Drawing.Point(367, 177);
            this.txtNombreConsulta.Name = "txtNombreConsulta";
            this.txtNombreConsulta.Size = new System.Drawing.Size(205, 32);
            this.txtNombreConsulta.TabIndex = 10;
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripMenu.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.menuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.cajeroToolStripMenuItem,
            this.taToolStripMenuItem,
            this.autorToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.Size = new System.Drawing.Size(864, 36);
            this.menuStripMenu.TabIndex = 2;
            this.menuStripMenu.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(90, 32);
            this.clienteToolStripMenuItem.Text = "&Cliente";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
            this.altaToolStripMenuItem.Text = "&Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
            this.consultaToolStripMenuItem.Text = "&Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // cajeroToolStripMenuItem
            // 
            this.cajeroToolStripMenuItem.Name = "cajeroToolStripMenuItem";
            this.cajeroToolStripMenuItem.Size = new System.Drawing.Size(86, 32);
            this.cajeroToolStripMenuItem.Text = "&Cajero";
            this.cajeroToolStripMenuItem.Click += new System.EventHandler(this.cajeroToolStripMenuItem_Click);
            // 
            // taToolStripMenuItem
            // 
            this.taToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bloquearDesbloquearToolStripMenuItem});
            this.taToolStripMenuItem.Name = "taToolStripMenuItem";
            this.taToolStripMenuItem.Size = new System.Drawing.Size(87, 32);
            this.taToolStripMenuItem.Text = "&Tarjeta";
            // 
            // bloquearDesbloquearToolStripMenuItem
            // 
            this.bloquearDesbloquearToolStripMenuItem.Name = "bloquearDesbloquearToolStripMenuItem";
            this.bloquearDesbloquearToolStripMenuItem.Size = new System.Drawing.Size(319, 36);
            this.bloquearDesbloquearToolStripMenuItem.Text = "Bloquear/Desbloquear";
            this.bloquearDesbloquearToolStripMenuItem.Click += new System.EventHandler(this.bloquearDesbloquearToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(80, 32);
            this.autorToolStripMenuItem.Text = "&Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(83, 32);
            this.cerrarToolStripMenuItem.Text = "&Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // grpCajero
            // 
            this.grpCajero.Controls.Add(this.btnCancelarCajero);
            this.grpCajero.Controls.Add(this.btnIniciar);
            this.grpCajero.Controls.Add(this.btnCajero);
            this.grpCajero.Controls.Add(this.lblIntroduceCajero);
            this.grpCajero.Controls.Add(this.lblClaveCajero);
            this.grpCajero.Controls.Add(this.lblDniCajero);
            this.grpCajero.Controls.Add(this.txtClaveCajero);
            this.grpCajero.Controls.Add(this.txtDniCajero);
            this.grpCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCajero.Location = new System.Drawing.Point(50, 104);
            this.grpCajero.Name = "grpCajero";
            this.grpCajero.Size = new System.Drawing.Size(728, 577);
            this.grpCajero.TabIndex = 10;
            this.grpCajero.TabStop = false;
            this.grpCajero.Text = "Cajero";
            this.grpCajero.Visible = false;
            // 
            // btnCancelarCajero
            // 
            this.btnCancelarCajero.Location = new System.Drawing.Point(562, 31);
            this.btnCancelarCajero.Name = "btnCancelarCajero";
            this.btnCancelarCajero.Size = new System.Drawing.Size(149, 58);
            this.btnCancelarCajero.TabIndex = 13;
            this.btnCancelarCajero.Text = "Cancelar";
            this.btnCancelarCajero.UseVisualStyleBackColor = true;
            this.btnCancelarCajero.Click += new System.EventHandler(this.btnCancelarCajero_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(218, 481);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(192, 55);
            this.btnIniciar.TabIndex = 10;
            this.btnIniciar.Text = "Entrar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCajero
            // 
            this.btnCajero.Location = new System.Drawing.Point(218, 402);
            this.btnCajero.Name = "btnCajero";
            this.btnCajero.Size = new System.Drawing.Size(192, 55);
            this.btnCajero.TabIndex = 9;
            this.btnCajero.Text = "Validar DNI";
            this.btnCajero.UseVisualStyleBackColor = true;
            this.btnCajero.Click += new System.EventHandler(this.btnCajero_Click);
            // 
            // lblIntroduceCajero
            // 
            this.lblIntroduceCajero.AutoSize = true;
            this.lblIntroduceCajero.Location = new System.Drawing.Point(129, 97);
            this.lblIntroduceCajero.Name = "lblIntroduceCajero";
            this.lblIntroduceCajero.Size = new System.Drawing.Size(416, 26);
            this.lblIntroduceCajero.TabIndex = 8;
            this.lblIntroduceCajero.Text = "Introduce tus datos para iniciar sesion";
            // 
            // lblClaveCajero
            // 
            this.lblClaveCajero.AutoSize = true;
            this.lblClaveCajero.Location = new System.Drawing.Point(112, 329);
            this.lblClaveCajero.Name = "lblClaveCajero";
            this.lblClaveCajero.Size = new System.Drawing.Size(193, 26);
            this.lblClaveCajero.TabIndex = 6;
            this.lblClaveCajero.Text = "Clave (4 digitos):";
            // 
            // lblDniCajero
            // 
            this.lblDniCajero.AutoSize = true;
            this.lblDniCajero.Location = new System.Drawing.Point(112, 251);
            this.lblDniCajero.Name = "lblDniCajero";
            this.lblDniCajero.Size = new System.Drawing.Size(107, 26);
            this.lblDniCajero.TabIndex = 4;
            this.lblDniCajero.Text = "DNI/NIE:";
            // 
            // txtClaveCajero
            // 
            this.txtClaveCajero.Enabled = false;
            this.txtClaveCajero.Location = new System.Drawing.Point(330, 326);
            this.txtClaveCajero.Name = "txtClaveCajero";
            this.txtClaveCajero.PasswordChar = '*';
            this.txtClaveCajero.Size = new System.Drawing.Size(205, 32);
            this.txtClaveCajero.TabIndex = 2;
            // 
            // txtDniCajero
            // 
            this.txtDniCajero.Location = new System.Drawing.Point(330, 248);
            this.txtDniCajero.Name = "txtDniCajero";
            this.txtDniCajero.Size = new System.Drawing.Size(205, 32);
            this.txtDniCajero.TabIndex = 0;
            // 
            // grpBloq
            // 
            this.grpBloq.Controls.Add(this.btnCancelarBloq);
            this.grpBloq.Controls.Add(this.btnBloquear);
            this.grpBloq.Controls.Add(this.btnValidarBloq);
            this.grpBloq.Controls.Add(this.lblBloq);
            this.grpBloq.Controls.Add(this.lblClaveBloq);
            this.grpBloq.Controls.Add(this.lblDniBloq);
            this.grpBloq.Controls.Add(this.txtClaveBloq);
            this.grpBloq.Controls.Add(this.txtDniBloq);
            this.grpBloq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBloq.Location = new System.Drawing.Point(33, 73);
            this.grpBloq.Name = "grpBloq";
            this.grpBloq.Size = new System.Drawing.Size(728, 618);
            this.grpBloq.TabIndex = 11;
            this.grpBloq.TabStop = false;
            this.grpBloq.Text = "Bloquear/Desbloquear";
            this.grpBloq.Visible = false;
            // 
            // btnCancelarBloq
            // 
            this.btnCancelarBloq.Location = new System.Drawing.Point(556, 31);
            this.btnCancelarBloq.Name = "btnCancelarBloq";
            this.btnCancelarBloq.Size = new System.Drawing.Size(152, 58);
            this.btnCancelarBloq.TabIndex = 12;
            this.btnCancelarBloq.Text = "Cancelar";
            this.btnCancelarBloq.UseVisualStyleBackColor = true;
            this.btnCancelarBloq.Click += new System.EventHandler(this.btnCancelarBloq_Click);
            // 
            // btnBloquear
            // 
            this.btnBloquear.Location = new System.Drawing.Point(250, 522);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Size = new System.Drawing.Size(192, 55);
            this.btnBloquear.TabIndex = 11;
            this.btnBloquear.Text = "Bloquear";
            this.btnBloquear.UseVisualStyleBackColor = true;
            this.btnBloquear.Visible = false;
            this.btnBloquear.Click += new System.EventHandler(this.btnBloquear_Click);
            // 
            // btnValidarBloq
            // 
            this.btnValidarBloq.Location = new System.Drawing.Point(250, 447);
            this.btnValidarBloq.Name = "btnValidarBloq";
            this.btnValidarBloq.Size = new System.Drawing.Size(192, 55);
            this.btnValidarBloq.TabIndex = 9;
            this.btnValidarBloq.Text = "Validar DNI";
            this.btnValidarBloq.UseVisualStyleBackColor = true;
            this.btnValidarBloq.Click += new System.EventHandler(this.btnValidarBloq_Click);
            // 
            // lblBloq
            // 
            this.lblBloq.AutoSize = true;
            this.lblBloq.Location = new System.Drawing.Point(107, 112);
            this.lblBloq.Name = "lblBloq";
            this.lblBloq.Size = new System.Drawing.Size(526, 26);
            this.lblBloq.TabIndex = 8;
            this.lblBloq.Text = "Introduce tus datos para Bloquear / Desbloquear";
            // 
            // lblClaveBloq
            // 
            this.lblClaveBloq.AutoSize = true;
            this.lblClaveBloq.Location = new System.Drawing.Point(101, 329);
            this.lblClaveBloq.Name = "lblClaveBloq";
            this.lblClaveBloq.Size = new System.Drawing.Size(193, 26);
            this.lblClaveBloq.TabIndex = 6;
            this.lblClaveBloq.Text = "Clave (4 digitos):";
            // 
            // lblDniBloq
            // 
            this.lblDniBloq.AutoSize = true;
            this.lblDniBloq.Location = new System.Drawing.Point(101, 251);
            this.lblDniBloq.Name = "lblDniBloq";
            this.lblDniBloq.Size = new System.Drawing.Size(107, 26);
            this.lblDniBloq.TabIndex = 4;
            this.lblDniBloq.Text = "DNI/NIE:";
            // 
            // txtClaveBloq
            // 
            this.txtClaveBloq.Enabled = false;
            this.txtClaveBloq.Location = new System.Drawing.Point(319, 326);
            this.txtClaveBloq.Name = "txtClaveBloq";
            this.txtClaveBloq.Size = new System.Drawing.Size(205, 32);
            this.txtClaveBloq.TabIndex = 2;
            // 
            // txtDniBloq
            // 
            this.txtDniBloq.Location = new System.Drawing.Point(319, 248);
            this.txtDniBloq.Name = "txtDniBloq";
            this.txtDniBloq.Size = new System.Drawing.Size(205, 32);
            this.txtDniBloq.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 747);
            this.Controls.Add(this.grpBloq);
            this.Controls.Add(this.grpCajero);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.grpAltas);
            this.Controls.Add(this.menuStripMenu);
            this.MainMenuStrip = this.menuStripMenu;
            this.Name = "Menu";
            this.Text = "Menu";
            this.grpAltas.ResumeLayout(false);
            this.grpAltas.PerformLayout();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            this.menuStripMenu.ResumeLayout(false);
            this.menuStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.grpCajero.ResumeLayout(false);
            this.grpCajero.PerformLayout();
            this.grpBloq.ResumeLayout(false);
            this.grpBloq.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAltas;
        private System.Windows.Forms.Label lblIntroduce;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.MenuStrip menuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taToolStripMenuItem;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblIntroduceConsulta;
        private System.Windows.Forms.Label lblNombreConsulta;
        private System.Windows.Forms.TextBox txtNombreConsulta;
        private System.Windows.Forms.ToolStripMenuItem bloquearDesbloquearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtxtConsulta;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox checkBloqueado;
        private System.Windows.Forms.GroupBox grpBloq;
        private System.Windows.Forms.Button btnValidarBloq;
        private System.Windows.Forms.Label lblBloq;
        private System.Windows.Forms.Label lblClaveBloq;
        private System.Windows.Forms.Label lblDniBloq;
        private System.Windows.Forms.TextBox txtClaveBloq;
        private System.Windows.Forms.TextBox txtDniBloq;
        private System.Windows.Forms.GroupBox grpCajero;
        private System.Windows.Forms.Button btnCajero;
        private System.Windows.Forms.Label lblIntroduceCajero;
        private System.Windows.Forms.Label lblClaveCajero;
        private System.Windows.Forms.Label lblDniCajero;
        private System.Windows.Forms.TextBox txtClaveCajero;
        private System.Windows.Forms.TextBox txtDniCajero;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnBloquear;
        private System.Windows.Forms.Button btnCancelarBloq;
        private System.Windows.Forms.Button btnCancelarCajero;
    }
}

