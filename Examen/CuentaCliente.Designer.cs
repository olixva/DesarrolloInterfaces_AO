namespace Examen
{
    partial class CuentaCliente
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
            this.menuStripCuenta = new System.Windows.Forms.MenuStrip();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reintegroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCambiarClave = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblClaveNueva2 = new System.Windows.Forms.Label();
            this.lblClaveNueva1 = new System.Windows.Forms.Label();
            this.lblClaveAntigua = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnValidarActual = new System.Windows.Forms.Button();
            this.txtPassNueva2 = new System.Windows.Forms.TextBox();
            this.txtPassNueva1 = new System.Windows.Forms.TextBox();
            this.txtPassActual = new System.Windows.Forms.TextBox();
            this.checkClaves = new System.Windows.Forms.CheckBox();
            this.menuStripCuenta.SuspendLayout();
            this.grpCambiarClave.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripCuenta
            // 
            this.menuStripCuenta.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripCuenta.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.menuStripCuenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem,
            this.cambiarClaveToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStripCuenta.Location = new System.Drawing.Point(0, 0);
            this.menuStripCuenta.Name = "menuStripCuenta";
            this.menuStripCuenta.Size = new System.Drawing.Size(802, 36);
            this.menuStripCuenta.TabIndex = 0;
            this.menuStripCuenta.Text = "menuStrip1";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reintegroToolStripMenuItem,
            this.ingresoToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(139, 32);
            this.operacionesToolStripMenuItem.Text = "&Operaciones";
            // 
            // reintegroToolStripMenuItem
            // 
            this.reintegroToolStripMenuItem.Name = "reintegroToolStripMenuItem";
            this.reintegroToolStripMenuItem.Size = new System.Drawing.Size(207, 36);
            this.reintegroToolStripMenuItem.Text = "&Reintegro";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(207, 36);
            this.ingresoToolStripMenuItem.Text = "&Ingreso";
            // 
            // cambiarClaveToolStripMenuItem
            // 
            this.cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            this.cambiarClaveToolStripMenuItem.Size = new System.Drawing.Size(152, 32);
            this.cambiarClaveToolStripMenuItem.Text = "&Cambiar clave";
            this.cambiarClaveToolStripMenuItem.Click += new System.EventHandler(this.cambiarClaveToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(68, 32);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // grpCambiarClave
            // 
            this.grpCambiarClave.Controls.Add(this.btnCancelar);
            this.grpCambiarClave.Controls.Add(this.lblClaveNueva2);
            this.grpCambiarClave.Controls.Add(this.lblClaveNueva1);
            this.grpCambiarClave.Controls.Add(this.lblClaveAntigua);
            this.grpCambiarClave.Controls.Add(this.btnCambiar);
            this.grpCambiarClave.Controls.Add(this.btnValidarActual);
            this.grpCambiarClave.Controls.Add(this.txtPassNueva2);
            this.grpCambiarClave.Controls.Add(this.txtPassNueva1);
            this.grpCambiarClave.Controls.Add(this.txtPassActual);
            this.grpCambiarClave.Controls.Add(this.checkClaves);
            this.grpCambiarClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCambiarClave.Location = new System.Drawing.Point(35, 65);
            this.grpCambiarClave.Name = "grpCambiarClave";
            this.grpCambiarClave.Size = new System.Drawing.Size(694, 569);
            this.grpCambiarClave.TabIndex = 1;
            this.grpCambiarClave.TabStop = false;
            this.grpCambiarClave.Text = "Cambiar clave";
            this.grpCambiarClave.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(519, 46);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 46);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblClaveNueva2
            // 
            this.lblClaveNueva2.AutoSize = true;
            this.lblClaveNueva2.Location = new System.Drawing.Point(42, 288);
            this.lblClaveNueva2.Name = "lblClaveNueva2";
            this.lblClaveNueva2.Size = new System.Drawing.Size(92, 26);
            this.lblClaveNueva2.TabIndex = 8;
            this.lblClaveNueva2.Text = "Repitela";
            // 
            // lblClaveNueva1
            // 
            this.lblClaveNueva1.AutoSize = true;
            this.lblClaveNueva1.Location = new System.Drawing.Point(42, 229);
            this.lblClaveNueva1.Name = "lblClaveNueva1";
            this.lblClaveNueva1.Size = new System.Drawing.Size(137, 26);
            this.lblClaveNueva1.TabIndex = 7;
            this.lblClaveNueva1.Text = "Clave Nueva";
            // 
            // lblClaveAntigua
            // 
            this.lblClaveAntigua.AutoSize = true;
            this.lblClaveAntigua.Location = new System.Drawing.Point(42, 169);
            this.lblClaveAntigua.Name = "lblClaveAntigua";
            this.lblClaveAntigua.Size = new System.Drawing.Size(148, 26);
            this.lblClaveAntigua.TabIndex = 6;
            this.lblClaveAntigua.Text = "Clave Antigua";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Enabled = false;
            this.btnCambiar.Location = new System.Drawing.Point(233, 457);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(145, 46);
            this.btnCambiar.TabIndex = 5;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnValidarActual
            // 
            this.btnValidarActual.Location = new System.Drawing.Point(233, 385);
            this.btnValidarActual.Name = "btnValidarActual";
            this.btnValidarActual.Size = new System.Drawing.Size(145, 46);
            this.btnValidarActual.TabIndex = 4;
            this.btnValidarActual.Text = "Validar";
            this.btnValidarActual.UseVisualStyleBackColor = true;
            this.btnValidarActual.Click += new System.EventHandler(this.btnValidarActual_Click);
            // 
            // txtPassNueva2
            // 
            this.txtPassNueva2.Enabled = false;
            this.txtPassNueva2.Location = new System.Drawing.Point(248, 285);
            this.txtPassNueva2.Name = "txtPassNueva2";
            this.txtPassNueva2.Size = new System.Drawing.Size(159, 32);
            this.txtPassNueva2.TabIndex = 3;
            this.txtPassNueva2.UseSystemPasswordChar = true;
            // 
            // txtPassNueva1
            // 
            this.txtPassNueva1.Enabled = false;
            this.txtPassNueva1.Location = new System.Drawing.Point(248, 226);
            this.txtPassNueva1.Name = "txtPassNueva1";
            this.txtPassNueva1.Size = new System.Drawing.Size(159, 32);
            this.txtPassNueva1.TabIndex = 2;
            this.txtPassNueva1.UseSystemPasswordChar = true;
            // 
            // txtPassActual
            // 
            this.txtPassActual.Location = new System.Drawing.Point(248, 166);
            this.txtPassActual.Name = "txtPassActual";
            this.txtPassActual.Size = new System.Drawing.Size(159, 32);
            this.txtPassActual.TabIndex = 1;
            this.txtPassActual.UseSystemPasswordChar = true;
            // 
            // checkClaves
            // 
            this.checkClaves.AutoSize = true;
            this.checkClaves.Location = new System.Drawing.Point(470, 225);
            this.checkClaves.Name = "checkClaves";
            this.checkClaves.Size = new System.Drawing.Size(179, 30);
            this.checkClaves.TabIndex = 0;
            this.checkClaves.Text = "Mostrar claves";
            this.checkClaves.UseVisualStyleBackColor = true;
            this.checkClaves.CheckedChanged += new System.EventHandler(this.checkClaves_CheckedChanged);
            // 
            // CuentaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 700);
            this.Controls.Add(this.grpCambiarClave);
            this.Controls.Add(this.menuStripCuenta);
            this.MainMenuStrip = this.menuStripCuenta;
            this.Name = "CuentaCliente";
            this.Text = "CuentaCliente";
            this.menuStripCuenta.ResumeLayout(false);
            this.menuStripCuenta.PerformLayout();
            this.grpCambiarClave.ResumeLayout(false);
            this.grpCambiarClave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripCuenta;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reintegroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarClaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpCambiarClave;
        private System.Windows.Forms.CheckBox checkClaves;
        private System.Windows.Forms.TextBox txtPassNueva2;
        private System.Windows.Forms.TextBox txtPassNueva1;
        private System.Windows.Forms.TextBox txtPassActual;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button btnValidarActual;
        private System.Windows.Forms.Label lblClaveNueva2;
        private System.Windows.Forms.Label lblClaveNueva1;
        private System.Windows.Forms.Label lblClaveAntigua;
        private System.Windows.Forms.Button btnCancelar;
    }
}