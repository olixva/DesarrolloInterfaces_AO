namespace EjemploBBDD
{
    partial class Form1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnCargarDatGrid = new System.Windows.Forms.Button();
            this.listBoxZoos = new System.Windows.Forms.ListBox();
            this.listBoxAnimalesZoo = new System.Windows.Forms.ListBox();
            this.btnCargarZooListBox = new System.Windows.Forms.Button();
            this.txtBoxInsertarZoo = new System.Windows.Forms.TextBox();
            this.lblInsertZoo = new System.Windows.Forms.Label();
            this.btnInsertarZoo = new System.Windows.Forms.Button();
            this.btnBorrarZoo = new System.Windows.Forms.Button();
            this.lblBorrarZoo = new System.Windows.Forms.Label();
            this.btnCargarAnimalesList = new System.Windows.Forms.Button();
            this.listBoxAnimales = new System.Windows.Forms.ListBox();
            this.btnAsignarAnimalZoo = new System.Windows.Forms.Button();
            this.lblAsignar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(33, 22);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 67;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(282, 269);
            this.dataGridView.TabIndex = 0;
            // 
            // btnCargarDatGrid
            // 
            this.btnCargarDatGrid.Location = new System.Drawing.Point(96, 330);
            this.btnCargarDatGrid.Name = "btnCargarDatGrid";
            this.btnCargarDatGrid.Size = new System.Drawing.Size(153, 87);
            this.btnCargarDatGrid.TabIndex = 1;
            this.btnCargarDatGrid.Text = "CARGAR ANIMALES";
            this.btnCargarDatGrid.UseVisualStyleBackColor = true;
            this.btnCargarDatGrid.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // listBoxZoos
            // 
            this.listBoxZoos.FormattingEnabled = true;
            this.listBoxZoos.ItemHeight = 22;
            this.listBoxZoos.Location = new System.Drawing.Point(694, 23);
            this.listBoxZoos.Name = "listBoxZoos";
            this.listBoxZoos.Size = new System.Drawing.Size(274, 268);
            this.listBoxZoos.TabIndex = 2;
            this.listBoxZoos.SelectedIndexChanged += new System.EventHandler(this.listBoxZoos_SelectedIndexChanged);
            // 
            // listBoxAnimalesZoo
            // 
            this.listBoxAnimalesZoo.FormattingEnabled = true;
            this.listBoxAnimalesZoo.ItemHeight = 22;
            this.listBoxAnimalesZoo.Location = new System.Drawing.Point(1011, 22);
            this.listBoxAnimalesZoo.Name = "listBoxAnimalesZoo";
            this.listBoxAnimalesZoo.Size = new System.Drawing.Size(277, 268);
            this.listBoxAnimalesZoo.TabIndex = 3;
            // 
            // btnCargarZooListBox
            // 
            this.btnCargarZooListBox.Location = new System.Drawing.Point(743, 330);
            this.btnCargarZooListBox.Name = "btnCargarZooListBox";
            this.btnCargarZooListBox.Size = new System.Drawing.Size(153, 87);
            this.btnCargarZooListBox.TabIndex = 4;
            this.btnCargarZooListBox.Text = "CARGAR ZOOS";
            this.btnCargarZooListBox.UseVisualStyleBackColor = true;
            this.btnCargarZooListBox.Click += new System.EventHandler(this.btnCargarZooListBox_Click);
            // 
            // txtBoxInsertarZoo
            // 
            this.txtBoxInsertarZoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInsertarZoo.Location = new System.Drawing.Point(733, 525);
            this.txtBoxInsertarZoo.Name = "txtBoxInsertarZoo";
            this.txtBoxInsertarZoo.Size = new System.Drawing.Size(174, 35);
            this.txtBoxInsertarZoo.TabIndex = 5;
            // 
            // lblInsertZoo
            // 
            this.lblInsertZoo.AutoSize = true;
            this.lblInsertZoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertZoo.Location = new System.Drawing.Point(727, 453);
            this.lblInsertZoo.Name = "lblInsertZoo";
            this.lblInsertZoo.Size = new System.Drawing.Size(180, 33);
            this.lblInsertZoo.TabIndex = 6;
            this.lblInsertZoo.Text = "Insertar Zoo:";
            // 
            // btnInsertarZoo
            // 
            this.btnInsertarZoo.Location = new System.Drawing.Point(766, 593);
            this.btnInsertarZoo.Name = "btnInsertarZoo";
            this.btnInsertarZoo.Size = new System.Drawing.Size(98, 56);
            this.btnInsertarZoo.TabIndex = 7;
            this.btnInsertarZoo.Text = "Insertar";
            this.btnInsertarZoo.UseVisualStyleBackColor = true;
            this.btnInsertarZoo.Click += new System.EventHandler(this.btnInsertarZoo_Click);
            // 
            // btnBorrarZoo
            // 
            this.btnBorrarZoo.Location = new System.Drawing.Point(1131, 529);
            this.btnBorrarZoo.Name = "btnBorrarZoo";
            this.btnBorrarZoo.Size = new System.Drawing.Size(98, 56);
            this.btnBorrarZoo.TabIndex = 10;
            this.btnBorrarZoo.Text = "Borrar";
            this.btnBorrarZoo.UseVisualStyleBackColor = true;
            this.btnBorrarZoo.Click += new System.EventHandler(this.btnBorrarZoo_Click);
            // 
            // lblBorrarZoo
            // 
            this.lblBorrarZoo.AutoSize = true;
            this.lblBorrarZoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrarZoo.Location = new System.Drawing.Point(1014, 467);
            this.lblBorrarZoo.Name = "lblBorrarZoo";
            this.lblBorrarZoo.Size = new System.Drawing.Size(345, 33);
            this.lblBorrarZoo.TabIndex = 9;
            this.lblBorrarZoo.Text = "Borrar Zoo Seleccionado:";
            // 
            // btnCargarAnimalesList
            // 
            this.btnCargarAnimalesList.Location = new System.Drawing.Point(422, 329);
            this.btnCargarAnimalesList.Name = "btnCargarAnimalesList";
            this.btnCargarAnimalesList.Size = new System.Drawing.Size(153, 87);
            this.btnCargarAnimalesList.TabIndex = 12;
            this.btnCargarAnimalesList.Text = "CARGAR ANIMALES";
            this.btnCargarAnimalesList.UseVisualStyleBackColor = true;
            this.btnCargarAnimalesList.Click += new System.EventHandler(this.btnCargarAnimalesList_Click);
            // 
            // listBoxAnimales
            // 
            this.listBoxAnimales.FormattingEnabled = true;
            this.listBoxAnimales.ItemHeight = 22;
            this.listBoxAnimales.Location = new System.Drawing.Point(373, 22);
            this.listBoxAnimales.Name = "listBoxAnimales";
            this.listBoxAnimales.Size = new System.Drawing.Size(274, 268);
            this.listBoxAnimales.TabIndex = 11;
            // 
            // btnAsignarAnimalZoo
            // 
            this.btnAsignarAnimalZoo.Location = new System.Drawing.Point(265, 578);
            this.btnAsignarAnimalZoo.Name = "btnAsignarAnimalZoo";
            this.btnAsignarAnimalZoo.Size = new System.Drawing.Size(121, 71);
            this.btnAsignarAnimalZoo.TabIndex = 13;
            this.btnAsignarAnimalZoo.Text = "ASIGNAR";
            this.btnAsignarAnimalZoo.UseVisualStyleBackColor = true;
            this.btnAsignarAnimalZoo.Click += new System.EventHandler(this.btnAsignarAnimalZoo_Click);
            // 
            // lblAsignar
            // 
            this.lblAsignar.AutoSize = true;
            this.lblAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignar.Location = new System.Drawing.Point(36, 513);
            this.lblAsignar.Name = "lblAsignar";
            this.lblAsignar.Size = new System.Drawing.Size(652, 33);
            this.lblAsignar.TabIndex = 14;
            this.lblAsignar.Text = "Asignar Animal seleccionado a Zoo seleccionado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 706);
            this.Controls.Add(this.lblAsignar);
            this.Controls.Add(this.btnAsignarAnimalZoo);
            this.Controls.Add(this.btnCargarAnimalesList);
            this.Controls.Add(this.listBoxAnimales);
            this.Controls.Add(this.btnBorrarZoo);
            this.Controls.Add(this.lblBorrarZoo);
            this.Controls.Add(this.btnInsertarZoo);
            this.Controls.Add(this.lblInsertZoo);
            this.Controls.Add(this.txtBoxInsertarZoo);
            this.Controls.Add(this.btnCargarZooListBox);
            this.Controls.Add(this.listBoxAnimalesZoo);
            this.Controls.Add(this.listBoxZoos);
            this.Controls.Add(this.btnCargarDatGrid);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnCargarDatGrid;
        private System.Windows.Forms.ListBox listBoxZoos;
        private System.Windows.Forms.ListBox listBoxAnimalesZoo;
        private System.Windows.Forms.Button btnCargarZooListBox;
        private System.Windows.Forms.TextBox txtBoxInsertarZoo;
        private System.Windows.Forms.Label lblInsertZoo;
        private System.Windows.Forms.Button btnInsertarZoo;
        private System.Windows.Forms.Button btnBorrarZoo;
        private System.Windows.Forms.Label lblBorrarZoo;
        private System.Windows.Forms.Button btnCargarAnimalesList;
        private System.Windows.Forms.ListBox listBoxAnimales;
        private System.Windows.Forms.Button btnAsignarAnimalZoo;
        private System.Windows.Forms.Label lblAsignar;
    }
}

