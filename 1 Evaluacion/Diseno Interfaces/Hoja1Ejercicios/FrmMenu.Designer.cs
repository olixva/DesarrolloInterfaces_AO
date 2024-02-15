namespace Hoja1Ejercicios
{
    partial class FrmMenu
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
            lblCalculadora = new Label();
            lblArea = new Label();
            lblFunciones = new Label();
            grbOpciones = new Panel();
            lblAdivinar = new Label();
            lblSalir = new Label();
            txtOpcion = new TextBox();
            btnAbrir = new Button();
            lblError = new Label();
            grbOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // lblCalculadora
            // 
            lblCalculadora.AutoSize = true;
            lblCalculadora.Location = new Point(17, 14);
            lblCalculadora.Name = "lblCalculadora";
            lblCalculadora.Size = new Size(135, 28);
            lblCalculadora.TabIndex = 0;
            lblCalculadora.Text = "1. Calculadora";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(17, 57);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(72, 28);
            lblArea.TabIndex = 1;
            lblArea.Text = "2. Area";
            // 
            // lblFunciones
            // 
            lblFunciones.AutoSize = true;
            lblFunciones.Location = new Point(17, 99);
            lblFunciones.Name = "lblFunciones";
            lblFunciones.Size = new Size(119, 28);
            lblFunciones.TabIndex = 2;
            lblFunciones.Text = "3. Funciones";
            // 
            // grbOpciones
            // 
            grbOpciones.Controls.Add(lblAdivinar);
            grbOpciones.Controls.Add(lblSalir);
            grbOpciones.Controls.Add(lblCalculadora);
            grbOpciones.Controls.Add(lblArea);
            grbOpciones.Controls.Add(lblFunciones);
            grbOpciones.Location = new Point(289, 25);
            grbOpciones.Name = "grbOpciones";
            grbOpciones.Size = new Size(165, 228);
            grbOpciones.TabIndex = 4;
            // 
            // lblAdivinar
            // 
            lblAdivinar.AutoSize = true;
            lblAdivinar.Location = new Point(17, 144);
            lblAdivinar.Name = "lblAdivinar";
            lblAdivinar.Size = new Size(105, 28);
            lblAdivinar.TabIndex = 8;
            lblAdivinar.Text = "4. Adivinar";
            // 
            // lblSalir
            // 
            lblSalir.AutoSize = true;
            lblSalir.Location = new Point(19, 186);
            lblSalir.Name = "lblSalir";
            lblSalir.Size = new Size(70, 28);
            lblSalir.TabIndex = 3;
            lblSalir.Text = "5. Salir";
            // 
            // txtOpcion
            // 
            txtOpcion.Location = new Point(289, 259);
            txtOpcion.Name = "txtOpcion";
            txtOpcion.Size = new Size(165, 34);
            txtOpcion.TabIndex = 5;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(306, 318);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(123, 38);
            btnAbrir.TabIndex = 6;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(153, 359);
            lblError.Name = "lblError";
            lblError.Size = new Size(443, 60);
            lblError.TabIndex = 7;
            lblError.Text = "OPCION NO VALIDA";
            lblError.Visible = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(btnAbrir);
            Controls.Add(txtOpcion);
            Controls.Add(grbOpciones);
            Name = "FrmMenu";
            Text = "Menu ";
            grbOpciones.ResumeLayout(false);
            grbOpciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCalculadora;
        private Label lblArea;
        private Label lblFunciones;
        private Panel grbOpciones;
        private TextBox txtOpcion;
        private Button btnAbrir;
        private Label lblError;
        private Label lblSalir;
        private Label lblAdivinar;
    }
}