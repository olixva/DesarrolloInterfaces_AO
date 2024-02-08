namespace ADONetExample
{
    partial class NewCustomer
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
            this.grpBoxCuenta = new System.Windows.Forms.GroupBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.grpbCrearPedido = new System.Windows.Forms.GroupBox();
            this.lblFechaPedido = new System.Windows.Forms.Label();
            this.llblCantidadPedido = new System.Windows.Forms.Label();
            this.numOrderAmount = new System.Windows.Forms.NumericUpDown();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnAddAnotherAccount = new System.Windows.Forms.Button();
            this.btnAddFinish = new System.Windows.Forms.Button();
            this.grpBoxCuenta.SuspendLayout();
            this.grpbCrearPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxCuenta
            // 
            this.grpBoxCuenta.Controls.Add(this.txtCustomerID);
            this.grpBoxCuenta.Controls.Add(this.txtCustomerName);
            this.grpBoxCuenta.Controls.Add(this.lblCustomerID);
            this.grpBoxCuenta.Controls.Add(this.lblCustomerName);
            this.grpBoxCuenta.Location = new System.Drawing.Point(44, 53);
            this.grpBoxCuenta.Name = "grpBoxCuenta";
            this.grpBoxCuenta.Size = new System.Drawing.Size(437, 147);
            this.grpBoxCuenta.TabIndex = 0;
            this.grpBoxCuenta.TabStop = false;
            this.grpBoxCuenta.Text = "Agregar cuenta";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(16, 48);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(164, 22);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Nombre del cliente:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(16, 95);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(194, 22);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "Identificador de cliente:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(206, 48);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(214, 28);
            this.txtCustomerName.TabIndex = 2;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(241, 95);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(179, 28);
            this.txtCustomerID.TabIndex = 3;
            // 
            // grpbCrearPedido
            // 
            this.grpbCrearPedido.Controls.Add(this.dtpOrderDate);
            this.grpbCrearPedido.Controls.Add(this.numOrderAmount);
            this.grpbCrearPedido.Controls.Add(this.lblFechaPedido);
            this.grpbCrearPedido.Controls.Add(this.llblCantidadPedido);
            this.grpbCrearPedido.Location = new System.Drawing.Point(44, 224);
            this.grpbCrearPedido.Name = "grpbCrearPedido";
            this.grpbCrearPedido.Size = new System.Drawing.Size(437, 147);
            this.grpbCrearPedido.TabIndex = 4;
            this.grpbCrearPedido.TabStop = false;
            this.grpbCrearPedido.Text = "Agregar cuenta";
            // 
            // lblFechaPedido
            // 
            this.lblFechaPedido.AutoSize = true;
            this.lblFechaPedido.Location = new System.Drawing.Point(16, 95);
            this.lblFechaPedido.Name = "lblFechaPedido";
            this.lblFechaPedido.Size = new System.Drawing.Size(158, 22);
            this.lblFechaPedido.TabIndex = 1;
            this.lblFechaPedido.Text = "Fecha del pedido: ";
            // 
            // llblCantidadPedido
            // 
            this.llblCantidadPedido.AutoSize = true;
            this.llblCantidadPedido.Location = new System.Drawing.Point(16, 48);
            this.llblCantidadPedido.Name = "llblCantidadPedido";
            this.llblCantidadPedido.Size = new System.Drawing.Size(176, 22);
            this.llblCantidadPedido.TabIndex = 0;
            this.llblCantidadPedido.Text = "Cantidad de pedido: ";
            // 
            // numOrderAmount
            // 
            this.numOrderAmount.Location = new System.Drawing.Point(218, 41);
            this.numOrderAmount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numOrderAmount.Name = "numOrderAmount";
            this.numOrderAmount.Size = new System.Drawing.Size(182, 28);
            this.numOrderAmount.TabIndex = 2;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(206, 95);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 28);
            this.dtpOrderDate.TabIndex = 3;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(564, 115);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(173, 55);
            this.btnCreateAccount.TabIndex = 5;
            this.btnCreateAccount.Text = "Crear cuenta";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(545, 292);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(173, 55);
            this.btnPlaceOrder.TabIndex = 6;
            this.btnPlaceOrder.Text = "Realizar pedido";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // btnAddAnotherAccount
            // 
            this.btnAddAnotherAccount.Location = new System.Drawing.Point(427, 392);
            this.btnAddAnotherAccount.Name = "btnAddAnotherAccount";
            this.btnAddAnotherAccount.Size = new System.Drawing.Size(291, 55);
            this.btnAddAnotherAccount.TabIndex = 7;
            this.btnAddAnotherAccount.Text = "Agregar otra cuenta";
            this.btnAddAnotherAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddFinish
            // 
            this.btnAddFinish.Location = new System.Drawing.Point(44, 392);
            this.btnAddFinish.Name = "btnAddFinish";
            this.btnAddFinish.Size = new System.Drawing.Size(173, 55);
            this.btnAddFinish.TabIndex = 8;
            this.btnAddFinish.Text = "Finalizar";
            this.btnAddFinish.UseVisualStyleBackColor = true;
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.btnAddFinish);
            this.Controls.Add(this.btnAddAnotherAccount);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.grpbCrearPedido);
            this.Controls.Add(this.grpBoxCuenta);
            this.Name = "NewCustomer";
            this.Text = "Cuenta y pedidos nuevos";
            this.grpBoxCuenta.ResumeLayout(false);
            this.grpBoxCuenta.PerformLayout();
            this.grpbCrearPedido.ResumeLayout(false);
            this.grpbCrearPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxCuenta;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.GroupBox grpbCrearPedido;
        private System.Windows.Forms.Label lblFechaPedido;
        private System.Windows.Forms.Label llblCantidadPedido;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.NumericUpDown numOrderAmount;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnAddAnotherAccount;
        private System.Windows.Forms.Button btnAddFinish;
    }
}