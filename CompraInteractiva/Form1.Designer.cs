namespace CompraInteractiva
{
    partial class Form1
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
            this.grpBoxEquipo = new System.Windows.Forms.GroupBox();
            this.grpBoxOficina = new System.Windows.Forms.GroupBox();
            this.listBoxPerifericos = new System.Windows.Forms.ListBox();
            this.cmboBoxMetodoPago = new System.Windows.Forms.ComboBox();
            this.lblPerifericos = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnPresupuesto = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.radioPc = new System.Windows.Forms.RadioButton();
            this.radioMacintosh = new System.Windows.Forms.RadioButton();
            this.radioPortatil = new System.Windows.Forms.RadioButton();
            this.checkContestador = new System.Windows.Forms.CheckBox();
            this.checkCalculadora = new System.Windows.Forms.CheckBox();
            this.checkFotoCopiadora = new System.Windows.Forms.CheckBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureFotoCopiadora = new System.Windows.Forms.PictureBox();
            this.picturePago = new System.Windows.Forms.PictureBox();
            this.pictureCalculadora = new System.Windows.Forms.PictureBox();
            this.picturePeriferico = new System.Windows.Forms.PictureBox();
            this.pictureContestador = new System.Windows.Forms.PictureBox();
            this.pictureEquipo = new System.Windows.Forms.PictureBox();
            this.grpBoxEquipo.SuspendLayout();
            this.grpBoxOficina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFotoCopiadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCalculadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePeriferico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContestador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxEquipo
            // 
            this.grpBoxEquipo.Controls.Add(this.radioPortatil);
            this.grpBoxEquipo.Controls.Add(this.radioMacintosh);
            this.grpBoxEquipo.Controls.Add(this.radioPc);
            this.grpBoxEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxEquipo.Location = new System.Drawing.Point(55, 220);
            this.grpBoxEquipo.Name = "grpBoxEquipo";
            this.grpBoxEquipo.Size = new System.Drawing.Size(301, 226);
            this.grpBoxEquipo.TabIndex = 0;
            this.grpBoxEquipo.TabStop = false;
            this.grpBoxEquipo.Text = "Equipo (necesario)";
            // 
            // grpBoxOficina
            // 
            this.grpBoxOficina.Controls.Add(this.checkFotoCopiadora);
            this.grpBoxOficina.Controls.Add(this.checkCalculadora);
            this.grpBoxOficina.Controls.Add(this.checkContestador);
            this.grpBoxOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxOficina.Location = new System.Drawing.Point(55, 493);
            this.grpBoxOficina.Name = "grpBoxOficina";
            this.grpBoxOficina.Size = new System.Drawing.Size(301, 243);
            this.grpBoxOficina.TabIndex = 1;
            this.grpBoxOficina.TabStop = false;
            this.grpBoxOficina.Text = "Equipo de oficina (0-3)";
            // 
            // listBoxPerifericos
            // 
            this.listBoxPerifericos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPerifericos.FormattingEnabled = true;
            this.listBoxPerifericos.ItemHeight = 25;
            this.listBoxPerifericos.Location = new System.Drawing.Point(424, 267);
            this.listBoxPerifericos.Name = "listBoxPerifericos";
            this.listBoxPerifericos.Size = new System.Drawing.Size(291, 154);
            this.listBoxPerifericos.TabIndex = 2;
            // 
            // cmboBoxMetodoPago
            // 
            this.cmboBoxMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBoxMetodoPago.FormattingEnabled = true;
            this.cmboBoxMetodoPago.Location = new System.Drawing.Point(424, 474);
            this.cmboBoxMetodoPago.Name = "cmboBoxMetodoPago";
            this.cmboBoxMetodoPago.Size = new System.Drawing.Size(162, 34);
            this.cmboBoxMetodoPago.TabIndex = 3;
            // 
            // lblPerifericos
            // 
            this.lblPerifericos.AutoSize = true;
            this.lblPerifericos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerifericos.Location = new System.Drawing.Point(457, 233);
            this.lblPerifericos.Name = "lblPerifericos";
            this.lblPerifericos.Size = new System.Drawing.Size(222, 25);
            this.lblPerifericos.TabIndex = 4;
            this.lblPerifericos.Text = "Perifericos (Solo uno)";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(63, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(391, 48);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Compra Interactiva";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(66, 118);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(561, 50);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Actualice su oficina comprando los productos que necesite con \r\ncasillas de verif" +
    "icacion, botones de opcion y cuadros de lista.";
            // 
            // btnPresupuesto
            // 
            this.btnPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresupuesto.Location = new System.Drawing.Point(421, 570);
            this.btnPresupuesto.Name = "btnPresupuesto";
            this.btnPresupuesto.Size = new System.Drawing.Size(165, 67);
            this.btnPresupuesto.TabIndex = 7;
            this.btnPresupuesto.Text = "Presupuesto";
            this.btnPresupuesto.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(424, 665);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(165, 67);
            this.btSalir.TabIndex = 8;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // radioPc
            // 
            this.radioPc.AutoSize = true;
            this.radioPc.Location = new System.Drawing.Point(16, 61);
            this.radioPc.Name = "radioPc";
            this.radioPc.Size = new System.Drawing.Size(137, 29);
            this.radioPc.TabIndex = 0;
            this.radioPc.Text = "PC (700$)";
            this.radioPc.UseVisualStyleBackColor = true;
            this.radioPc.CheckedChanged += new System.EventHandler(this.radioPc_CheckedChanged);
            // 
            // radioMacintosh
            // 
            this.radioMacintosh.AutoSize = true;
            this.radioMacintosh.Location = new System.Drawing.Point(16, 116);
            this.radioMacintosh.Name = "radioMacintosh";
            this.radioMacintosh.Size = new System.Drawing.Size(218, 29);
            this.radioMacintosh.TabIndex = 1;
            this.radioMacintosh.Text = "Macintosh (1000$)";
            this.radioMacintosh.UseVisualStyleBackColor = true;
            this.radioMacintosh.CheckedChanged += new System.EventHandler(this.radioMacintosh_CheckedChanged);
            // 
            // radioPortatil
            // 
            this.radioPortatil.AutoSize = true;
            this.radioPortatil.Location = new System.Drawing.Point(16, 172);
            this.radioPortatil.Name = "radioPortatil";
            this.radioPortatil.Size = new System.Drawing.Size(174, 29);
            this.radioPortatil.TabIndex = 2;
            this.radioPortatil.Text = "Portatil (500$)";
            this.radioPortatil.UseVisualStyleBackColor = true;
            this.radioPortatil.CheckedChanged += new System.EventHandler(this.radioPortatil_CheckedChanged);
            // 
            // checkContestador
            // 
            this.checkContestador.AutoSize = true;
            this.checkContestador.Location = new System.Drawing.Point(16, 58);
            this.checkContestador.Name = "checkContestador";
            this.checkContestador.Size = new System.Drawing.Size(214, 29);
            this.checkContestador.TabIndex = 0;
            this.checkContestador.Text = "Contestador (50$)";
            this.checkContestador.UseVisualStyleBackColor = true;
            this.checkContestador.CheckedChanged += new System.EventHandler(this.checkContestador_CheckedChanged);
            // 
            // checkCalculadora
            // 
            this.checkCalculadora.AutoSize = true;
            this.checkCalculadora.Location = new System.Drawing.Point(16, 115);
            this.checkCalculadora.Name = "checkCalculadora";
            this.checkCalculadora.Size = new System.Drawing.Size(212, 29);
            this.checkCalculadora.TabIndex = 1;
            this.checkCalculadora.Text = "Calculadora (20$)";
            this.checkCalculadora.UseVisualStyleBackColor = true;
            this.checkCalculadora.CheckedChanged += new System.EventHandler(this.checkCalculadora_CheckedChanged);
            // 
            // checkFotoCopiadora
            // 
            this.checkFotoCopiadora.AutoSize = true;
            this.checkFotoCopiadora.Location = new System.Drawing.Point(16, 172);
            this.checkFotoCopiadora.Name = "checkFotoCopiadora";
            this.checkFotoCopiadora.Size = new System.Drawing.Size(246, 29);
            this.checkFotoCopiadora.TabIndex = 2;
            this.checkFotoCopiadora.Text = "Fotocopiadora (100$)";
            this.checkFotoCopiadora.UseVisualStyleBackColor = true;
            this.checkFotoCopiadora.CheckedChanged += new System.EventHandler(this.checkFotoCopiadora_CheckedChanged);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(832, 120);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(382, 48);
            this.lblProductos.TabIndex = 9;
            this.lblProductos.Text = "Productos pedidos";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureFotoCopiadora
            // 
            this.pictureFotoCopiadora.Location = new System.Drawing.Point(1048, 642);
            this.pictureFotoCopiadora.Name = "pictureFotoCopiadora";
            this.pictureFotoCopiadora.Size = new System.Drawing.Size(166, 174);
            this.pictureFotoCopiadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFotoCopiadora.TabIndex = 15;
            this.pictureFotoCopiadora.TabStop = false;
            // 
            // picturePago
            // 
            this.picturePago.Location = new System.Drawing.Point(799, 642);
            this.picturePago.Name = "picturePago";
            this.picturePago.Size = new System.Drawing.Size(166, 174);
            this.picturePago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePago.TabIndex = 14;
            this.picturePago.TabStop = false;
            // 
            // pictureCalculadora
            // 
            this.pictureCalculadora.Location = new System.Drawing.Point(1048, 435);
            this.pictureCalculadora.Name = "pictureCalculadora";
            this.pictureCalculadora.Size = new System.Drawing.Size(166, 174);
            this.pictureCalculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCalculadora.TabIndex = 13;
            this.pictureCalculadora.TabStop = false;
            // 
            // picturePeriferico
            // 
            this.picturePeriferico.Location = new System.Drawing.Point(799, 435);
            this.picturePeriferico.Name = "picturePeriferico";
            this.picturePeriferico.Size = new System.Drawing.Size(166, 174);
            this.picturePeriferico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePeriferico.TabIndex = 12;
            this.picturePeriferico.TabStop = false;
            // 
            // pictureContestador
            // 
            this.pictureContestador.Location = new System.Drawing.Point(1048, 220);
            this.pictureContestador.Name = "pictureContestador";
            this.pictureContestador.Size = new System.Drawing.Size(166, 174);
            this.pictureContestador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureContestador.TabIndex = 11;
            this.pictureContestador.TabStop = false;
            // 
            // pictureEquipo
            // 
            this.pictureEquipo.Location = new System.Drawing.Point(799, 220);
            this.pictureEquipo.Name = "pictureEquipo";
            this.pictureEquipo.Size = new System.Drawing.Size(166, 174);
            this.pictureEquipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureEquipo.TabIndex = 10;
            this.pictureEquipo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 875);
            this.Controls.Add(this.pictureFotoCopiadora);
            this.Controls.Add(this.picturePago);
            this.Controls.Add(this.pictureCalculadora);
            this.Controls.Add(this.picturePeriferico);
            this.Controls.Add(this.pictureContestador);
            this.Controls.Add(this.pictureEquipo);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btnPresupuesto);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPerifericos);
            this.Controls.Add(this.cmboBoxMetodoPago);
            this.Controls.Add(this.listBoxPerifericos);
            this.Controls.Add(this.grpBoxOficina);
            this.Controls.Add(this.grpBoxEquipo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxEquipo.ResumeLayout(false);
            this.grpBoxEquipo.PerformLayout();
            this.grpBoxOficina.ResumeLayout(false);
            this.grpBoxOficina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFotoCopiadora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCalculadora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePeriferico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContestador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxEquipo;
        private System.Windows.Forms.GroupBox grpBoxOficina;
        private System.Windows.Forms.ListBox listBoxPerifericos;
        private System.Windows.Forms.ComboBox cmboBoxMetodoPago;
        private System.Windows.Forms.Label lblPerifericos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnPresupuesto;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.RadioButton radioPortatil;
        private System.Windows.Forms.RadioButton radioMacintosh;
        private System.Windows.Forms.RadioButton radioPc;
        private System.Windows.Forms.CheckBox checkFotoCopiadora;
        private System.Windows.Forms.CheckBox checkCalculadora;
        private System.Windows.Forms.CheckBox checkContestador;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureEquipo;
        private System.Windows.Forms.PictureBox pictureContestador;
        private System.Windows.Forms.PictureBox picturePeriferico;
        private System.Windows.Forms.PictureBox pictureCalculadora;
        private System.Windows.Forms.PictureBox picturePago;
        private System.Windows.Forms.PictureBox pictureFotoCopiadora;
    }
}

