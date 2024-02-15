namespace BBDDDisenador
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label ubicacionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.zooBDDataSet = new BBDDDisenador.ZooBDDataSet();
            this.zooBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zooTableAdapter = new BBDDDisenador.ZooBDDataSetTableAdapters.ZooTableAdapter();
            this.tableAdapterManager = new BBDDDisenador.ZooBDDataSetTableAdapters.TableAdapterManager();
            this.zooBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zooBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.ubicacionTextBox = new System.Windows.Forms.TextBox();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new BBDDDisenador.ZooBDDataSetTableAdapters.AnimalTableAdapter();
            this.dvgAnimales = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnimalesZoo = new System.Windows.Forms.DataGridView();
            this.lblZoos = new System.Windows.Forms.Label();
            this.labelAnimales = new System.Windows.Forms.Label();
            this.btnAsignarAnimal = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            ubicacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zooBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooBindingNavigator)).BeginInit();
            this.zooBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAnimales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimalesZoo)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(106, 191);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(29, 22);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // ubicacionLabel
            // 
            ubicacionLabel.AutoSize = true;
            ubicacionLabel.Location = new System.Drawing.Point(106, 225);
            ubicacionLabel.Name = "ubicacionLabel";
            ubicacionLabel.Size = new System.Drawing.Size(94, 22);
            ubicacionLabel.TabIndex = 3;
            ubicacionLabel.Text = "Ubicacion:";
            // 
            // zooBDDataSet
            // 
            this.zooBDDataSet.DataSetName = "ZooBDDataSet";
            this.zooBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zooBindingSource
            // 
            this.zooBindingSource.DataMember = "Zoo";
            this.zooBindingSource.DataSource = this.zooBDDataSet;
            // 
            // zooTableAdapter
            // 
            this.zooTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalTableAdapter = null;
            this.tableAdapterManager.AnimalZooTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BBDDDisenador.ZooBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZooTableAdapter = this.zooTableAdapter;
            // 
            // zooBindingNavigator
            // 
            this.zooBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.zooBindingNavigator.BindingSource = this.zooBindingSource;
            this.zooBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zooBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.zooBindingNavigator.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.zooBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.zooBindingNavigatorSaveItem});
            this.zooBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.zooBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.zooBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.zooBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.zooBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.zooBindingNavigator.Name = "zooBindingNavigator";
            this.zooBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.zooBindingNavigator.Size = new System.Drawing.Size(963, 35);
            this.zooBindingNavigator.TabIndex = 0;
            this.zooBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(38, 30);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(62, 30);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(38, 30);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(38, 30);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(38, 30);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9.113924F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 34);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            this.bindingNavigatorPositionItem.TextChanged += new System.EventHandler(this.bindingNavigatorPositionItem_TextChanged);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(38, 30);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(38, 30);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // zooBindingNavigatorSaveItem
            // 
            this.zooBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zooBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("zooBindingNavigatorSaveItem.Image")));
            this.zooBindingNavigatorSaveItem.Name = "zooBindingNavigatorSaveItem";
            this.zooBindingNavigatorSaveItem.Size = new System.Drawing.Size(38, 30);
            this.zooBindingNavigatorSaveItem.Text = "Guardar datos";
            this.zooBindingNavigatorSaveItem.Click += new System.EventHandler(this.zooBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zooBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(206, 188);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(126, 28);
            this.idTextBox.TabIndex = 2;
            // 
            // ubicacionTextBox
            // 
            this.ubicacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zooBindingSource, "Ubicacion", true));
            this.ubicacionTextBox.Location = new System.Drawing.Point(206, 222);
            this.ubicacionTextBox.Name = "ubicacionTextBox";
            this.ubicacionTextBox.Size = new System.Drawing.Size(126, 28);
            this.ubicacionTextBox.TabIndex = 4;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.zooBDDataSet;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // dvgAnimales
            // 
            this.dvgAnimales.AutoGenerateColumns = false;
            this.dvgAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAnimales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dvgAnimales.DataSource = this.animalBindingSource;
            this.dvgAnimales.Location = new System.Drawing.Point(448, 89);
            this.dvgAnimales.MultiSelect = false;
            this.dvgAnimales.Name = "dvgAnimales";
            this.dvgAnimales.RowHeadersWidth = 67;
            this.dvgAnimales.RowTemplate.Height = 30;
            this.dvgAnimales.Size = new System.Drawing.Size(503, 220);
            this.dvgAnimales.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 165;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 165;
            // 
            // dgvAnimalesZoo
            // 
            this.dgvAnimalesZoo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvAnimalesZoo.AllowDrop = true;
            this.dgvAnimalesZoo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimalesZoo.Location = new System.Drawing.Point(12, 334);
            this.dgvAnimalesZoo.Name = "dgvAnimalesZoo";
            this.dgvAnimalesZoo.RowHeadersWidth = 67;
            this.dgvAnimalesZoo.RowTemplate.Height = 30;
            this.dgvAnimalesZoo.Size = new System.Drawing.Size(444, 276);
            this.dgvAnimalesZoo.TabIndex = 6;
            // 
            // lblZoos
            // 
            this.lblZoos.AutoSize = true;
            this.lblZoos.Location = new System.Drawing.Point(184, 121);
            this.lblZoos.Name = "lblZoos";
            this.lblZoos.Size = new System.Drawing.Size(55, 22);
            this.lblZoos.TabIndex = 7;
            this.lblZoos.Text = "ZOZs";
            // 
            // labelAnimales
            // 
            this.labelAnimales.AutoSize = true;
            this.labelAnimales.Location = new System.Drawing.Point(639, 45);
            this.labelAnimales.Name = "labelAnimales";
            this.labelAnimales.Size = new System.Drawing.Size(83, 22);
            this.labelAnimales.TabIndex = 8;
            this.labelAnimales.Text = "Animales";
            // 
            // btnAsignarAnimal
            // 
            this.btnAsignarAnimal.Location = new System.Drawing.Point(607, 334);
            this.btnAsignarAnimal.Name = "btnAsignarAnimal";
            this.btnAsignarAnimal.Size = new System.Drawing.Size(208, 70);
            this.btnAsignarAnimal.TabIndex = 9;
            this.btnAsignarAnimal.Text = "ASIGNAR ANIMAL";
            this.btnAsignarAnimal.UseVisualStyleBackColor = true;
            this.btnAsignarAnimal.Click += new System.EventHandler(this.btnAsignarAnimal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 636);
            this.Controls.Add(this.btnAsignarAnimal);
            this.Controls.Add(this.labelAnimales);
            this.Controls.Add(this.lblZoos);
            this.Controls.Add(this.dgvAnimalesZoo);
            this.Controls.Add(this.dvgAnimales);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(ubicacionLabel);
            this.Controls.Add(this.ubicacionTextBox);
            this.Controls.Add(this.zooBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zooBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooBindingNavigator)).EndInit();
            this.zooBindingNavigator.ResumeLayout(false);
            this.zooBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAnimales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimalesZoo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZooBDDataSet zooBDDataSet;
        private System.Windows.Forms.BindingSource zooBindingSource;
        private ZooBDDataSetTableAdapters.ZooTableAdapter zooTableAdapter;
        private ZooBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator zooBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton zooBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox ubicacionTextBox;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private ZooBDDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private System.Windows.Forms.DataGridView dvgAnimales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgvAnimalesZoo;
        private System.Windows.Forms.Label lblZoos;
        private System.Windows.Forms.Label labelAnimales;
        private System.Windows.Forms.Button btnAsignarAnimal;
    }
}

