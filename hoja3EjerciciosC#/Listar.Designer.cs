namespace hoja3EjerciciosC_
{
    partial class Listar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listar));
            this.imgVolver = new System.Windows.Forms.PictureBox();
            this.lblUsuarios = new System.Windows.Forms.Label();
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
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(19, 191);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(97, 25);
            this.lblUsuarios.TabIndex = 16;
            this.lblUsuarios.Text = "Usuarios";
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.imgVolver);
            this.Name = "Listar";
            this.Text = "Listar";
            ((System.ComponentModel.ISupportInitialize)(this.imgVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgVolver;
        private System.Windows.Forms.Label lblUsuarios;
    }
}