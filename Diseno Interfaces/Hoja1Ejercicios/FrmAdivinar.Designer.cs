namespace Hoja1Ejercicios
{
    partial class FrmAdivinar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdivinar));
            lblAdivina = new Label();
            txtNum = new TextBox();
            lblMensaje = new Label();
            lblQuedan = new Label();
            lblVidas = new Label();
            pictureBox1 = new PictureBox();
            lblInfo = new Label();
            imgVolver = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgVolver).BeginInit();
            SuspendLayout();
            // 
            // lblAdivina
            // 
            lblAdivina.AutoSize = true;
            lblAdivina.Location = new Point(125, 336);
            lblAdivina.Name = "lblAdivina";
            lblAdivina.Size = new Size(244, 28);
            lblAdivina.TabIndex = 6;
            lblAdivina.Text = "Adivina el numero (0-100):";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(411, 336);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(165, 34);
            txtNum.TabIndex = 7;
            txtNum.KeyDown += txtNum_KeyDown;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensaje.ForeColor = Color.Red;
            lblMensaje.Location = new Point(125, 172);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(504, 60);
            lblMensaje.TabIndex = 8;
            lblMensaje.Text = "NUMERO INCORRECTO";
            lblMensaje.Visible = false;
            // 
            // lblQuedan
            // 
            lblQuedan.AutoSize = true;
            lblQuedan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuedan.ForeColor = Color.Red;
            lblQuedan.Location = new Point(244, 68);
            lblQuedan.Name = "lblQuedan";
            lblQuedan.Size = new Size(163, 37);
            lblQuedan.TabIndex = 9;
            lblQuedan.Text = "Te quedan: ";
            // 
            // lblVidas
            // 
            lblVidas.AutoSize = true;
            lblVidas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVidas.ForeColor = Color.Red;
            lblVidas.Location = new Point(406, 68);
            lblVidas.Name = "lblVidas";
            lblVidas.Size = new Size(33, 37);
            lblVidas.TabIndex = 10;
            lblVidas.Text = "7";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(445, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfo.ForeColor = SystemColors.ActiveCaptionText;
            lblInfo.Location = new Point(244, 259);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(235, 40);
            lblInfo.TabIndex = 12;
            lblInfo.Text = "Te has pasado :(";
            lblInfo.Visible = false;
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
            // FrmAdivinar
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(imgVolver);
            Controls.Add(lblInfo);
            Controls.Add(pictureBox1);
            Controls.Add(lblVidas);
            Controls.Add(lblQuedan);
            Controls.Add(lblMensaje);
            Controls.Add(txtNum);
            Controls.Add(lblAdivina);
            Name = "FrmAdivinar";
            Text = "FrmAdivinar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdivina;
        private TextBox txtNum;
        private Label lblMensaje;
        private Label lblQuedan;
        private Label lblVidas;
        private PictureBox pictureBox1;
        private Label lblInfo;
        private PictureBox imgVolver;
    }
}