namespace EjercicioClasesHerencia
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porDNIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reintegroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trasferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entreCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxAltas = new System.Windows.Forms.GroupBox();
            this.txtNCuenta = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtTopeCredito = new System.Windows.Forms.TextBox();
            this.txtMesesCredito = new System.Windows.Forms.TextBox();
            this.radioBtnPersonal = new System.Windows.Forms.RadioButton();
            this.grpBoxTipo = new System.Windows.Forms.GroupBox();
            this.radioBtnEmpresa = new System.Windows.Forms.RadioButton();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblNCuentaAltas = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.lblInteres = new System.Windows.Forms.Label();
            this.lblMesesCredito = new System.Windows.Forms.Label();
            this.lblTopeCredito = new System.Windows.Forms.Label();
            this.lblCuentaEmpresa = new System.Windows.Forms.Label();
            this.grpBoxConsultas = new System.Windows.Forms.GroupBox();
            this.lblDNIBuscar = new System.Windows.Forms.Label();
            this.lblNumeroBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpTipoBusqueda = new System.Windows.Forms.GroupBox();
            this.radioDNI = new System.Windows.Forms.RadioButton();
            this.radioNumero = new System.Windows.Forms.RadioButton();
            this.txtDNIBuscar = new System.Windows.Forms.TextBox();
            this.txtNumeroBuscar = new System.Windows.Forms.TextBox();
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblNumeroOperaciones = new System.Windows.Forms.Label();
            this.btnIngresarSacar = new System.Windows.Forms.Button();
            this.grpIngresoReintegro = new System.Windows.Forms.GroupBox();
            this.radioReintegro = new System.Windows.Forms.RadioButton();
            this.radioIngreso = new System.Windows.Forms.RadioButton();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtNumeroOpraciones = new System.Windows.Forms.TextBox();
            this.grpTrasferencias = new System.Windows.Forms.GroupBox();
            this.lblImporteTrasf = new System.Windows.Forms.Label();
            this.lblNOrigen = new System.Windows.Forms.Label();
            this.brnTrasferir = new System.Windows.Forms.Button();
            this.txtImporteTrasf = new System.Windows.Forms.TextBox();
            this.txtNOrigen = new System.Windows.Forms.TextBox();
            this.lblNDestino = new System.Windows.Forms.Label();
            this.txtNDestino = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip.SuspendLayout();
            this.grpBoxAltas.SuspendLayout();
            this.grpBoxTipo.SuspendLayout();
            this.grpBoxConsultas.SuspendLayout();
            this.grpTipoBusqueda.SuspendLayout();
            this.grpOperaciones.SuspendLayout();
            this.grpIngresoReintegro.SuspendLayout();
            this.grpTrasferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.trasferenciasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(910, 36);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeCuentaToolStripMenuItem});
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(73, 32);
            this.altaToolStripMenuItem.Text = "&Altas";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNCuentaToolStripMenuItem,
            this.porDNIToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(114, 32);
            this.consultasToolStripMenuItem.Text = "&Consultas";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem,
            this.reintegroToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(139, 32);
            this.operacionesToolStripMenuItem.Text = "&Operaciones";
            // 
            // porNCuentaToolStripMenuItem
            // 
            this.porNCuentaToolStripMenuItem.Name = "porNCuentaToolStripMenuItem";
            this.porNCuentaToolStripMenuItem.Size = new System.Drawing.Size(321, 36);
            this.porNCuentaToolStripMenuItem.Text = "&Por Numero de Cuenta";
            this.porNCuentaToolStripMenuItem.Click += new System.EventHandler(this.porNCuentaToolStripMenuItem_Click);
            // 
            // porDNIToolStripMenuItem
            // 
            this.porDNIToolStripMenuItem.Name = "porDNIToolStripMenuItem";
            this.porDNIToolStripMenuItem.Size = new System.Drawing.Size(321, 36);
            this.porDNIToolStripMenuItem.Text = "&Por DNI";
            this.porDNIToolStripMenuItem.Click += new System.EventHandler(this.porDNIToolStripMenuItem_Click);
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(296, 36);
            this.ingresoToolStripMenuItem.Text = "&Ingreso";
            this.ingresoToolStripMenuItem.Click += new System.EventHandler(this.ingresoToolStripMenuItem_Click);
            // 
            // reintegroToolStripMenuItem
            // 
            this.reintegroToolStripMenuItem.Name = "reintegroToolStripMenuItem";
            this.reintegroToolStripMenuItem.Size = new System.Drawing.Size(296, 36);
            this.reintegroToolStripMenuItem.Text = "&Reintegro";
            this.reintegroToolStripMenuItem.Click += new System.EventHandler(this.reintegroToolStripMenuItem_Click);
            // 
            // altaDeCuentaToolStripMenuItem
            // 
            this.altaDeCuentaToolStripMenuItem.Name = "altaDeCuentaToolStripMenuItem";
            this.altaDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(296, 36);
            this.altaDeCuentaToolStripMenuItem.Text = "&Alta de Cuenta";
            this.altaDeCuentaToolStripMenuItem.Click += new System.EventHandler(this.altaDeCuentaToolStripMenuItem_Click);
            // 
            // trasferenciasToolStripMenuItem
            // 
            this.trasferenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entreCuentasToolStripMenuItem});
            this.trasferenciasToolStripMenuItem.Name = "trasferenciasToolStripMenuItem";
            this.trasferenciasToolStripMenuItem.Size = new System.Drawing.Size(139, 32);
            this.trasferenciasToolStripMenuItem.Text = "&Trasferencias";
            // 
            // entreCuentasToolStripMenuItem
            // 
            this.entreCuentasToolStripMenuItem.Name = "entreCuentasToolStripMenuItem";
            this.entreCuentasToolStripMenuItem.Size = new System.Drawing.Size(296, 36);
            this.entreCuentasToolStripMenuItem.Text = "&Entre cuentas";
            this.entreCuentasToolStripMenuItem.Click += new System.EventHandler(this.entreCuentasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(68, 32);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // grpBoxAltas
            // 
            this.grpBoxAltas.Controls.Add(this.lblCuentaEmpresa);
            this.grpBoxAltas.Controls.Add(this.lblTopeCredito);
            this.grpBoxAltas.Controls.Add(this.lblMesesCredito);
            this.grpBoxAltas.Controls.Add(this.lblInteres);
            this.grpBoxAltas.Controls.Add(this.txtInteres);
            this.grpBoxAltas.Controls.Add(this.lblDni);
            this.grpBoxAltas.Controls.Add(this.lblTitular);
            this.grpBoxAltas.Controls.Add(this.lblNCuentaAltas);
            this.grpBoxAltas.Controls.Add(this.btnCrear);
            this.grpBoxAltas.Controls.Add(this.grpBoxTipo);
            this.grpBoxAltas.Controls.Add(this.txtTopeCredito);
            this.grpBoxAltas.Controls.Add(this.txtMesesCredito);
            this.grpBoxAltas.Controls.Add(this.txtDni);
            this.grpBoxAltas.Controls.Add(this.txtTitular);
            this.grpBoxAltas.Controls.Add(this.txtNCuenta);
            this.grpBoxAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAltas.Location = new System.Drawing.Point(47, 83);
            this.grpBoxAltas.Name = "grpBoxAltas";
            this.grpBoxAltas.Size = new System.Drawing.Size(795, 608);
            this.grpBoxAltas.TabIndex = 1;
            this.grpBoxAltas.TabStop = false;
            this.grpBoxAltas.Text = "Altas";
            this.grpBoxAltas.Visible = false;
            // 
            // txtNCuenta
            // 
            this.txtNCuenta.Enabled = false;
            this.txtNCuenta.Location = new System.Drawing.Point(271, 104);
            this.txtNCuenta.Name = "txtNCuenta";
            this.txtNCuenta.Size = new System.Drawing.Size(176, 32);
            this.txtNCuenta.TabIndex = 0;
            this.txtNCuenta.Text = "1";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(271, 165);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(176, 32);
            this.txtTitular.TabIndex = 1;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(271, 224);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(176, 32);
            this.txtDni.TabIndex = 2;
            // 
            // txtTopeCredito
            // 
            this.txtTopeCredito.Enabled = false;
            this.txtTopeCredito.Location = new System.Drawing.Point(271, 476);
            this.txtTopeCredito.Name = "txtTopeCredito";
            this.txtTopeCredito.Size = new System.Drawing.Size(176, 32);
            this.txtTopeCredito.TabIndex = 6;
            // 
            // txtMesesCredito
            // 
            this.txtMesesCredito.Enabled = false;
            this.txtMesesCredito.Location = new System.Drawing.Point(271, 417);
            this.txtMesesCredito.Name = "txtMesesCredito";
            this.txtMesesCredito.Size = new System.Drawing.Size(176, 32);
            this.txtMesesCredito.TabIndex = 5;
            // 
            // radioBtnPersonal
            // 
            this.radioBtnPersonal.AutoSize = true;
            this.radioBtnPersonal.Checked = true;
            this.radioBtnPersonal.Location = new System.Drawing.Point(22, 44);
            this.radioBtnPersonal.Name = "radioBtnPersonal";
            this.radioBtnPersonal.Size = new System.Drawing.Size(131, 30);
            this.radioBtnPersonal.TabIndex = 8;
            this.radioBtnPersonal.TabStop = true;
            this.radioBtnPersonal.Text = "Personal";
            this.radioBtnPersonal.UseVisualStyleBackColor = true;
            this.radioBtnPersonal.CheckedChanged += new System.EventHandler(this.radioBtnPersonal_CheckedChanged);
            // 
            // grpBoxTipo
            // 
            this.grpBoxTipo.Controls.Add(this.radioBtnEmpresa);
            this.grpBoxTipo.Controls.Add(this.radioBtnPersonal);
            this.grpBoxTipo.Location = new System.Drawing.Point(508, 233);
            this.grpBoxTipo.Name = "grpBoxTipo";
            this.grpBoxTipo.Size = new System.Drawing.Size(251, 160);
            this.grpBoxTipo.TabIndex = 9;
            this.grpBoxTipo.TabStop = false;
            this.grpBoxTipo.Text = "Tipo de Cuenta:";
            // 
            // radioBtnEmpresa
            // 
            this.radioBtnEmpresa.AutoSize = true;
            this.radioBtnEmpresa.Location = new System.Drawing.Point(22, 89);
            this.radioBtnEmpresa.Name = "radioBtnEmpresa";
            this.radioBtnEmpresa.Size = new System.Drawing.Size(132, 30);
            this.radioBtnEmpresa.TabIndex = 9;
            this.radioBtnEmpresa.Text = "Empresa";
            this.radioBtnEmpresa.UseVisualStyleBackColor = true;
            this.radioBtnEmpresa.CheckedChanged += new System.EventHandler(this.radioBtnEmpresa_CheckedChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(292, 538);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(134, 50);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblNCuentaAltas
            // 
            this.lblNCuentaAltas.AutoSize = true;
            this.lblNCuentaAltas.Location = new System.Drawing.Point(48, 107);
            this.lblNCuentaAltas.Name = "lblNCuentaAltas";
            this.lblNCuentaAltas.Size = new System.Drawing.Size(179, 26);
            this.lblNCuentaAltas.TabIndex = 11;
            this.lblNCuentaAltas.Text = "Numero Cuenta";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(48, 168);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(78, 26);
            this.lblTitular.TabIndex = 13;
            this.lblTitular.Text = "Titular";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(48, 227);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(112, 26);
            this.lblDni.TabIndex = 14;
            this.lblDni.Text = "DNI / NIF";
            // 
            // txtInteres
            // 
            this.txtInteres.Enabled = false;
            this.txtInteres.Location = new System.Drawing.Point(271, 356);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(176, 32);
            this.txtInteres.TabIndex = 16;
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Location = new System.Drawing.Point(48, 359);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(85, 26);
            this.lblInteres.TabIndex = 17;
            this.lblInteres.Text = "Interes";
            // 
            // lblMesesCredito
            // 
            this.lblMesesCredito.AutoSize = true;
            this.lblMesesCredito.Location = new System.Drawing.Point(48, 420);
            this.lblMesesCredito.Name = "lblMesesCredito";
            this.lblMesesCredito.Size = new System.Drawing.Size(160, 26);
            this.lblMesesCredito.TabIndex = 18;
            this.lblMesesCredito.Text = "Meses credito";
            // 
            // lblTopeCredito
            // 
            this.lblTopeCredito.AutoSize = true;
            this.lblTopeCredito.Location = new System.Drawing.Point(48, 479);
            this.lblTopeCredito.Name = "lblTopeCredito";
            this.lblTopeCredito.Size = new System.Drawing.Size(148, 26);
            this.lblTopeCredito.TabIndex = 19;
            this.lblTopeCredito.Text = "Tope Credito";
            // 
            // lblCuentaEmpresa
            // 
            this.lblCuentaEmpresa.AutoSize = true;
            this.lblCuentaEmpresa.Location = new System.Drawing.Point(98, 314);
            this.lblCuentaEmpresa.Name = "lblCuentaEmpresa";
            this.lblCuentaEmpresa.Size = new System.Drawing.Size(289, 26);
            this.lblCuentaEmpresa.TabIndex = 20;
            this.lblCuentaEmpresa.Text = "(Solo cuenta de Empresa)";
            // 
            // grpBoxConsultas
            // 
            this.grpBoxConsultas.Controls.Add(this.lblDNIBuscar);
            this.grpBoxConsultas.Controls.Add(this.lblNumeroBuscar);
            this.grpBoxConsultas.Controls.Add(this.btnBuscar);
            this.grpBoxConsultas.Controls.Add(this.grpTipoBusqueda);
            this.grpBoxConsultas.Controls.Add(this.txtDNIBuscar);
            this.grpBoxConsultas.Controls.Add(this.txtNumeroBuscar);
            this.grpBoxConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxConsultas.Location = new System.Drawing.Point(37, 77);
            this.grpBoxConsultas.Name = "grpBoxConsultas";
            this.grpBoxConsultas.Size = new System.Drawing.Size(778, 608);
            this.grpBoxConsultas.TabIndex = 21;
            this.grpBoxConsultas.TabStop = false;
            this.grpBoxConsultas.Text = "Consultas";
            this.grpBoxConsultas.Visible = false;
            // 
            // lblDNIBuscar
            // 
            this.lblDNIBuscar.AutoSize = true;
            this.lblDNIBuscar.Location = new System.Drawing.Point(146, 323);
            this.lblDNIBuscar.Name = "lblDNIBuscar";
            this.lblDNIBuscar.Size = new System.Drawing.Size(112, 26);
            this.lblDNIBuscar.TabIndex = 14;
            this.lblDNIBuscar.Text = "DNI / NIF";
            // 
            // lblNumeroBuscar
            // 
            this.lblNumeroBuscar.AutoSize = true;
            this.lblNumeroBuscar.Location = new System.Drawing.Point(79, 259);
            this.lblNumeroBuscar.Name = "lblNumeroBuscar";
            this.lblNumeroBuscar.Size = new System.Drawing.Size(179, 26);
            this.lblNumeroBuscar.TabIndex = 11;
            this.lblNumeroBuscar.Text = "Numero Cuenta";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(298, 420);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(134, 50);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpTipoBusqueda
            // 
            this.grpTipoBusqueda.Controls.Add(this.radioDNI);
            this.grpTipoBusqueda.Controls.Add(this.radioNumero);
            this.grpTipoBusqueda.Location = new System.Drawing.Point(544, 226);
            this.grpTipoBusqueda.Name = "grpTipoBusqueda";
            this.grpTipoBusqueda.Size = new System.Drawing.Size(180, 160);
            this.grpTipoBusqueda.TabIndex = 9;
            this.grpTipoBusqueda.TabStop = false;
            this.grpTipoBusqueda.Text = "Buscar por:";
            // 
            // radioDNI
            // 
            this.radioDNI.AutoSize = true;
            this.radioDNI.Location = new System.Drawing.Point(22, 89);
            this.radioDNI.Name = "radioDNI";
            this.radioDNI.Size = new System.Drawing.Size(123, 30);
            this.radioDNI.TabIndex = 9;
            this.radioDNI.Text = "DNI/NIF";
            this.radioDNI.UseVisualStyleBackColor = true;
            this.radioDNI.CheckedChanged += new System.EventHandler(this.radioDNI_CheckedChanged);
            // 
            // radioNumero
            // 
            this.radioNumero.AutoSize = true;
            this.radioNumero.Location = new System.Drawing.Point(22, 44);
            this.radioNumero.Name = "radioNumero";
            this.radioNumero.Size = new System.Drawing.Size(121, 30);
            this.radioNumero.TabIndex = 8;
            this.radioNumero.Text = "Numero";
            this.radioNumero.UseVisualStyleBackColor = true;
            this.radioNumero.CheckedChanged += new System.EventHandler(this.radioNumero_CheckedChanged);
            // 
            // txtDNIBuscar
            // 
            this.txtDNIBuscar.Location = new System.Drawing.Point(298, 320);
            this.txtDNIBuscar.Name = "txtDNIBuscar";
            this.txtDNIBuscar.Size = new System.Drawing.Size(176, 32);
            this.txtDNIBuscar.TabIndex = 2;
            // 
            // txtNumeroBuscar
            // 
            this.txtNumeroBuscar.Location = new System.Drawing.Point(298, 253);
            this.txtNumeroBuscar.Name = "txtNumeroBuscar";
            this.txtNumeroBuscar.Size = new System.Drawing.Size(176, 32);
            this.txtNumeroBuscar.TabIndex = 0;
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.Controls.Add(this.lblImporte);
            this.grpOperaciones.Controls.Add(this.lblNumeroOperaciones);
            this.grpOperaciones.Controls.Add(this.btnIngresarSacar);
            this.grpOperaciones.Controls.Add(this.grpIngresoReintegro);
            this.grpOperaciones.Controls.Add(this.txtImporte);
            this.grpOperaciones.Controls.Add(this.txtNumeroOpraciones);
            this.grpOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOperaciones.Location = new System.Drawing.Point(31, 92);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.Size = new System.Drawing.Size(835, 608);
            this.grpOperaciones.TabIndex = 22;
            this.grpOperaciones.TabStop = false;
            this.grpOperaciones.Text = "Operaciones";
            this.grpOperaciones.Visible = false;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(146, 323);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(93, 26);
            this.lblImporte.TabIndex = 14;
            this.lblImporte.Text = "Importe";
            // 
            // lblNumeroOperaciones
            // 
            this.lblNumeroOperaciones.AutoSize = true;
            this.lblNumeroOperaciones.Location = new System.Drawing.Point(79, 259);
            this.lblNumeroOperaciones.Name = "lblNumeroOperaciones";
            this.lblNumeroOperaciones.Size = new System.Drawing.Size(179, 26);
            this.lblNumeroOperaciones.TabIndex = 11;
            this.lblNumeroOperaciones.Text = "Numero Cuenta";
            // 
            // btnIngresarSacar
            // 
            this.btnIngresarSacar.Location = new System.Drawing.Point(298, 420);
            this.btnIngresarSacar.Name = "btnIngresarSacar";
            this.btnIngresarSacar.Size = new System.Drawing.Size(134, 50);
            this.btnIngresarSacar.TabIndex = 10;
            this.btnIngresarSacar.Text = "Ingresar";
            this.btnIngresarSacar.UseVisualStyleBackColor = true;
            this.btnIngresarSacar.Click += new System.EventHandler(this.btnIngresarSacar_Click);
            // 
            // grpIngresoReintegro
            // 
            this.grpIngresoReintegro.Controls.Add(this.radioReintegro);
            this.grpIngresoReintegro.Controls.Add(this.radioIngreso);
            this.grpIngresoReintegro.Location = new System.Drawing.Point(556, 224);
            this.grpIngresoReintegro.Name = "grpIngresoReintegro";
            this.grpIngresoReintegro.Size = new System.Drawing.Size(187, 160);
            this.grpIngresoReintegro.TabIndex = 9;
            this.grpIngresoReintegro.TabStop = false;
            this.grpIngresoReintegro.Text = "Hacer";
            // 
            // radioReintegro
            // 
            this.radioReintegro.AutoSize = true;
            this.radioReintegro.Location = new System.Drawing.Point(22, 89);
            this.radioReintegro.Name = "radioReintegro";
            this.radioReintegro.Size = new System.Drawing.Size(140, 30);
            this.radioReintegro.TabIndex = 9;
            this.radioReintegro.Text = "Reintegro";
            this.radioReintegro.UseVisualStyleBackColor = true;
            this.radioReintegro.CheckedChanged += new System.EventHandler(this.radioReintegro_CheckedChanged);
            // 
            // radioIngreso
            // 
            this.radioIngreso.AutoSize = true;
            this.radioIngreso.Location = new System.Drawing.Point(22, 44);
            this.radioIngreso.Name = "radioIngreso";
            this.radioIngreso.Size = new System.Drawing.Size(116, 30);
            this.radioIngreso.TabIndex = 8;
            this.radioIngreso.Text = "Ingreso";
            this.radioIngreso.UseVisualStyleBackColor = true;
            this.radioIngreso.CheckedChanged += new System.EventHandler(this.radioIngreso_CheckedChanged);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(298, 320);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(176, 32);
            this.txtImporte.TabIndex = 2;
            // 
            // txtNumeroOpraciones
            // 
            this.txtNumeroOpraciones.Location = new System.Drawing.Point(298, 253);
            this.txtNumeroOpraciones.Name = "txtNumeroOpraciones";
            this.txtNumeroOpraciones.Size = new System.Drawing.Size(176, 32);
            this.txtNumeroOpraciones.TabIndex = 0;
            // 
            // grpTrasferencias
            // 
            this.grpTrasferencias.Controls.Add(this.lblNDestino);
            this.grpTrasferencias.Controls.Add(this.txtNDestino);
            this.grpTrasferencias.Controls.Add(this.lblImporteTrasf);
            this.grpTrasferencias.Controls.Add(this.lblNOrigen);
            this.grpTrasferencias.Controls.Add(this.brnTrasferir);
            this.grpTrasferencias.Controls.Add(this.txtImporteTrasf);
            this.grpTrasferencias.Controls.Add(this.txtNOrigen);
            this.grpTrasferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTrasferencias.Location = new System.Drawing.Point(31, 98);
            this.grpTrasferencias.Name = "grpTrasferencias";
            this.grpTrasferencias.Size = new System.Drawing.Size(764, 608);
            this.grpTrasferencias.TabIndex = 23;
            this.grpTrasferencias.TabStop = false;
            this.grpTrasferencias.Text = "Trasferencias";
            this.grpTrasferencias.Visible = false;
            // 
            // lblImporteTrasf
            // 
            this.lblImporteTrasf.AutoSize = true;
            this.lblImporteTrasf.Location = new System.Drawing.Point(204, 324);
            this.lblImporteTrasf.Name = "lblImporteTrasf";
            this.lblImporteTrasf.Size = new System.Drawing.Size(93, 26);
            this.lblImporteTrasf.TabIndex = 14;
            this.lblImporteTrasf.Text = "Importe";
            // 
            // lblNOrigen
            // 
            this.lblNOrigen.AutoSize = true;
            this.lblNOrigen.Location = new System.Drawing.Point(50, 192);
            this.lblNOrigen.Name = "lblNOrigen";
            this.lblNOrigen.Size = new System.Drawing.Size(257, 26);
            this.lblNOrigen.TabIndex = 11;
            this.lblNOrigen.Text = "Numero Cuenta Origen";
            // 
            // brnTrasferir
            // 
            this.brnTrasferir.Location = new System.Drawing.Point(282, 408);
            this.brnTrasferir.Name = "brnTrasferir";
            this.brnTrasferir.Size = new System.Drawing.Size(134, 50);
            this.brnTrasferir.TabIndex = 10;
            this.brnTrasferir.Text = "Trasferir";
            this.brnTrasferir.UseVisualStyleBackColor = true;
            this.brnTrasferir.Click += new System.EventHandler(this.brnTrasferir_Click);
            // 
            // txtImporteTrasf
            // 
            this.txtImporteTrasf.Location = new System.Drawing.Point(362, 324);
            this.txtImporteTrasf.Name = "txtImporteTrasf";
            this.txtImporteTrasf.Size = new System.Drawing.Size(176, 32);
            this.txtImporteTrasf.TabIndex = 2;
            // 
            // txtNOrigen
            // 
            this.txtNOrigen.Location = new System.Drawing.Point(362, 189);
            this.txtNOrigen.Name = "txtNOrigen";
            this.txtNOrigen.Size = new System.Drawing.Size(176, 32);
            this.txtNOrigen.TabIndex = 0;
            // 
            // lblNDestino
            // 
            this.lblNDestino.AutoSize = true;
            this.lblNDestino.Location = new System.Drawing.Point(40, 260);
            this.lblNDestino.Name = "lblNDestino";
            this.lblNDestino.Size = new System.Drawing.Size(267, 26);
            this.lblNDestino.TabIndex = 16;
            this.lblNDestino.Text = "Numero Cuenta Destino";
            // 
            // txtNDestino
            // 
            this.txtNDestino.Location = new System.Drawing.Point(362, 257);
            this.txtNDestino.Name = "txtNDestino";
            this.txtNDestino.Size = new System.Drawing.Size(176, 32);
            this.txtNDestino.TabIndex = 15;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 752);
            this.Controls.Add(this.grpBoxConsultas);
            this.Controls.Add(this.grpOperaciones);
            this.Controls.Add(this.grpBoxAltas);
            this.Controls.Add(this.grpTrasferencias);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.grpBoxAltas.ResumeLayout(false);
            this.grpBoxAltas.PerformLayout();
            this.grpBoxTipo.ResumeLayout(false);
            this.grpBoxTipo.PerformLayout();
            this.grpBoxConsultas.ResumeLayout(false);
            this.grpBoxConsultas.PerformLayout();
            this.grpTipoBusqueda.ResumeLayout(false);
            this.grpTipoBusqueda.PerformLayout();
            this.grpOperaciones.ResumeLayout(false);
            this.grpOperaciones.PerformLayout();
            this.grpIngresoReintegro.ResumeLayout(false);
            this.grpIngresoReintegro.PerformLayout();
            this.grpTrasferencias.ResumeLayout(false);
            this.grpTrasferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porDNIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reintegroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trasferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entreCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBoxAltas;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtNCuenta;
        private System.Windows.Forms.TextBox txtTopeCredito;
        private System.Windows.Forms.TextBox txtMesesCredito;
        private System.Windows.Forms.Label lblNCuentaAltas;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox grpBoxTipo;
        private System.Windows.Forms.RadioButton radioBtnEmpresa;
        private System.Windows.Forms.RadioButton radioBtnPersonal;
        private System.Windows.Forms.Label lblTopeCredito;
        private System.Windows.Forms.Label lblMesesCredito;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblCuentaEmpresa;
        private System.Windows.Forms.GroupBox grpBoxConsultas;
        private System.Windows.Forms.Label lblDNIBuscar;
        private System.Windows.Forms.Label lblNumeroBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpTipoBusqueda;
        private System.Windows.Forms.RadioButton radioDNI;
        private System.Windows.Forms.RadioButton radioNumero;
        private System.Windows.Forms.TextBox txtDNIBuscar;
        private System.Windows.Forms.TextBox txtNumeroBuscar;
        private System.Windows.Forms.GroupBox grpOperaciones;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblNumeroOperaciones;
        private System.Windows.Forms.Button btnIngresarSacar;
        private System.Windows.Forms.GroupBox grpIngresoReintegro;
        private System.Windows.Forms.RadioButton radioReintegro;
        private System.Windows.Forms.RadioButton radioIngreso;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtNumeroOpraciones;
        private System.Windows.Forms.GroupBox grpTrasferencias;
        private System.Windows.Forms.Label lblImporteTrasf;
        private System.Windows.Forms.Label lblNOrigen;
        private System.Windows.Forms.Button brnTrasferir;
        private System.Windows.Forms.TextBox txtImporteTrasf;
        private System.Windows.Forms.TextBox txtNOrigen;
        private System.Windows.Forms.Label lblNDestino;
        private System.Windows.Forms.TextBox txtNDestino;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

