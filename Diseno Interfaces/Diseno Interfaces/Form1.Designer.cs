namespace Diseno_Interfaces
{
    partial class frmInicio
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            bindingSource2 = new BindingSource(components);
            lblPeticion = new Label();
            btnSi = new Button();
            btnNo = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            SuspendLayout();
            // 
            // lblPeticion
            // 
            lblPeticion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPeticion.AutoSize = true;
            lblPeticion.BackColor = SystemColors.GradientInactiveCaption;
            lblPeticion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPeticion.ForeColor = SystemColors.ActiveCaptionText;
            lblPeticion.Location = new Point(361, 129);
            lblPeticion.Name = "lblPeticion";
            lblPeticion.Size = new Size(221, 30);
            lblPeticion.TabIndex = 1;
            lblPeticion.Text = "Quieres ser mi novia?";
            // 
            // btnSi
            // 
            btnSi.AutoSize = true;
            btnSi.BackColor = SystemColors.ControlDark;
            btnSi.Location = new Point(243, 223);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(113, 87);
            btnSi.TabIndex = 2;
            btnSi.Text = "Si";
            btnSi.UseVisualStyleBackColor = false;
            btnSi.Click += btnSi_Click;
            btnSi.MouseLeave += btnSi_MouseLeave;
            btnSi.MouseHover += btnSi_MouseHover;
            // 
            // btnNo
            // 
            btnNo.AutoSize = true;
            btnNo.BackColor = SystemColors.ControlDark;
            btnNo.Location = new Point(553, 223);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(113, 87);
            btnNo.TabIndex = 4;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            btnNo.MouseLeave += btnNo_MouseLeave;
            btnNo.MouseHover += btnNo_MouseHover;
            // 
            // frmInicio
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(991, 433);
            Controls.Add(btnNo);
            Controls.Add(btnSi);
            Controls.Add(lblPeticion);
            Name = "frmInicio";
            Text = "Formulario de Prueba";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BindingSource bindingSource2;
        private Label lblPeticion;
        private Button btnSi;
        private Button btnNo;
    }
}