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
            lblResArea = new Label();
            imgVolver = new PictureBox();
            lblArea = new Label();
            lblPerimetro = new Label();
            lblResPerimetro = new Label();
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
            // lblResArea
            // 
            lblResArea.AutoSize = true;
            lblResArea.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblResArea.ForeColor = Color.SpringGreen;
            lblResArea.Location = new Point(142, 331);
            lblResArea.Name = "lblResArea";
            lblResArea.Size = new Size(35, 45);
            lblResArea.TabIndex = 9;
            lblResArea.Text = "x";
            lblResArea.Visible = false;
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
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(75, 341);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(61, 28);
            lblArea.TabIndex = 18;
            lblArea.Text = "Area: ";
            // 
            // lblPerimetro
            // 
            lblPerimetro.AutoSize = true;
            lblPerimetro.Location = new Point(75, 394);
            lblPerimetro.Name = "lblPerimetro";
            lblPerimetro.Size = new Size(106, 28);
            lblPerimetro.TabIndex = 20;
            lblPerimetro.Text = "Perimetro: ";
            // 
            // lblResPerimetro
            // 
            lblResPerimetro.AutoSize = true;
            lblResPerimetro.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblResPerimetro.ForeColor = Color.SpringGreen;
            lblResPerimetro.Location = new Point(187, 381);
            lblResPerimetro.Name = "lblResPerimetro";
            lblResPerimetro.Size = new Size(35, 45);
            lblResPerimetro.TabIndex = 19;
            lblResPerimetro.Text = "x";
            lblResPerimetro.Visible = false;
            // 
            // FrmArea
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPerimetro);
            Controls.Add(lblResPerimetro);
            Controls.Add(lblArea);
            Controls.Add(imgVolver);
            Controls.Add(lblResArea);
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
        private Label lblResArea;
        private PictureBox imgVolver;
        private Label lblArea;
        private Label lblPerimetro;
        private Label lblResPerimetro;
    }
}