namespace AplicacionMDI
{
    partial class FrmHijo
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
            this.rtbDocumento = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbDocumento
            // 
            this.rtbDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDocumento.Location = new System.Drawing.Point(0, 0);
            this.rtbDocumento.Name = "rtbDocumento";
            this.rtbDocumento.Size = new System.Drawing.Size(676, 747);
            this.rtbDocumento.TabIndex = 0;
            this.rtbDocumento.Text = "";
            // 
            // FrmHijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 747);
            this.Controls.Add(this.rtbDocumento);
            this.Name = "FrmHijo";
            this.Text = "Formulario Hijo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDocumento;
    }
}