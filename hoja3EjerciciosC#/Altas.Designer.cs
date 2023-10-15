namespace hoja3EjerciciosC_
{
    partial class Altas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Altas));
            this.lblCrear = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelef = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblNotifi = new System.Windows.Forms.Label();
            this.errorAlta = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAluCreados = new System.Windows.Forms.Label();
            this.imgVolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCrear
            // 
            this.lblCrear.AutoSize = true;
            this.lblCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrear.Location = new System.Drawing.Point(267, 35);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(207, 31);
            this.lblCrear.TabIndex = 0;
            this.lblCrear.Text = "Crear Alumnos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(244, 113);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(96, 26);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(245, 159);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(96, 26);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblTelef
            // 
            this.lblTelef.AutoSize = true;
            this.lblTelef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelef.Location = new System.Drawing.Point(244, 210);
            this.lblTelef.Name = "lblTelef";
            this.lblTelef.Size = new System.Drawing.Size(101, 26);
            this.lblTelef.TabIndex = 3;
            this.lblTelef.Text = "Telefono:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(244, 256);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 26);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(245, 305);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(76, 26);
            this.lblCurso.TabIndex = 5;
            this.lblCurso.Text = "Curso:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(362, 111);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 28);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(362, 157);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(156, 28);
            this.txtApellido.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(362, 208);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(156, 28);
            this.txtTelefono.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(362, 254);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(282, 28);
            this.txtEmail.TabIndex = 9;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(362, 303);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(112, 28);
            this.txtCurso.TabIndex = 10;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(318, 367);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(99, 49);
            this.btnCrear.TabIndex = 11;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblNotifi
            // 
            this.lblNotifi.AutoSize = true;
            this.lblNotifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifi.ForeColor = System.Drawing.Color.Green;
            this.lblNotifi.Location = new System.Drawing.Point(203, 439);
            this.lblNotifi.Name = "lblNotifi";
            this.lblNotifi.Size = new System.Drawing.Size(331, 26);
            this.lblNotifi.TabIndex = 12;
            this.lblNotifi.Text = "Alumno creado correctamente";
            this.lblNotifi.Visible = false;
            // 
            // errorAlta
            // 
            this.errorAlta.ContainerControl = this;
            // 
            // lblAluCreados
            // 
            this.lblAluCreados.AutoSize = true;
            this.lblAluCreados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluCreados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAluCreados.Location = new System.Drawing.Point(558, 40);
            this.lblAluCreados.Name = "lblAluCreados";
            this.lblAluCreados.Size = new System.Drawing.Size(216, 26);
            this.lblAluCreados.TabIndex = 13;
            this.lblAluCreados.Text = "Alumnos creados x/3";
            this.lblAluCreados.Visible = false;
            // 
            // imgVolver
            // 
            this.imgVolver.Image = ((System.Drawing.Image)(resources.GetObject("imgVolver.Image")));
            this.imgVolver.Location = new System.Drawing.Point(12, 12);
            this.imgVolver.Name = "imgVolver";
            this.imgVolver.Size = new System.Drawing.Size(104, 57);
            this.imgVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVolver.TabIndex = 14;
            this.imgVolver.TabStop = false;
            this.imgVolver.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Altas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 495);
            this.Controls.Add(this.imgVolver);
            this.Controls.Add(this.lblAluCreados);
            this.Controls.Add(this.lblNotifi);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelef);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCrear);
            this.Name = "Altas";
            this.Text = "Altas";
            ((System.ComponentModel.ISupportInitialize)(this.errorAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCrear;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelef;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblNotifi;
        private System.Windows.Forms.ErrorProvider errorAlta;
        private System.Windows.Forms.Label lblAluCreados;
        private System.Windows.Forms.PictureBox imgVolver;
    }
}