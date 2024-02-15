namespace Ejercicio1ArchivosTexto
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
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarAgenndaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarAgendaPorInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAltas = new System.Windows.Forms.GroupBox();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombreConsulta = new System.Windows.Forms.TextBox();
            this.lblNombreConsulta = new System.Windows.Forms.Label();
            this.grpGuardar = new System.Windows.Forms.GroupBox();
            this.txtBoxGuardar = new System.Windows.Forms.RichTextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpGuardarInicial = new System.Windows.Forms.GroupBox();
            this.lblInicial = new System.Windows.Forms.Label();
            this.txtInicial = new System.Windows.Forms.TextBox();
            this.txtBoxGuardarInicial = new System.Windows.Forms.RichTextBox();
            this.btnAbrirInicial = new System.Windows.Forms.Button();
            this.btnGuardarInicial = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogInicial = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogInicial = new System.Windows.Forms.SaveFileDialog();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBorrar = new System.Windows.Forms.GroupBox();
            this.lblNombreBorrar = new System.Windows.Forms.Label();
            this.txtNombreBorrar = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.listBoxBorrar = new System.Windows.Forms.ListBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.grpAltas.SuspendLayout();
            this.grpConsulta.SuspendLayout();
            this.grpGuardar.SuspendLayout();
            this.grpGuardarInicial.SuspendLayout();
            this.grpBorrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.202532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(478, 34);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(68, 32);
            this.altasToolStripMenuItem.Text = "&Altas";
            this.altasToolStripMenuItem.Click += new System.EventHandler(this.altasToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(99, 32);
            this.consultaToolStripMenuItem.Text = "&Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarAgenndaToolStripMenuItem,
            this.guardarAgendaPorInicialToolStripMenuItem});
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(135, 32);
            this.guardarToolStripMenuItem.Text = "&Guardar/Leer";
            // 
            // guardarAgenndaToolStripMenuItem
            // 
            this.guardarAgenndaToolStripMenuItem.Name = "guardarAgenndaToolStripMenuItem";
            this.guardarAgenndaToolStripMenuItem.Size = new System.Drawing.Size(373, 36);
            this.guardarAgenndaToolStripMenuItem.Text = "Guardar/Leer &Agenda";
            this.guardarAgenndaToolStripMenuItem.Click += new System.EventHandler(this.guardarAgendaToolStripMenuItem_Click);
            // 
            // guardarAgendaPorInicialToolStripMenuItem
            // 
            this.guardarAgendaPorInicialToolStripMenuItem.Name = "guardarAgendaPorInicialToolStripMenuItem";
            this.guardarAgendaPorInicialToolStripMenuItem.Size = new System.Drawing.Size(373, 36);
            this.guardarAgendaPorInicialToolStripMenuItem.Text = "Guardar/Leer Agenda por &Inicial";
            this.guardarAgendaPorInicialToolStripMenuItem.Click += new System.EventHandler(this.guardarAgendaPorInicialToolStripMenuItem_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(181, 56);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(193, 32);
            this.txtID.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(181, 122);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(193, 32);
            this.txtNombre.TabIndex = 2;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(181, 194);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(193, 32);
            this.txtTelefono.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(48, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(34, 26);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(48, 126);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 26);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(48, 196);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(95, 26);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(151, 286);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(105, 40);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // grpAltas
            // 
            this.grpAltas.Controls.Add(this.txtTelefono);
            this.grpAltas.Controls.Add(this.btnCrear);
            this.grpAltas.Controls.Add(this.txtID);
            this.grpAltas.Controls.Add(this.lblTelefono);
            this.grpAltas.Controls.Add(this.txtNombre);
            this.grpAltas.Controls.Add(this.lblNombre);
            this.grpAltas.Controls.Add(this.lblID);
            this.grpAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.202532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAltas.Location = new System.Drawing.Point(37, 55);
            this.grpAltas.Name = "grpAltas";
            this.grpAltas.Size = new System.Drawing.Size(428, 344);
            this.grpAltas.TabIndex = 8;
            this.grpAltas.TabStop = false;
            this.grpAltas.Text = "Altas";
            this.grpAltas.Visible = false;
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.btnBuscar);
            this.grpConsulta.Controls.Add(this.txtNombreConsulta);
            this.grpConsulta.Controls.Add(this.lblNombreConsulta);
            this.grpConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.202532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsulta.Location = new System.Drawing.Point(31, 55);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(428, 344);
            this.grpConsulta.TabIndex = 9;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Consulta";
            this.grpConsulta.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(151, 286);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 40);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombreConsulta
            // 
            this.txtNombreConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreConsulta.Location = new System.Drawing.Point(176, 123);
            this.txtNombreConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreConsulta.Name = "txtNombreConsulta";
            this.txtNombreConsulta.Size = new System.Drawing.Size(193, 32);
            this.txtNombreConsulta.TabIndex = 2;
            // 
            // lblNombreConsulta
            // 
            this.lblNombreConsulta.AutoSize = true;
            this.lblNombreConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreConsulta.Location = new System.Drawing.Point(48, 126);
            this.lblNombreConsulta.Name = "lblNombreConsulta";
            this.lblNombreConsulta.Size = new System.Drawing.Size(90, 26);
            this.lblNombreConsulta.TabIndex = 5;
            this.lblNombreConsulta.Text = "Nombre";
            // 
            // grpGuardar
            // 
            this.grpGuardar.Controls.Add(this.txtBoxGuardar);
            this.grpGuardar.Controls.Add(this.btnAbrir);
            this.grpGuardar.Controls.Add(this.btnGuardar);
            this.grpGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.202532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGuardar.Location = new System.Drawing.Point(12, 81);
            this.grpGuardar.Name = "grpGuardar";
            this.grpGuardar.Size = new System.Drawing.Size(428, 397);
            this.grpGuardar.TabIndex = 10;
            this.grpGuardar.TabStop = false;
            this.grpGuardar.Text = "Guardar/Leer Agenda";
            this.grpGuardar.Visible = false;
            // 
            // txtBoxGuardar
            // 
            this.txtBoxGuardar.Location = new System.Drawing.Point(33, 36);
            this.txtBoxGuardar.Name = "txtBoxGuardar";
            this.txtBoxGuardar.Size = new System.Drawing.Size(370, 266);
            this.txtBoxGuardar.TabIndex = 10;
            this.txtBoxGuardar.Text = "";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(298, 332);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(105, 40);
            this.btnAbrir.TabIndex = 9;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(33, 332);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 40);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grpGuardarInicial
            // 
            this.grpGuardarInicial.Controls.Add(this.lblInicial);
            this.grpGuardarInicial.Controls.Add(this.txtInicial);
            this.grpGuardarInicial.Controls.Add(this.txtBoxGuardarInicial);
            this.grpGuardarInicial.Controls.Add(this.btnAbrirInicial);
            this.grpGuardarInicial.Controls.Add(this.btnGuardarInicial);
            this.grpGuardarInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.202532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGuardarInicial.Location = new System.Drawing.Point(25, 71);
            this.grpGuardarInicial.Name = "grpGuardarInicial";
            this.grpGuardarInicial.Size = new System.Drawing.Size(428, 407);
            this.grpGuardarInicial.TabIndex = 11;
            this.grpGuardarInicial.TabStop = false;
            this.grpGuardarInicial.Text = "Guardar/Leer Agenda por Inicial";
            this.grpGuardarInicial.Visible = false;
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.Location = new System.Drawing.Point(190, 332);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(55, 22);
            this.lblInicial.TabIndex = 12;
            this.lblInicial.Text = "Inicial";
            // 
            // txtInicial
            // 
            this.txtInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicial.Location = new System.Drawing.Point(182, 362);
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(63, 37);
            this.txtInicial.TabIndex = 11;
            this.txtInicial.TextChanged += new System.EventHandler(this.txtInicial_TextChanged);
            this.txtInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtBoxGuardarInicial
            // 
            this.txtBoxGuardarInicial.Location = new System.Drawing.Point(33, 36);
            this.txtBoxGuardarInicial.Name = "txtBoxGuardarInicial";
            this.txtBoxGuardarInicial.Size = new System.Drawing.Size(370, 266);
            this.txtBoxGuardarInicial.TabIndex = 10;
            this.txtBoxGuardarInicial.Text = "";
            // 
            // btnAbrirInicial
            // 
            this.btnAbrirInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirInicial.Location = new System.Drawing.Point(298, 332);
            this.btnAbrirInicial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAbrirInicial.Name = "btnAbrirInicial";
            this.btnAbrirInicial.Size = new System.Drawing.Size(105, 40);
            this.btnAbrirInicial.TabIndex = 9;
            this.btnAbrirInicial.Text = "Abrir";
            this.btnAbrirInicial.UseVisualStyleBackColor = true;
            this.btnAbrirInicial.Click += new System.EventHandler(this.btnAbrirInicial_Click);
            // 
            // btnGuardarInicial
            // 
            this.btnGuardarInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarInicial.Location = new System.Drawing.Point(33, 332);
            this.btnGuardarInicial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarInicial.Name = "btnGuardarInicial";
            this.btnGuardarInicial.Size = new System.Drawing.Size(105, 40);
            this.btnGuardarInicial.TabIndex = 8;
            this.btnGuardarInicial.Text = "Guardar";
            this.btnGuardarInicial.UseVisualStyleBackColor = true;
            this.btnGuardarInicial.Click += new System.EventHandler(this.btnGuardarInicial_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "Agenda";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // openFileDialogInicial
            // 
            this.openFileDialogInicial.FileName = "openFileDialog1";
            this.openFileDialogInicial.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogInicial_FileOk);
            // 
            // saveFileDialogInicial
            // 
            this.saveFileDialogInicial.DefaultExt = "txt";
            this.saveFileDialogInicial.FileName = "AgendaPorInicial";
            this.saveFileDialogInicial.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogInicial_FileOk);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(78, 32);
            this.borrarToolStripMenuItem.Text = "&Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // grpBorrar
            // 
            this.grpBorrar.Controls.Add(this.listBoxBorrar);
            this.grpBorrar.Controls.Add(this.lblNombreBorrar);
            this.grpBorrar.Controls.Add(this.txtNombreBorrar);
            this.grpBorrar.Controls.Add(this.btnBorrar);
            this.grpBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.202532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBorrar.Location = new System.Drawing.Point(12, 65);
            this.grpBorrar.Name = "grpBorrar";
            this.grpBorrar.Size = new System.Drawing.Size(428, 407);
            this.grpBorrar.TabIndex = 13;
            this.grpBorrar.TabStop = false;
            this.grpBorrar.Text = "Borrar";
            this.grpBorrar.Visible = false;
            // 
            // lblNombreBorrar
            // 
            this.lblNombreBorrar.AutoSize = true;
            this.lblNombreBorrar.Location = new System.Drawing.Point(40, 342);
            this.lblNombreBorrar.Name = "lblNombreBorrar";
            this.lblNombreBorrar.Size = new System.Drawing.Size(55, 22);
            this.lblNombreBorrar.TabIndex = 12;
            this.lblNombreBorrar.Text = "Inicial";
            // 
            // txtNombreBorrar
            // 
            this.txtNombreBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBorrar.Location = new System.Drawing.Point(128, 335);
            this.txtNombreBorrar.Name = "txtNombreBorrar";
            this.txtNombreBorrar.Size = new System.Drawing.Size(140, 37);
            this.txtNombreBorrar.TabIndex = 11;
            this.txtNombreBorrar.TextChanged += new System.EventHandler(this.txtNombreBorrar_TextChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(298, 332);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(105, 40);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // listBoxBorrar
            // 
            this.listBoxBorrar.FormattingEnabled = true;
            this.listBoxBorrar.ItemHeight = 22;
            this.listBoxBorrar.Location = new System.Drawing.Point(44, 46);
            this.listBoxBorrar.Name = "listBoxBorrar";
            this.listBoxBorrar.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxBorrar.Size = new System.Drawing.Size(359, 268);
            this.listBoxBorrar.TabIndex = 13;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 488);
            this.Controls.Add(this.grpBorrar);
            this.Controls.Add(this.grpGuardarInicial);
            this.Controls.Add(this.grpGuardar);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.grpAltas);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.grpAltas.ResumeLayout(false);
            this.grpAltas.PerformLayout();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            this.grpGuardar.ResumeLayout(false);
            this.grpGuardarInicial.ResumeLayout(false);
            this.grpGuardarInicial.PerformLayout();
            this.grpBorrar.ResumeLayout(false);
            this.grpBorrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarAgenndaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarAgendaPorInicialToolStripMenuItem;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombreConsulta;
        private System.Windows.Forms.Label lblNombreConsulta;
        private System.Windows.Forms.GroupBox grpAltas;
        private System.Windows.Forms.GroupBox grpGuardar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grpGuardarInicial;
        private System.Windows.Forms.RichTextBox txtBoxGuardarInicial;
        private System.Windows.Forms.Button btnAbrirInicial;
        private System.Windows.Forms.Button btnGuardarInicial;
        private System.Windows.Forms.RichTextBox txtBoxGuardar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialogInicial;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.TextBox txtInicial;
        private System.Windows.Forms.SaveFileDialog saveFileDialogInicial;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBorrar;
        private System.Windows.Forms.Label lblNombreBorrar;
        private System.Windows.Forms.TextBox txtNombreBorrar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListBox listBoxBorrar;
    }
}

