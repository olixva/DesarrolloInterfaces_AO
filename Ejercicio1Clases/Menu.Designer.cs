namespace Ejercicio1Clases
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
            this.articulosStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AltasCosultasBox = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grpBoxRadio = new System.Windows.Forms.GroupBox();
            this.radioCodigo = new System.Windows.Forms.RadioButton();
            this.radioNombre = new System.Windows.Forms.RadioButton();
            this.cmboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblExistencias = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.ListarBox = new System.Windows.Forms.GroupBox();
            this.txtBoxListar = new System.Windows.Forms.RichTextBox();
            this.cmboBoxCategoriaListar = new System.Windows.Forms.ComboBox();
            this.lblCategoriaListar = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.PedidosBox = new System.Windows.Forms.GroupBox();
            this.lblIDpedido = new System.Windows.Forms.Label();
            this.txtIDPedido = new System.Windows.Forms.TextBox();
            this.lblCantidadPedido = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnPedir = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.AltasCosultasBox.SuspendLayout();
            this.grpBoxRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.ListarBox.SuspendLayout();
            this.PedidosBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosStripMenuItem,
            this.consultasToolStripMenuItem,
            this.lisToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(847, 36);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // articulosStripMenuItem
            // 
            this.articulosStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.articulosStripMenuItem.Name = "articulosStripMenuItem";
            this.articulosStripMenuItem.Size = new System.Drawing.Size(107, 32);
            this.articulosStripMenuItem.Text = "&Articulos";
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(296, 36);
            this.altasToolStripMenuItem.Text = "&Altas";
            this.altasToolStripMenuItem.Click += new System.EventHandler(this.altasToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(296, 36);
            this.pedidosToolStripMenuItem.Text = "&Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(293, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(296, 36);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNombreToolStripMenuItem,
            this.porCodigoToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(114, 32);
            this.consultasToolStripMenuItem.Text = "&Consultas";
            // 
            // porNombreToolStripMenuItem
            // 
            this.porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            this.porNombreToolStripMenuItem.Size = new System.Drawing.Size(229, 36);
            this.porNombreToolStripMenuItem.Text = "Por &Nombre";
            this.porNombreToolStripMenuItem.Click += new System.EventHandler(this.porNombreToolStripMenuItem_Click);
            // 
            // porCodigoToolStripMenuItem
            // 
            this.porCodigoToolStripMenuItem.Name = "porCodigoToolStripMenuItem";
            this.porCodigoToolStripMenuItem.Size = new System.Drawing.Size(229, 36);
            this.porCodigoToolStripMenuItem.Text = "Por &Codigo";
            this.porCodigoToolStripMenuItem.Click += new System.EventHandler(this.porCodigoToolStripMenuItem_Click);
            // 
            // lisToolStripMenuItem
            // 
            this.lisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimosToolStripMenuItem,
            this.porCategoriaToolStripMenuItem,
            this.todosToolStripMenuItem});
            this.lisToolStripMenuItem.Name = "lisToolStripMenuItem";
            this.lisToolStripMenuItem.Size = new System.Drawing.Size(101, 32);
            this.lisToolStripMenuItem.Text = "&Listados";
            // 
            // minimosToolStripMenuItem
            // 
            this.minimosToolStripMenuItem.Name = "minimosToolStripMenuItem";
            this.minimosToolStripMenuItem.Size = new System.Drawing.Size(296, 36);
            this.minimosToolStripMenuItem.Text = "&Minimos";
            this.minimosToolStripMenuItem.Click += new System.EventHandler(this.minimosToolStripMenuItem_Click);
            // 
            // porCategoriaToolStripMenuItem
            // 
            this.porCategoriaToolStripMenuItem.Name = "porCategoriaToolStripMenuItem";
            this.porCategoriaToolStripMenuItem.Size = new System.Drawing.Size(296, 36);
            this.porCategoriaToolStripMenuItem.Text = "Por &Categoria";
            this.porCategoriaToolStripMenuItem.Click += new System.EventHandler(this.porCategoriaToolStripMenuItem_Click);
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(296, 36);
            this.todosToolStripMenuItem.Text = "&Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(115, 32);
            this.acercaDeToolStripMenuItem.Text = "Acerca &de";
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(296, 36);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // AltasCosultasBox
            // 
            this.AltasCosultasBox.Controls.Add(this.btnConsultar);
            this.AltasCosultasBox.Controls.Add(this.grpBoxRadio);
            this.AltasCosultasBox.Controls.Add(this.cmboBoxCategoria);
            this.AltasCosultasBox.Controls.Add(this.lblId);
            this.AltasCosultasBox.Controls.Add(this.txtId);
            this.AltasCosultasBox.Controls.Add(this.btnCrear);
            this.AltasCosultasBox.Controls.Add(this.lblExistencias);
            this.AltasCosultasBox.Controls.Add(this.lblPrecio);
            this.AltasCosultasBox.Controls.Add(this.lblCategoria);
            this.AltasCosultasBox.Controls.Add(this.lblNombre);
            this.AltasCosultasBox.Controls.Add(this.txtExistencias);
            this.AltasCosultasBox.Controls.Add(this.txtPrecio);
            this.AltasCosultasBox.Controls.Add(this.txtNombre);
            this.AltasCosultasBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltasCosultasBox.Location = new System.Drawing.Point(77, 71);
            this.AltasCosultasBox.Name = "AltasCosultasBox";
            this.AltasCosultasBox.Size = new System.Drawing.Size(743, 560);
            this.AltasCosultasBox.TabIndex = 1;
            this.AltasCosultasBox.TabStop = false;
            this.AltasCosultasBox.Text = "Altas";
            this.AltasCosultasBox.Visible = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(212, 471);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(154, 39);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // grpBoxRadio
            // 
            this.grpBoxRadio.Controls.Add(this.radioCodigo);
            this.grpBoxRadio.Controls.Add(this.radioNombre);
            this.grpBoxRadio.Location = new System.Drawing.Point(492, 395);
            this.grpBoxRadio.Name = "grpBoxRadio";
            this.grpBoxRadio.Size = new System.Drawing.Size(207, 105);
            this.grpBoxRadio.TabIndex = 12;
            this.grpBoxRadio.TabStop = false;
            this.grpBoxRadio.Text = "Seleccione:";
            this.grpBoxRadio.Visible = false;
            // 
            // radioCodigo
            // 
            this.radioCodigo.AutoSize = true;
            this.radioCodigo.Location = new System.Drawing.Point(6, 64);
            this.radioCodigo.Name = "radioCodigo";
            this.radioCodigo.Size = new System.Drawing.Size(156, 30);
            this.radioCodigo.TabIndex = 12;
            this.radioCodigo.TabStop = true;
            this.radioCodigo.Text = "Por Codigo";
            this.radioCodigo.UseVisualStyleBackColor = true;
            this.radioCodigo.CheckedChanged += new System.EventHandler(this.radioCodigo_CheckedChanged);
            // 
            // radioNombre
            // 
            this.radioNombre.AutoSize = true;
            this.radioNombre.Location = new System.Drawing.Point(6, 31);
            this.radioNombre.Name = "radioNombre";
            this.radioNombre.Size = new System.Drawing.Size(165, 30);
            this.radioNombre.TabIndex = 11;
            this.radioNombre.TabStop = true;
            this.radioNombre.Text = "Por Nombre";
            this.radioNombre.UseVisualStyleBackColor = true;
            this.radioNombre.CheckedChanged += new System.EventHandler(this.radioNombre_CheckedChanged);
            // 
            // cmboBoxCategoria
            // 
            this.cmboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBoxCategoria.FormattingEnabled = true;
            this.cmboBoxCategoria.Items.AddRange(new object[] {
            "Informática",
            "Imagen",
            "Telefonía",
            "Sonido"});
            this.cmboBoxCategoria.Location = new System.Drawing.Point(334, 206);
            this.cmboBoxCategoria.Name = "cmboBoxCategoria";
            this.cmboBoxCategoria.Size = new System.Drawing.Size(222, 34);
            this.cmboBoxCategoria.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(90, 98);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(124, 26);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "ID Articulo";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(334, 95);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(222, 32);
            this.txtId.TabIndex = 9;
            this.txtId.TabStop = false;
            this.txtId.Text = "1";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(212, 426);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(154, 39);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblExistencias
            // 
            this.lblExistencias.AutoSize = true;
            this.lblExistencias.Location = new System.Drawing.Point(90, 319);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(222, 26);
            this.lblExistencias.TabIndex = 7;
            this.lblExistencias.Text = "Existencias Articulo";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(90, 262);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(168, 26);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio Articulo";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(90, 209);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(203, 26);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria Articulo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(90, 151);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(184, 26);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre Articulo";
            // 
            // txtExistencias
            // 
            this.txtExistencias.Location = new System.Drawing.Point(334, 316);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(222, 32);
            this.txtExistencias.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(334, 259);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(222, 32);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(334, 148);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 32);
            this.txtNombre.TabIndex = 0;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // ListarBox
            // 
            this.ListarBox.Controls.Add(this.btnListar);
            this.ListarBox.Controls.Add(this.lblCategoriaListar);
            this.ListarBox.Controls.Add(this.cmboBoxCategoriaListar);
            this.ListarBox.Controls.Add(this.txtBoxListar);
            this.ListarBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListarBox.Location = new System.Drawing.Point(86, 56);
            this.ListarBox.Name = "ListarBox";
            this.ListarBox.Size = new System.Drawing.Size(645, 560);
            this.ListarBox.TabIndex = 2;
            this.ListarBox.TabStop = false;
            this.ListarBox.Text = "Listar";
            this.ListarBox.Visible = false;
            // 
            // txtBoxListar
            // 
            this.txtBoxListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxListar.Location = new System.Drawing.Point(45, 148);
            this.txtBoxListar.Name = "txtBoxListar";
            this.txtBoxListar.Size = new System.Drawing.Size(537, 257);
            this.txtBoxListar.TabIndex = 0;
            this.txtBoxListar.Text = "";
            // 
            // cmboBoxCategoriaListar
            // 
            this.cmboBoxCategoriaListar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBoxCategoriaListar.FormattingEnabled = true;
            this.cmboBoxCategoriaListar.Items.AddRange(new object[] {
            "Informática",
            "Imagen",
            "Telefonía",
            "Sonido"});
            this.cmboBoxCategoriaListar.Location = new System.Drawing.Point(304, 73);
            this.cmboBoxCategoriaListar.Name = "cmboBoxCategoriaListar";
            this.cmboBoxCategoriaListar.Size = new System.Drawing.Size(152, 34);
            this.cmboBoxCategoriaListar.TabIndex = 1;
            this.cmboBoxCategoriaListar.Visible = false;
            // 
            // lblCategoriaListar
            // 
            this.lblCategoriaListar.AutoSize = true;
            this.lblCategoriaListar.Location = new System.Drawing.Point(162, 76);
            this.lblCategoriaListar.Name = "lblCategoriaListar";
            this.lblCategoriaListar.Size = new System.Drawing.Size(122, 26);
            this.lblCategoriaListar.TabIndex = 2;
            this.lblCategoriaListar.Text = "Categoria:";
            this.lblCategoriaListar.Visible = false;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(249, 438);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(123, 39);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // PedidosBox
            // 
            this.PedidosBox.Controls.Add(this.btnPedir);
            this.PedidosBox.Controls.Add(this.lblCantidadPedido);
            this.PedidosBox.Controls.Add(this.txtCantidad);
            this.PedidosBox.Controls.Add(this.lblIDpedido);
            this.PedidosBox.Controls.Add(this.txtIDPedido);
            this.PedidosBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PedidosBox.Location = new System.Drawing.Point(64, 71);
            this.PedidosBox.Name = "PedidosBox";
            this.PedidosBox.Size = new System.Drawing.Size(580, 525);
            this.PedidosBox.TabIndex = 3;
            this.PedidosBox.TabStop = false;
            this.PedidosBox.Text = "Pedidos";
            this.PedidosBox.Visible = false;
            // 
            // lblIDpedido
            // 
            this.lblIDpedido.AutoSize = true;
            this.lblIDpedido.Location = new System.Drawing.Point(57, 162);
            this.lblIDpedido.Name = "lblIDpedido";
            this.lblIDpedido.Size = new System.Drawing.Size(124, 26);
            this.lblIDpedido.TabIndex = 12;
            this.lblIDpedido.Text = "ID Articulo";
            // 
            // txtIDPedido
            // 
            this.txtIDPedido.Location = new System.Drawing.Point(301, 159);
            this.txtIDPedido.Name = "txtIDPedido";
            this.txtIDPedido.Size = new System.Drawing.Size(222, 32);
            this.txtIDPedido.TabIndex = 11;
            this.txtIDPedido.TabStop = false;
            // 
            // lblCantidadPedido
            // 
            this.lblCantidadPedido.AutoSize = true;
            this.lblCantidadPedido.Location = new System.Drawing.Point(57, 258);
            this.lblCantidadPedido.Name = "lblCantidadPedido";
            this.lblCantidadPedido.Size = new System.Drawing.Size(185, 26);
            this.lblCantidadPedido.TabIndex = 14;
            this.lblCantidadPedido.Text = "Cantidad pedido";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(301, 255);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(222, 32);
            this.txtCantidad.TabIndex = 13;
            // 
            // btnPedir
            // 
            this.btnPedir.Location = new System.Drawing.Point(213, 372);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(154, 39);
            this.btnPedir.TabIndex = 14;
            this.btnPedir.Text = "Pedir";
            this.btnPedir.UseVisualStyleBackColor = true;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 689);
            this.Controls.Add(this.PedidosBox);
            this.Controls.Add(this.ListarBox);
            this.Controls.Add(this.AltasCosultasBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.AltasCosultasBox.ResumeLayout(false);
            this.AltasCosultasBox.PerformLayout();
            this.grpBoxRadio.ResumeLayout(false);
            this.grpBoxRadio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ListarBox.ResumeLayout(false);
            this.ListarBox.PerformLayout();
            this.PedidosBox.ResumeLayout(false);
            this.PedidosBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem articulosStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCodigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.GroupBox AltasCosultasBox;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblExistencias;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox cmboBoxCategoria;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.RadioButton radioNombre;
        private System.Windows.Forms.GroupBox grpBoxRadio;
        private System.Windows.Forms.RadioButton radioCodigo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox ListarBox;
        private System.Windows.Forms.RichTextBox txtBoxListar;
        private System.Windows.Forms.Label lblCategoriaListar;
        private System.Windows.Forms.ComboBox cmboBoxCategoriaListar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox PedidosBox;
        private System.Windows.Forms.Button btnPedir;
        private System.Windows.Forms.Label lblCantidadPedido;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblIDpedido;
        private System.Windows.Forms.TextBox txtIDPedido;
    }
}

