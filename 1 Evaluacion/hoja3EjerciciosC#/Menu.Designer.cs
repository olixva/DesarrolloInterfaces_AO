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
            this.lblOrdenacion = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAltas
            // 
            this.lblAltas.AutoSize = true;
            this.lblAltas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltas.Location = new System.Drawing.Point(284, 91);
            this.lblAltas.Name = "lblAltas";
            this.lblAltas.Size = new System.Drawing.Size(113, 31);
            this.lblAltas.TabIndex = 0;
            this.lblAltas.Text = "1. Altas";
            this.lblAltas.Click += new System.EventHandler(this.lblAltas_Click);
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultas.Location = new System.Drawing.Point(284, 154);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(178, 31);
            this.lblConsultas.TabIndex = 1;
            this.lblConsultas.Text = "2. Consultas";
            this.lblConsultas.Click += new System.EventHandler(this.lblConsultas_Click);
            // 
            // lblListar
            // 
            this.lblListar.AutoSize = true;
            this.lblListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListar.Location = new System.Drawing.Point(284, 217);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(120, 31);
            this.lblListar.TabIndex = 2;
            this.lblListar.Text = "3. Listar";
            this.lblListar.Click += new System.EventHandler(this.lblListar_Click);
            // 
            // lblOrdenacion
            // 
            this.lblOrdenacion.AutoSize = true;
            this.lblOrdenacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOrdenacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenacion.Location = new System.Drawing.Point(284, 278);
            this.lblOrdenacion.Name = "lblOrdenacion";
            this.lblOrdenacion.Size = new System.Drawing.Size(197, 31);
            this.lblOrdenacion.TabIndex = 3;
            this.lblOrdenacion.Text = "4. Ordenacion";
            this.lblOrdenacion.Click += new System.EventHandler(this.lblOrdenacion_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(284, 338);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(96, 31);
            this.lblExit.TabIndex = 4;
            this.lblExit.Text = "5. Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblOrdenacion);
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
        private System.Windows.Forms.Label lblOrdenacion;
        private System.Windows.Forms.Label lblExit;
    }
}