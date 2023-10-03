namespace PruebaSuma
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            btnSuma = new Button();
            txtBoxN1 = new TextBox();
            txtBoxN2 = new TextBox();
            labelN1 = new Label();
            labelN2 = new Label();
            labelError = new Label();
            labelResultado = new Label();
            btnResta = new Button();
            btnMult = new Button();
            pictureBox1 = new PictureBox();
            btnDiv = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // labelN1
            // 
            labelN1.AutoSize = true;
            labelN1.Font = new Font("Segoe UI", 9.113924F, FontStyle.Bold, GraphicsUnit.Point);
            labelN1.Location = new Point(193, 199);
            labelN1.Name = "labelN1";
            labelN1.Size = new Size(107, 28);
            labelN1.TabIndex = 5;
            labelN1.Text = "Numero 1";
            // 
            // labelN2
            // 
            labelN2.AutoSize = true;
            labelN2.Font = new Font("Segoe UI", 9.113924F, FontStyle.Bold, GraphicsUnit.Point);
            labelN2.Location = new Point(527, 199);
            labelN2.Name = "labelN2";
            labelN2.Size = new Size(107, 28);
            labelN2.TabIndex = 6;
            labelN2.Text = "Numero 2";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(760, 424);
            labelError.Name = "labelError";
            labelError.Size = new Size(168, 60);
            labelError.TabIndex = 7;
            labelError.Text = "ERROR";
            labelError.Visible = false;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelResultado.ForeColor = Color.SpringGreen;
            labelResultado.Location = new Point(522, 440);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(45, 60);
            labelResultado.TabIndex = 8;
            labelResultado.Text = "x";
            labelResultado.Visible = false;
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
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 657);
            Controls.Add(btnDiv);
            Controls.Add(pictureBox1);
            Controls.Add(btnMult);
            Controls.Add(btnResta);
            Controls.Add(labelResultado);
            Controls.Add(labelError);
            Controls.Add(labelN2);
            Controls.Add(labelN1);
            Controls.Add(txtBoxN2);
            Controls.Add(txtBoxN1);
            Controls.Add(btnSuma);
            Name = "Calculadora";
            Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSuma;
        private TextBox txtBoxN1;
        private TextBox txtBoxN2;
        private Label labelN1;
        private Label labelN2;
        private Label labelError;
        private Label labelResultado;
        private Button btnResta;
        private Button btnMult;
        private PictureBox pictureBox1;
        private Button btnDiv;
    }
}