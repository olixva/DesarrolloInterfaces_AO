namespace Hoja1Ejercicios
{
    partial class FrmArea
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArea));
            rbtnCuadrado = new RadioButton();
            grpBoxSelec = new GroupBox();
            btnCalcular = new Button();
            txtAltura = new TextBox();
            txtBase = new TextBox();
            rbtnTriangulo = new RadioButton();
            rbtnRectangulo = new RadioButton();
            lblBase = new Label();
            lblAltura = new Label();
            lblError = new Label();
            lblResultado = new Label();
            imgVolver = new PictureBox();
            grpBoxSelec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgVolver).BeginInit();
            SuspendLayout();
            // 
            // rbtnCuadrado
            // 
            rbtnCuadrado.AutoSize = true;
            rbtnCuadrado.Location = new Point(22, 59);
            rbtnCuadrado.Name = "rbtnCuadrado";
            rbtnCuadrado.Size = new Size(123, 32);
            rbtnCuadrado.TabIndex = 0;
            rbtnCuadrado.TabStop = true;
            rbtnCuadrado.Text = "Cuadrado";
            rbtnCuadrado.UseVisualStyleBackColor = true;
            // 
            // grpBoxSelec
            // 
            grpBoxSelec.Controls.Add(btnCalcular);
            grpBoxSelec.Controls.Add(txtAltura);
            grpBoxSelec.Controls.Add(txtBase);
            grpBoxSelec.Controls.Add(rbtnTriangulo);
            grpBoxSelec.Controls.Add(rbtnRectangulo);
            grpBoxSelec.Controls.Add(rbtnCuadrado);
            grpBoxSelec.Location = new Point(160, 55);
            grpBoxSelec.Name = "grpBoxSelec";
            grpBoxSelec.Size = new Size(363, 258);
            grpBoxSelec.TabIndex = 1;
            grpBoxSelec.TabStop = false;
            grpBoxSelec.Text = "Selecciona figura para calcular su Area";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(234, 198);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(123, 38);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(210, 141);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(165, 34);
            txtAltura.TabIndex = 4;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(210, 87);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(165, 34);
            txtBase.TabIndex = 3;
            // 
            // rbtnTriangulo
            // 
            rbtnTriangulo.AutoSize = true;
            rbtnTriangulo.Location = new Point(22, 186);
            rbtnTriangulo.Name = "rbtnTriangulo";
            rbtnTriangulo.Size = new Size(107, 32);
            rbtnTriangulo.TabIndex = 2;
            rbtnTriangulo.TabStop = true;
            rbtnTriangulo.Text = "Trianglo";
            rbtnTriangulo.UseVisualStyleBackColor = true;
            // 
            // rbtnRectangulo
            // 
            rbtnRectangulo.AutoSize = true;
            rbtnRectangulo.Location = new Point(22, 122);
            rbtnRectangulo.Name = "rbtnRectangulo";
            rbtnRectangulo.Size = new Size(135, 32);
            rbtnRectangulo.TabIndex = 1;
            rbtnRectangulo.TabStop = true;
            rbtnRectangulo.Text = "Rectangulo";
            rbtnRectangulo.UseVisualStyleBackColor = true;
            // 
            // lblBase
            // 
            lblBase.AutoSize = true;
            lblBase.Location = new Point(557, 148);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(51, 28);
            lblBase.TabIndex = 2;
            lblBase.Text = "Base";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(557, 202);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(65, 28);
            lblAltura.TabIndex = 3;
            lblAltura.Text = "Altura";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(370, 316);
            lblError.Name = "lblError";
            lblError.Size = new Size(168, 60);
            lblError.TabIndex = 8;
            lblError.Text = "ERROR";
            lblError.Visible = false;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.SpringGreen;
            lblResultado.Location = new Point(203, 316);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(45, 60);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "x";
            lblResultado.Visible = false;
            // 
            // imgVolver
            // 
            imgVolver.Image = (Image)resources.GetObject("imgVolver.Image");
            imgVolver.Location = new Point(12, 12);
            imgVolver.Name = "imgVolver";
            imgVolver.Size = new Size(100, 100);
            imgVolver.SizeMode = PictureBoxSizeMode.StretchImage;
            imgVolver.TabIndex = 17;
            imgVolver.TabStop = false;
            imgVolver.Click += imgVolver_Click;
            // 
            // FrmArea
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(imgVolver);
            Controls.Add(lblResultado);
            Controls.Add(lblError);
            Controls.Add(lblAltura);
            Controls.Add(lblBase);
            Controls.Add(grpBoxSelec);
            Name = "FrmArea";
            Text = "Area";
            grpBoxSelec.ResumeLayout(false);
            grpBoxSelec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbtnCuadrado;
        private GroupBox grpBoxSelec;
        private RadioButton rbtnTriangulo;
        private RadioButton rbtnRectangulo;
        private TextBox txtAltura;
        private TextBox txtBase;
        private Label lblBase;
        private Label lblAltura;
        private Label lblError;
        private Button btnCalcular;
        private Label lblResultado;
        private PictureBox imgVolver;
    }
}