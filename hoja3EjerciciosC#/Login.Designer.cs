namespace hoja3EjerciciosC_
{
    partial class Login
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblIntroduzca = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.errorLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(360, 180);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(138, 28);
            this.txtUser.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(229, 183);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(82, 22);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Usuario: ";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(229, 241);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(113, 22);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Contraseña: ";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(360, 238);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(138, 28);
            this.txtPass.TabIndex = 2;
            // 
            // lblIntroduzca
            // 
            this.lblIntroduzca.AutoSize = true;
            this.lblIntroduzca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroduzca.ForeColor = System.Drawing.Color.Coral;
            this.lblIntroduzca.Location = new System.Drawing.Point(115, 92);
            this.lblIntroduzca.Name = "lblIntroduzca";
            this.lblIntroduzca.Size = new System.Drawing.Size(520, 31);
            this.lblIntroduzca.TabIndex = 4;
            this.lblIntroduzca.Text = "Introduzca sus credenciales de acceso";
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(317, 316);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(100, 34);
            this.btnAcceder.TabIndex = 5;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // errorLogin
            // 
            this.errorLogin.ContainerControl = this;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(171, 375);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(384, 29);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Usuario o contraseña incorrectos";
            this.lblError.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.lblIntroduzca);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUser);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblIntroduzca;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.ErrorProvider errorLogin;
        private System.Windows.Forms.Label lblError;
    }
}

