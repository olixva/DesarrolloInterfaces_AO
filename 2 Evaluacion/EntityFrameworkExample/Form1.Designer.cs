namespace EntityFrameworkExample
{
    partial class FormProductos
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
            productBindingSource1 = new BindingSource(components);
            productBindingSource = new BindingSource(components);
            dataGridViewCategoria = new DataGridView();
            CategoryId = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            categoryBindingSource = new BindingSource(components);
            btnGuardar = new Button();
            lblCategorias = new Label();
            lblProductos = new Label();
            dataGridViewProductos = new DataGridView();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            productsBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // productBindingSource1
            // 
            productBindingSource1.DataSource = typeof(Product);
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // dataGridViewCategoria
            // 
            dataGridViewCategoria.AutoGenerateColumns = false;
            dataGridViewCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategoria.Columns.AddRange(new DataGridViewColumn[] { CategoryId, dataGridViewTextBoxColumn1 });
            dataGridViewCategoria.DataSource = categoryBindingSource;
            dataGridViewCategoria.Location = new Point(56, 78);
            dataGridViewCategoria.Name = "dataGridViewCategoria";
            dataGridViewCategoria.RowHeadersWidth = 67;
            dataGridViewCategoria.RowTemplate.Height = 36;
            dataGridViewCategoria.Size = new Size(402, 367);
            dataGridViewCategoria.TabIndex = 1;
            dataGridViewCategoria.SelectionChanged += dataGridViewCategoria_SelectionChanged;
            // 
            // CategoryId
            // 
            CategoryId.DataPropertyName = "CategoryId";
            CategoryId.HeaderText = "ID";
            CategoryId.MinimumWidth = 8;
            CategoryId.Name = "CategoryId";
            CategoryId.Width = 165;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 165;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Category);
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(416, 493);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(144, 42);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(196, 47);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(126, 28);
            lblCategorias.TabIndex = 3;
            lblCategorias.Text = "CATEGORIAS";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Location = new Point(692, 35);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(125, 28);
            lblProductos.TabIndex = 4;
            lblProductos.Text = "PRODUCTOS";
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AutoGenerateColumns = false;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, dataGridViewTextBoxColumn2 });
            dataGridViewProductos.DataSource = productsBindingSource;
            dataGridViewProductos.Location = new Point(530, 78);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 67;
            dataGridViewProductos.RowTemplate.Height = 36;
            dataGridViewProductos.Size = new Size(452, 367);
            dataGridViewProductos.TabIndex = 5;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ID";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.Width = 165;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 165;
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataMember = "Products";
            productsBindingSource.DataSource = categoryBindingSource;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 567);
            Controls.Add(dataGridViewProductos);
            Controls.Add(lblProductos);
            Controls.Add(lblCategorias);
            Controls.Add(btnGuardar);
            Controls.Add(dataGridViewCategoria);
            Name = "FormProductos";
            Text = "Productos y Categorias";
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewCategoria;
        private Button btnGuardar;
        private Label lblCategorias;
        private Label lblProductos;
        private BindingSource productBindingSource;
        private BindingSource categoryBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CategoryId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private BindingSource productBindingSource1;
        private DataGridView dataGridViewProductos;
        private BindingSource productsBindingSource;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}