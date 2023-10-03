namespace Hoja1Ejercicios
{
    partial class FrmFunciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFunciones));
            txtNum = new TextBox();
            lblIntroduce = new Label();
            btnCalcular = new Button();
            lblFactorial = new Label();
            lblFibonacci = new Label();
            lblResFac = new Label();
            lblResFibo = new Label();
            lblError = new Label();
            imgVolver = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgVolver).BeginInit();
            SuspendLayout();
            // 
            // txtNum
            // 
            txtNum.Location = new Point(299, 118);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(165, 34);
            txtNum.TabIndex = 4;
            // 
            // lblIntroduce
            // 
            lblIntroduce.AutoSize = true;
            lblIntroduce.Location = new Point(247, 67);
            lblIntroduce.Name = "lblIntroduce";
            lblIntroduce.Size = new Size(274, 28);
            lblIntroduce.TabIndex = 5;
            lblIntroduce.Text = "Introduce el numero a cacular:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(323, 186);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(123, 38);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblFactorial
            // 
            lblFactorial.AutoSize = true;
            lblFactorial.Location = new Point(58, 290);
            lblFactorial.Name = "lblFactorial";
            lblFactorial.Size = new Size(130, 28);
            lblFactorial.TabIndex = 11;
            lblFactorial.Text = "El factorial es:";
            // 
            // lblFibonacci
            // 
            lblFibonacci.AutoSize = true;
            lblFibonacci.Location = new Point(563, 290);
            lblFibonacci.Name = "lblFibonacci";
            lblFibonacci.Size = new Size(142, 28);
            lblFibonacci.TabIndex = 12;
            lblFibonacci.Text = "El Fibonacci es:";
            // 
            // lblResFac
            // 
            lblResFac.AutoSize = true;
            lblResFac.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblResFac.ForeColor = Color.SpringGreen;
            lblResFac.Location = new Point(58, 347);
            lblResFac.Name = "lblResFac";
            lblResFac.Size = new Size(45, 60);
            lblResFac.TabIndex = 13;
            lblResFac.Text = "x";
            lblResFac.Visible = false;
            // 
            // lblResFibo
            // 
            lblResFibo.AutoSize = true;
            lblResFibo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblResFibo.ForeColor = Color.SpringGreen;
            lblResFibo.Location = new Point(563, 347);
            lblResFibo.Name = "lblResFibo";
            lblResFibo.Size = new Size(45, 60);
            lblResFibo.TabIndex = 14;
            lblResFibo.Text = "x";
            lblResFibo.Visible = false;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(308, 316);
            lblError.Name = "lblError";
            lblError.Size = new Size(168, 60);
            lblError.TabIndex = 15;
            lblError.Text = "ERROR";
            lblError.Visible = false;
            // 
            // imgVolver
            // 
            imgVolver.Image = (Image)resources.GetObject("imgVolver.Image");
            imgVolver.Location = new Point(12, 12);
            imgVolver.Name = "imgVolver";
            imgVolver.Size = new Size(100, 100);
            imgVolver.SizeMode = PictureBoxSizeMode.StretchImage;
            imgVolver.TabIndex = 16;
            imgVolver.TabStop = false;
            imgVolver.Click += imgVolver_Click;
            // 
            // FrmFunciones
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(imgVolver);
            Controls.Add(lblError);
            Controls.Add(lblResFibo);
            Controls.Add(lblResFac);
            Controls.Add(lblFibonacci);
            Controls.Add(lblFactorial);
            Controls.Add(btnCalcular);
            Controls.Add(lblIntroduce);
            Controls.Add(txtNum);
            Name = "FrmFunciones";
            Text = "Funciones";
            ((System.ComponentModel.ISupportInitialize)imgVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum;
        private Label lblIntroduce;
        private Button btnCalcular;
        private Label lblFactorial;
        private Label lblFibonacci;
        private Label lblResFac;
        private Label lblResFibo;
        private Label lblError;
        private PictureBox imgVolver;
    }
}