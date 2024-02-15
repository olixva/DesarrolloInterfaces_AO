namespace ADONetExample
{
    partial class Navegacion
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
            this.btnGoAdd = new System.Windows.Forms.Button();
            this.btnGoToFillOrCancell = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGoToAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGoAdd
            // 
            this.btnGoAdd.Location = new System.Drawing.Point(196, 167);
            this.btnGoAdd.Name = "btnGoAdd";
            this.btnGoAdd.Size = new System.Drawing.Size(216, 52);
            this.btnGoAdd.TabIndex = 0;
            this.btnGoAdd.Text = "Agregar una cuenta";
            this.btnGoAdd.UseVisualStyleBackColor = true;
            this.btnGoAdd.Click += new System.EventHandler(this.btnGoAdd_Click);
            // 
            // btnGoToFillOrCancell
            // 
            this.btnGoToFillOrCancell.Location = new System.Drawing.Point(146, 249);
            this.btnGoToFillOrCancell.Name = "btnGoToFillOrCancell";
            this.btnGoToFillOrCancell.Size = new System.Drawing.Size(310, 52);
            this.btnGoToFillOrCancell.TabIndex = 1;
            this.btnGoToFillOrCancell.Text = "Rellenar o cancelar un pedido";
            this.btnGoToFillOrCancell.UseVisualStyleBackColor = true;
            this.btnGoToFillOrCancell.Click += new System.EventHandler(this.btnGoToFillOrCancell_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(503, 373);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 48);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGoToAdd
            // 
            this.btnGoToAdd.AutoSize = true;
            this.btnGoToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToAdd.Location = new System.Drawing.Point(206, 104);
            this.btnGoToAdd.Name = "btnGoToAdd";
            this.btnGoToAdd.Size = new System.Drawing.Size(206, 26);
            this.btnGoToAdd.TabIndex = 3;
            this.btnGoToAdd.Text = "Que desea hacer?";
            // 
            // Navegacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.btnGoToAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoToFillOrCancell);
            this.Controls.Add(this.btnGoAdd);
            this.Name = "Navegacion";
            this.Text = "Navegacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoAdd;
        private System.Windows.Forms.Button btnGoToFillOrCancell;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label btnGoToAdd;
    }
}

