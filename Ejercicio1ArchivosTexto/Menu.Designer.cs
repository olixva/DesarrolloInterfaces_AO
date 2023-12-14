namespace Ejercicio1ArchivosTexto
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarAgenndaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarAgendaPorInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAltas = new System.Windows.Forms.GroupBox();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombreConsulta = new System.Windows.Forms.TextBox();
            this.lblNombreConsulta = new System.Windows.Forms.Label();
            this.grpGuardar = new System.Windows.Forms.GroupBox();
            this.txtBoxGuardar = new System.Windows.Forms.RichTextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpGuardarInicial = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogInicial = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogInicial = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.grpAltas.SuspendLayout();
            this.grpConsulta.SuspendLayout();
            this.grpGuardar.SuspendLayout();
            this.grpGuardarInicial.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(977, 40);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(73, 32);
            this.altasToolStripMenuItem.Text = "&Altas";
            this.altasToolStripMenuItem.Click += new System.EventHandler(this.altasToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(106, 32);
            this.consultaToolStripMenuItem.Text = "&Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarAgenndaToolStripMenuItem,
            this.guardarAgendaPorInicialToolStripMenuItem});
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(145, 32);
            this.guardarToolStripMenuItem.Text = "&Guardar/Leer";
            // 
            // guardarAgenndaToolStripMenuItem
            // 
            this.guardarAgenndaToolStripMenuItem.Name = "guardarAgenndaToolStripMenuItem";
            this.guardarAgenndaToolStripMenuItem.Size = new System.Drawing.Size(401, 36);
            this.guardarAgenndaToolStripMenuItem.Text = "Guardar/Leer &Agenda";
            this.guardarAgenndaToolStripMenuItem.Click += new System.EventHandler(this.guardarAgendaToolStripMenuItem_Click);
            // 
            // guardarAgendaPorInicialToolStripMenuItem
            // 
            this.guardarAgendaPorInicialToolStripMenuItem.Name = "guardarAgendaPorInicialToolStripMenuItem";
            this.guardarAgendaPorInicialToolStripMenuItem.Size = new System.Drawing.Size(401, 36);
            this.guardarAgendaPorInicialToolStripMenuItem.Text = "Guardar/Leer Agenda por &Inicial";
            this.guardarAgendaPorInicialToolStripMenuItem.Click += new System.EventHandler(this.guardarAgendaPorInicialToolStripMenuItem_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(181, 56);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(193, 32);
            this.txtID.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(181, 122);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(193, 32);
            this.txtNombre.TabIndex = 2;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(181, 194);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(193, 32);
            this.txtTelefono.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(48, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(34, 26);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(48, 126);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 26);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(48, 196);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(95, 26);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(151, 286);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(105, 40);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // grpAltas
            // 
            this.grpAltas.Controls.Add(this.txtTelefono);
            this.grpAltas.Controls.Add(this.btnCrear);
            this.grpAltas.Controls.Add(this.txtID);
            this.grpAltas.Controls.Add(this.lblTelefono);
            this.grpAltas.Controls.Add(this.txtNombre);
            this.grpAltas.Controls.Add(this.lblNombre);
            this.grpAltas.Controls.Add(this.lblID);
            this.grpAltas.Location = new System.Drawing.Point(37, 55);
            this.grpAltas.Name = "grpAltas";
            this.grpAltas.Size = new System.Drawing.Size(428, 344);
            this.grpAltas.TabIndex = 8;
            this.grpAltas.TabStop = false;
            this.grpAltas.Text = "Altas";
            this.grpAltas.Visible = false;
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.btnBuscar);
            this.grpConsulta.Controls.Add(this.txtNombreConsulta);
            this.grpConsulta.Controls.Add(this.lblNombreConsulta);
            this.grpConsulta.Location = new System.Drawing.Point(520, 55);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(428, 344);
            this.grpConsulta.TabIndex = 9;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Consulta";
            this.grpConsulta.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(151, 286);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 40);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombreConsulta
            // 
            this.txtNombreConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreConsulta.Location = new System.Drawing.Point(176, 123);
            this.txtNombreConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreConsulta.Name = "txtNombreConsulta";
            this.txtNombreConsulta.Size = new System.Drawing.Size(193, 32);
            this.txtNombreConsulta.TabIndex = 2;
            // 
            // lblNombreConsulta
            // 
            this.lblNombreConsulta.AutoSize = true;
            this.lblNombreConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreConsulta.Location = new System.Drawing.Point(48, 126);
            this.lblNombreConsulta.Name = "lblNombreConsulta";
            this.lblNombreConsulta.Size = new System.Drawing.Size(90, 26);
            this.lblNombreConsulta.TabIndex = 5;
            this.lblNombreConsulta.Text = "Nombre";
            // 
            // grpGuardar
            // 
            this.grpGuardar.Controls.Add(this.txtBoxGuardar);
            this.grpGuardar.Controls.Add(this.btnAbrir);
            this.grpGuardar.Controls.Add(this.btnGuardar);
            this.grpGuardar.Location = new System.Drawing.Point(37, 405);
            this.grpGuardar.Name = "grpGuardar";
            this.grpGuardar.Size = new System.Drawing.Size(428, 394);
            this.grpGuardar.TabIndex = 10;
            this.grpGuardar.TabStop = false;
            this.grpGuardar.Text = "Guardar/Leer Agenda";
            this.grpGuardar.Visible = false;
            // 
            // txtBoxGuardar
            // 
            this.txtBoxGuardar.Location = new System.Drawing.Point(33, 36);
            this.txtBoxGuardar.Name = "txtBoxGuardar";
            this.txtBoxGuardar.Size = new System.Drawing.Size(370, 266);
            this.txtBoxGuardar.TabIndex = 10;
            this.txtBoxGuardar.Text = "";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(298, 332);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(105, 40);
            this.btnAbrir.TabIndex = 9;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(33, 332);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 40);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grpGuardarInicial
            // 
            this.grpGuardarInicial.Controls.Add(this.richTextBox1);
            this.grpGuardarInicial.Controls.Add(this.button1);
            this.grpGuardarInicial.Controls.Add(this.button2);
            this.grpGuardarInicial.Location = new System.Drawing.Point(520, 405);
            this.grpGuardarInicial.Name = "grpGuardarInicial";
            this.grpGuardarInicial.Size = new System.Drawing.Size(428, 394);
            this.grpGuardarInicial.TabIndex = 11;
            this.grpGuardarInicial.TabStop = false;
            this.grpGuardarInicial.Text = "Guardar/Leer Agenda por Inicial";
            this.grpGuardarInicial.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(370, 266);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(298, 332);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(33, 332);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "agenda";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // openFileDialogInicial
            // 
            this.openFileDialogInicial.FileName = "openFileDialog1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 806);
            this.Controls.Add(this.grpGuardarInicial);
            this.Controls.Add(this.grpGuardar);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.grpAltas);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.grpAltas.ResumeLayout(false);
            this.grpAltas.PerformLayout();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            this.grpGuardar.ResumeLayout(false);
            this.grpGuardarInicial.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarAgenndaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarAgendaPorInicialToolStripMenuItem;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombreConsulta;
        private System.Windows.Forms.Label lblNombreConsulta;
        private System.Windows.Forms.GroupBox grpAltas;
        private System.Windows.Forms.GroupBox grpGuardar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grpGuardarInicial;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox txtBoxGuardar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialogInicial;
        private System.Windows.Forms.OpenFileDialog openFileDialogInicial;
    }
}

