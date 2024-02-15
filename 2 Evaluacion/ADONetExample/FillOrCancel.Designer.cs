namespace ADONetExample
{
    partial class FillOrCancel
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
            this.lblOrderId = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnFindByOrderID = new System.Windows.Forms.Button();
            this.lblFillDate = new System.Windows.Forms.Label();
            this.dtpFillDate = new System.Windows.Forms.DateTimePicker();
            this.dgvCustomerOrders = new System.Windows.Forms.DataGridView();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnFillOrder = new System.Windows.Forms.Button();
            this.btnFinishUpdates = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(40, 72);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(201, 22);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "Identificador de pedido: ";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(273, 72);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(175, 28);
            this.txtOrderID.TabIndex = 1;
            // 
            // btnFindByOrderID
            // 
            this.btnFindByOrderID.Location = new System.Drawing.Point(537, 61);
            this.btnFindByOrderID.Name = "btnFindByOrderID";
            this.btnFindByOrderID.Size = new System.Drawing.Size(169, 44);
            this.btnFindByOrderID.TabIndex = 2;
            this.btnFindByOrderID.Text = "Buscar pedido";
            this.btnFindByOrderID.UseVisualStyleBackColor = true;
            this.btnFindByOrderID.Click += new System.EventHandler(this.btnFindByOrderID_Click);
            // 
            // lblFillDate
            // 
            this.lblFillDate.Location = new System.Drawing.Point(40, 141);
            this.lblFillDate.Name = "lblFillDate";
            this.lblFillDate.Size = new System.Drawing.Size(343, 72);
            this.lblFillDate.TabIndex = 3;
            this.lblFillDate.Text = "Si esta rellenando un pedido, especifique la fecha rellenada";
            // 
            // dtpFillDate
            // 
            this.dtpFillDate.Location = new System.Drawing.Point(428, 152);
            this.dtpFillDate.Name = "dtpFillDate";
            this.dtpFillDate.Size = new System.Drawing.Size(330, 28);
            this.dtpFillDate.TabIndex = 4;
            // 
            // dgvCustomerOrders
            // 
            this.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerOrders.ColumnHeadersVisible = false;
            this.dgvCustomerOrders.Location = new System.Drawing.Point(44, 217);
            this.dgvCustomerOrders.Name = "dgvCustomerOrders";
            this.dgvCustomerOrders.ReadOnly = true;
            this.dgvCustomerOrders.RowHeadersWidth = 67;
            this.dgvCustomerOrders.RowTemplate.Height = 30;
            this.dgvCustomerOrders.Size = new System.Drawing.Size(714, 211);
            this.dgvCustomerOrders.TabIndex = 5;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(44, 474);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(170, 48);
            this.btnCancelOrder.TabIndex = 6;
            this.btnCancelOrder.Text = "Cancelar pedido";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnFillOrder
            // 
            this.btnFillOrder.Location = new System.Drawing.Point(240, 474);
            this.btnFillOrder.Name = "btnFillOrder";
            this.btnFillOrder.Size = new System.Drawing.Size(170, 48);
            this.btnFillOrder.TabIndex = 7;
            this.btnFillOrder.Text = "Rellenar pedido";
            this.btnFillOrder.UseVisualStyleBackColor = true;
            this.btnFillOrder.Click += new System.EventHandler(this.btnFillOrder_Click);
            // 
            // btnFinishUpdates
            // 
            this.btnFinishUpdates.Location = new System.Drawing.Point(588, 474);
            this.btnFinishUpdates.Name = "btnFinishUpdates";
            this.btnFinishUpdates.Size = new System.Drawing.Size(170, 48);
            this.btnFinishUpdates.TabIndex = 8;
            this.btnFinishUpdates.Text = "Finalizar";
            this.btnFinishUpdates.UseVisualStyleBackColor = true;
            this.btnFinishUpdates.Click += new System.EventHandler(this.btnFinishUpdates_Click);
            // 
            // FillOrCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.btnFinishUpdates);
            this.Controls.Add(this.btnFillOrder);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.dgvCustomerOrders);
            this.Controls.Add(this.dtpFillDate);
            this.Controls.Add(this.lblFillDate);
            this.Controls.Add(this.btnFindByOrderID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lblOrderId);
            this.Name = "FillOrCancel";
            this.Text = "Rellenar o cancelar un pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnFindByOrderID;
        private System.Windows.Forms.Label lblFillDate;
        private System.Windows.Forms.DateTimePicker dtpFillDate;
        private System.Windows.Forms.DataGridView dgvCustomerOrders;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnFillOrder;
        private System.Windows.Forms.Button btnFinishUpdates;
    }
}