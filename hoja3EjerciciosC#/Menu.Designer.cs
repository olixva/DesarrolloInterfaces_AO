namespace hoja3EjerciciosC_
{
    partial class Menu
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
            this.lblAltas = new System.Windows.Forms.Label();
            this.lblConsultas = new System.Windows.Forms.Label();
            this.lblListar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAltas
            // 
            this.lblAltas.AutoSize = true;
            this.lblAltas.Location = new System.Drawing.Point(318, 82);
            this.lblAltas.Name = "lblAltas";
            this.lblAltas.Size = new System.Drawing.Size(70, 22);
            this.lblAltas.TabIndex = 0;
            this.lblAltas.Text = "1. Altas";
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Location = new System.Drawing.Point(318, 120);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(110, 22);
            this.lblConsultas.TabIndex = 1;
            this.lblConsultas.Text = "2. Consultas";
            // 
            // lblListar
            // 
            this.lblListar.AutoSize = true;
            this.lblListar.Location = new System.Drawing.Point(318, 159);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(74, 22);
            this.lblListar.TabIndex = 2;
            this.lblListar.Text = "3. Listar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "1. Altas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "1. Altas";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblListar);
            this.Controls.Add(this.lblConsultas);
            this.Controls.Add(this.lblAltas);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltas;
        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.Label lblListar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}