namespace hoja2EjerciciosC_
{
    partial class Ejercicio1
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
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.btnOrdCacl = new System.Windows.Forms.Button();
            this.txtIntroNum = new System.Windows.Forms.TextBox();
            this.lblIntroNum = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblEsPrimo = new System.Windows.Forms.Label();
            this.lblNPrimo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxNumeros
            // 
            this.listBoxNumeros.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBoxNumeros.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.listBoxNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNumeros.FormattingEnabled = true;
            this.listBoxNumeros.ItemHeight = 38;
            this.listBoxNumeros.Location = new System.Drawing.Point(428, 95);
            this.listBoxNumeros.Name = "listBoxNumeros";
            this.listBoxNumeros.Size = new System.Drawing.Size(120, 498);
            this.listBoxNumeros.TabIndex = 0;
            // 
            // btnOrdCacl
            // 
            this.btnOrdCacl.Enabled = false;
            this.btnOrdCacl.Location = new System.Drawing.Point(106, 212);
            this.btnOrdCacl.Name = "btnOrdCacl";
            this.btnOrdCacl.Size = new System.Drawing.Size(173, 61);
            this.btnOrdCacl.TabIndex = 1;
            this.btnOrdCacl.Text = "Ordenar y Calcular";
            this.btnOrdCacl.UseVisualStyleBackColor = true;
            this.btnOrdCacl.Click += new System.EventHandler(this.btnOrdCacl_Click);
            // 
            // txtIntroNum
            // 
            this.txtIntroNum.Location = new System.Drawing.Point(148, 158);
            this.txtIntroNum.Name = "txtIntroNum";
            this.txtIntroNum.Size = new System.Drawing.Size(100, 28);
            this.txtIntroNum.TabIndex = 2;
            this.txtIntroNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeros_KeyDown);
            // 
            // lblIntroNum
            // 
            this.lblIntroNum.AutoSize = true;
            this.lblIntroNum.Location = new System.Drawing.Point(82, 116);
            this.lblIntroNum.Name = "lblIntroNum";
            this.lblIntroNum.Size = new System.Drawing.Size(251, 22);
            this.lblIntroNum.TabIndex = 3;
            this.lblIntroNum.Text = "Introduce los numeros (Enter):";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Enabled = false;
            this.txtBuscar.Location = new System.Drawing.Point(742, 158);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 28);
            this.txtBuscar.TabIndex = 4;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(678, 116);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(228, 22);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "Introduce numero a buscar:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(742, 212);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 61);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Calcular";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblEsPrimo
            // 
            this.lblEsPrimo.AutoSize = true;
            this.lblEsPrimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsPrimo.Location = new System.Drawing.Point(79, 513);
            this.lblEsPrimo.Name = "lblEsPrimo";
            this.lblEsPrimo.Size = new System.Drawing.Size(154, 38);
            this.lblEsPrimo.TabIndex = 7;
            this.lblEsPrimo.Text = "es Primo";
            this.lblEsPrimo.Visible = false;
            // 
            // lblNPrimo
            // 
            this.lblNPrimo.AutoSize = true;
            this.lblNPrimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNPrimo.Location = new System.Drawing.Point(28, 513);
            this.lblNPrimo.Name = "lblNPrimo";
            this.lblNPrimo.Size = new System.Drawing.Size(35, 38);
            this.lblNPrimo.TabIndex = 8;
            this.lblNPrimo.Text = "x";
            this.lblNPrimo.Visible = false;
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1010, 648);
            this.Controls.Add(this.lblNPrimo);
            this.Controls.Add(this.lblEsPrimo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblIntroNum);
            this.Controls.Add(this.txtIntroNum);
            this.Controls.Add(this.btnOrdCacl);
            this.Controls.Add(this.listBoxNumeros);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNumeros;
        private System.Windows.Forms.Button btnOrdCacl;
        private System.Windows.Forms.TextBox txtIntroNum;
        private System.Windows.Forms.Label lblIntroNum;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblEsPrimo;
        private System.Windows.Forms.Label lblNPrimo;
    }
}

