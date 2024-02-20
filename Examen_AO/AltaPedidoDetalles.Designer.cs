namespace Examen_AO
{
    partial class AltaPedidoDetalles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodPed = new System.Windows.Forms.Label();
            this.txtCodPed = new System.Windows.Forms.TextBox();
            this.txtCodClie = new System.Windows.Forms.TextBox();
            this.lblCodClie = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpDetallesPedido = new System.Windows.Forms.GroupBox();
            this.txtCantProd = new System.Windows.Forms.TextBox();
            this.lblCantidadPro = new System.Windows.Forms.Label();
            this.txtCodPro = new System.Windows.Forms.TextBox();
            this.lblCodPro = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.grpDetallesPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodPed
            // 
            this.lblCodPed.AutoSize = true;
            this.lblCodPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPed.Location = new System.Drawing.Point(37, 68);
            this.lblCodPed.Name = "lblCodPed";
            this.lblCodPed.Size = new System.Drawing.Size(139, 25);
            this.lblCodPed.TabIndex = 0;
            this.lblCodPed.Text = "Codigo pedido";
            // 
            // txtCodPed
            // 
            this.txtCodPed.Enabled = false;
            this.txtCodPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPed.Location = new System.Drawing.Point(191, 65);
            this.txtCodPed.Name = "txtCodPed";
            this.txtCodPed.Size = new System.Drawing.Size(156, 30);
            this.txtCodPed.TabIndex = 2;
            // 
            // txtCodClie
            // 
            this.txtCodClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodClie.Location = new System.Drawing.Point(191, 140);
            this.txtCodClie.Name = "txtCodClie";
            this.txtCodClie.Size = new System.Drawing.Size(156, 30);
            this.txtCodClie.TabIndex = 4;
            this.txtCodClie.TextChanged += new System.EventHandler(this.txtCodClie_TextChanged);
            // 
            // lblCodClie
            // 
            this.lblCodClie.AutoSize = true;
            this.lblCodClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodClie.Location = new System.Drawing.Point(37, 140);
            this.lblCodClie.Name = "lblCodClie";
            this.lblCodClie.Size = new System.Drawing.Size(136, 25);
            this.lblCodClie.TabIndex = 3;
            this.lblCodClie.Text = "Codigo cliente";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(478, 65);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(67, 25);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(578, 62);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(156, 30);
            this.txtFecha.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(467, 152);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 37);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(635, 152);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 37);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grpDetallesPedido
            // 
            this.grpDetallesPedido.Controls.Add(this.btnTerminar);
            this.grpDetallesPedido.Controls.Add(this.btnAgregar);
            this.grpDetallesPedido.Controls.Add(this.txtCantProd);
            this.grpDetallesPedido.Controls.Add(this.txtCodPro);
            this.grpDetallesPedido.Controls.Add(this.lblCantidadPro);
            this.grpDetallesPedido.Controls.Add(this.lblCodPro);
            this.grpDetallesPedido.Enabled = false;
            this.grpDetallesPedido.Location = new System.Drawing.Point(191, 227);
            this.grpDetallesPedido.Name = "grpDetallesPedido";
            this.grpDetallesPedido.Size = new System.Drawing.Size(477, 227);
            this.grpDetallesPedido.TabIndex = 9;
            this.grpDetallesPedido.TabStop = false;
            this.grpDetallesPedido.Text = "Detalles Pedido";
            // 
            // txtCantProd
            // 
            this.txtCantProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantProd.Location = new System.Drawing.Point(207, 110);
            this.txtCantProd.Name = "txtCantProd";
            this.txtCantProd.Size = new System.Drawing.Size(156, 30);
            this.txtCantProd.TabIndex = 13;
            this.txtCantProd.TextChanged += new System.EventHandler(this.txtCantProd_TextChanged);
            // 
            // lblCantidadPro
            // 
            this.lblCantidadPro.AutoSize = true;
            this.lblCantidadPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPro.Location = new System.Drawing.Point(30, 110);
            this.lblCantidadPro.Name = "lblCantidadPro";
            this.lblCantidadPro.Size = new System.Drawing.Size(172, 25);
            this.lblCantidadPro.TabIndex = 12;
            this.lblCantidadPro.Text = "Cantidad producto";
            // 
            // txtCodPro
            // 
            this.txtCodPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPro.Location = new System.Drawing.Point(207, 59);
            this.txtCodPro.Name = "txtCodPro";
            this.txtCodPro.Size = new System.Drawing.Size(156, 30);
            this.txtCodPro.TabIndex = 11;
            this.txtCodPro.TextChanged += new System.EventHandler(this.txtCodPro_TextChanged);
            // 
            // lblCodPro
            // 
            this.lblCodPro.AutoSize = true;
            this.lblCodPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPro.Location = new System.Drawing.Point(30, 62);
            this.lblCodPro.Name = "lblCodPro";
            this.lblCodPro.Size = new System.Drawing.Size(156, 25);
            this.lblCodPro.TabIndex = 10;
            this.lblCodPro.Text = "Codigo producto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(398, 59);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(60, 56);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(311, 175);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(108, 35);
            this.btnTerminar.TabIndex = 15;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // AltaPedidoDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.grpDetallesPedido);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtCodClie);
            this.Controls.Add(this.lblCodClie);
            this.Controls.Add(this.txtCodPed);
            this.Controls.Add(this.lblCodPed);
            this.Name = "AltaPedidoDetalles";
            this.Text = "AltaPedidoDetalles";
            this.Load += new System.EventHandler(this.AltaPedidoDetalles_Load);
            this.grpDetallesPedido.ResumeLayout(false);
            this.grpDetallesPedido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodPed;
        private System.Windows.Forms.TextBox txtCodPed;
        private System.Windows.Forms.TextBox txtCodClie;
        private System.Windows.Forms.Label lblCodClie;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grpDetallesPedido;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantProd;
        private System.Windows.Forms.TextBox txtCodPro;
        private System.Windows.Forms.Label lblCantidadPro;
        private System.Windows.Forms.Label lblCodPro;
    }
}