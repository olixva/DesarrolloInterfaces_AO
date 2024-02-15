namespace hoja3EjerciciosC_
{
    partial class Ordenacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordenacion));
            this.imgVolver = new System.Windows.Forms.PictureBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lblOrdenado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // imgVolver
            // 
            this.imgVolver.Image = ((System.Drawing.Image)(resources.GetObject("imgVolver.Image")));
            this.imgVolver.Location = new System.Drawing.Point(12, 12);
            this.imgVolver.Name = "imgVolver";
            this.imgVolver.Size = new System.Drawing.Size(104, 57);
            this.imgVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVolver.TabIndex = 15;
            this.imgVolver.TabStop = false;
            this.imgVolver.Click += new System.EventHandler(this.imgVolver_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(298, 161);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(139, 57);
            this.btnOrdenar.TabIndex = 16;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lblOrdenado
            // 
            this.lblOrdenado.AutoSize = true;
            this.lblOrdenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenado.ForeColor = System.Drawing.Color.Green;
            this.lblOrdenado.Location = new System.Drawing.Point(198, 260);
            this.lblOrdenado.Name = "lblOrdenado";
            this.lblOrdenado.Size = new System.Drawing.Size(326, 26);
            this.lblOrdenado.TabIndex = 17;
            this.lblOrdenado.Text = "Alumnos ordenados con exito";
            this.lblOrdenado.Visible = false;
            // 
            // Ordenacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOrdenado);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.imgVolver);
            this.Name = "Ordenacion";
            this.Text = "Ordenacion";
            ((System.ComponentModel.ISupportInitialize)(this.imgVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgVolver;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lblOrdenado;
    }
}