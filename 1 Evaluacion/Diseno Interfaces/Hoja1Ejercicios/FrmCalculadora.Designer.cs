namespace PruebaSuma
{
    partial class FrmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            btnSuma = new Button();
            txtBoxN1 = new TextBox();
            txtBoxN2 = new TextBox();
            lblN1 = new Label();
            lblN2 = new Label();
            lblError = new Label();
            lblResultado = new Label();
            btnResta = new Button();
            btnMult = new Button();
            pictureBox1 = new PictureBox();
            btnDiv = new Button();
            imgVolver = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgVolver).BeginInit();
            SuspendLayout();
            // 
            // btnSuma
            // 
            btnSuma.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuma.Location = new Point(245, 339);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(82, 75);
            btnSuma.TabIndex = 0;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // txtBoxN1
            // 
            txtBoxN1.Location = new Point(318, 199);
            txtBoxN1.Name = "txtBoxN1";
            txtBoxN1.Size = new Size(152, 34);
            txtBoxN1.TabIndex = 3;
            // 
            // txtBoxN2
            // 
            txtBoxN2.Location = new Point(671, 199);
            txtBoxN2.Name = "txtBoxN2";
            txtBoxN2.Size = new Size(165, 34);
            txtBoxN2.TabIndex = 4;
            // 
            // lblN1
            // 
            lblN1.AutoSize = true;
            lblN1.Font = new Font("Segoe UI", 9.113924F, FontStyle.Bold, GraphicsUnit.Point);
            lblN1.Location = new Point(193, 199);
            lblN1.Name = "lblN1";
            lblN1.Size = new Size(107, 28);
            lblN1.TabIndex = 5;
            lblN1.Text = "Numero 1";
            // 
            // lblN2
            // 
            lblN2.AutoSize = true;
            lblN2.Font = new Font("Segoe UI", 9.113924F, FontStyle.Bold, GraphicsUnit.Point);
            lblN2.Location = new Point(527, 199);
            lblN2.Name = "lblN2";
            lblN2.Size = new Size(107, 28);
            lblN2.TabIndex = 6;
            lblN2.Text = "Numero 2";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(760, 424);
            lblError.Name = "lblError";
            lblError.Size = new Size(168, 60);
            lblError.TabIndex = 7;
            lblError.Text = "ERROR";
            lblError.Visible = false;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.SpringGreen;
            lblResultado.Location = new Point(522, 440);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(45, 60);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "x";
            lblResultado.Visible = false;
            // 
            // btnResta
            // 
            btnResta.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnResta.Location = new Point(115, 339);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(82, 75);
            btnResta.TabIndex = 9;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnMult.Location = new Point(115, 440);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(82, 75);
            btnMult.TabIndex = 10;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(908, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 305);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnDiv.Location = new Point(245, 440);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(82, 75);
            btnDiv.TabIndex = 12;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
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
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 657);
            Controls.Add(imgVolver);
            Controls.Add(btnDiv);
            Controls.Add(pictureBox1);
            Controls.Add(btnMult);
            Controls.Add(btnResta);
            Controls.Add(lblResultado);
            Controls.Add(lblError);
            Controls.Add(lblN2);
            Controls.Add(lblN1);
            Controls.Add(txtBoxN2);
            Controls.Add(txtBoxN1);
            Controls.Add(btnSuma);
            Name = "FrmCalculadora";
            Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSuma;
        private TextBox txtBoxN1;
        private TextBox txtBoxN2;
        private Label lblN1;
        private Label lblN2;
        private Label lblError;
        private Label lblResultado;
        private Button btnResta;
        private Button btnMult;
        private PictureBox pictureBox1;
        private Button btnDiv;
        private PictureBox imgVolver;
    }
}