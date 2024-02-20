namespace Examen_AO
{
    partial class Listados
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
            this.grpDatosPedido = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNPedido = new System.Windows.Forms.Label();
            this.cmbNPedido = new System.Windows.Forms.ComboBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.grpDatosPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosPedido
            // 
            this.grpDatosPedido.Controls.Add(this.btnGuardar);
            this.grpDatosPedido.Controls.Add(this.btnCancelar);
            this.grpDatosPedido.Controls.Add(this.lblNPedido);
            this.grpDatosPedido.Controls.Add(this.cmbNPedido);
            this.grpDatosPedido.Location = new System.Drawing.Point(32, 46);
            this.grpDatosPedido.Name = "grpDatosPedido";
            this.grpDatosPedido.Size = new System.Drawing.Size(725, 156);
            this.grpDatosPedido.TabIndex = 0;
            this.grpDatosPedido.TabStop = false;
            this.grpDatosPedido.Text = "Introducir datos Pedido";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(422, 73);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 37);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(579, 73);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 37);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNPedido
            // 
            this.lblNPedido.AutoSize = true;
            this.lblNPedido.Location = new System.Drawing.Point(6, 80);
            this.lblNPedido.Name = "lblNPedido";
            this.lblNPedido.Size = new System.Drawing.Size(163, 22);
            this.lblNPedido.TabIndex = 1;
            this.lblNPedido.Text = "Introducir N Pedido";
            // 
            // cmbNPedido
            // 
            this.cmbNPedido.FormattingEnabled = true;
            this.cmbNPedido.Location = new System.Drawing.Point(192, 77);
            this.cmbNPedido.Name = "cmbNPedido";
            this.cmbNPedido.Size = new System.Drawing.Size(121, 30);
            this.cmbNPedido.TabIndex = 0;
            this.cmbNPedido.SelectedIndexChanged += new System.EventHandler(this.cmbNPedido_SelectedIndexChanged);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 233);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(776, 277);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Title = "Guardar Archivo";
            // 
            // Listados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.grpDatosPedido);
            this.Name = "Listados";
            this.Text = "Listados";
            this.Load += new System.EventHandler(this.Listados_Load);
            this.grpDatosPedido.ResumeLayout(false);
            this.grpDatosPedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosPedido;
        private System.Windows.Forms.Label lblNPedido;
        private System.Windows.Forms.ComboBox cmbNPedido;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}