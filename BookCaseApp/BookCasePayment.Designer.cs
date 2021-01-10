namespace BookCaseApp
{
    partial class BookCasePayment
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
            this.components = new System.ComponentModel.Container();
            this.dgwPayment = new System.Windows.Forms.DataGridView();
            this.paymentData = new BookCaseApp.PaymentData();
            this.paymentsTableAdapter = new BookCaseApp.PaymentDataTableAdapters.PaymentsTableAdapter();
            this.paymentData1 = new BookCaseApp.PaymentData();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendDateReceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwPayment
            // 
            this.dgwPayment.AutoGenerateColumns = false;
            this.dgwPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentIdDataGridViewTextBoxColumn,
            this.lendIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userLastNameDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.lendDateDataGridViewTextBoxColumn,
            this.lendDateReceivedDataGridViewTextBoxColumn,
            this.lendDayDataGridViewTextBoxColumn,
            this.delayDayDataGridViewTextBoxColumn,
            this.paymentAmountDataGridViewTextBoxColumn});
            this.dgwPayment.DataSource = this.paymentsBindingSource;
            this.dgwPayment.Location = new System.Drawing.Point(12, 36);
            this.dgwPayment.Name = "dgwPayment";
            this.dgwPayment.RowHeadersWidth = 51;
            this.dgwPayment.RowTemplate.Height = 24;
            this.dgwPayment.Size = new System.Drawing.Size(1176, 376);
            this.dgwPayment.TabIndex = 0;
            // 
            // paymentData
            // 
            this.paymentData.DataSetName = "PaymentData";
            this.paymentData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // paymentData1
            // 
            this.paymentData1.DataSetName = "PaymentData";
            this.paymentData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.paymentData1;
            // 
            // paymentIdDataGridViewTextBoxColumn
            // 
            this.paymentIdDataGridViewTextBoxColumn.DataPropertyName = "Payment_Id";
            this.paymentIdDataGridViewTextBoxColumn.HeaderText = "Payment_Id";
            this.paymentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentIdDataGridViewTextBoxColumn.Name = "paymentIdDataGridViewTextBoxColumn";
            this.paymentIdDataGridViewTextBoxColumn.Visible = false;
            this.paymentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // lendIdDataGridViewTextBoxColumn
            // 
            this.lendIdDataGridViewTextBoxColumn.DataPropertyName = "LendId";
            this.lendIdDataGridViewTextBoxColumn.HeaderText = "LendId";
            this.lendIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lendIdDataGridViewTextBoxColumn.Name = "lendIdDataGridViewTextBoxColumn";
            this.lendIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // userLastNameDataGridViewTextBoxColumn
            // 
            this.userLastNameDataGridViewTextBoxColumn.DataPropertyName = "UserLastName";
            this.userLastNameDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            this.userLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userLastNameDataGridViewTextBoxColumn.Name = "userLastNameDataGridViewTextBoxColumn";
            this.userLastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Kitap İsmi";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lendDateDataGridViewTextBoxColumn
            // 
            this.lendDateDataGridViewTextBoxColumn.DataPropertyName = "LendDate";
            this.lendDateDataGridViewTextBoxColumn.HeaderText = "Veriliş Tarihi";
            this.lendDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lendDateDataGridViewTextBoxColumn.Name = "lendDateDataGridViewTextBoxColumn";
            this.lendDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // lendDateReceivedDataGridViewTextBoxColumn
            // 
            this.lendDateReceivedDataGridViewTextBoxColumn.DataPropertyName = "LendDateReceived";
            this.lendDateReceivedDataGridViewTextBoxColumn.HeaderText = "Teslim Tarihi";
            this.lendDateReceivedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lendDateReceivedDataGridViewTextBoxColumn.Name = "lendDateReceivedDataGridViewTextBoxColumn";
            this.lendDateReceivedDataGridViewTextBoxColumn.Width = 125;
            // 
            // lendDayDataGridViewTextBoxColumn
            // 
            this.lendDayDataGridViewTextBoxColumn.DataPropertyName = "LendDay";
            this.lendDayDataGridViewTextBoxColumn.HeaderText = "Geçen Gün";
            this.lendDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lendDayDataGridViewTextBoxColumn.Name = "lendDayDataGridViewTextBoxColumn";
            this.lendDayDataGridViewTextBoxColumn.Width = 125;
            // 
            // delayDayDataGridViewTextBoxColumn
            // 
            this.delayDayDataGridViewTextBoxColumn.DataPropertyName = "DelayDay";
            this.delayDayDataGridViewTextBoxColumn.HeaderText = "Geciken Gün";
            this.delayDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.delayDayDataGridViewTextBoxColumn.Name = "delayDayDataGridViewTextBoxColumn";
            this.delayDayDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentAmountDataGridViewTextBoxColumn
            // 
            this.paymentAmountDataGridViewTextBoxColumn.DataPropertyName = "PaymentAmount";
            this.paymentAmountDataGridViewTextBoxColumn.HeaderText = "Ceza Ücreti";
            this.paymentAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentAmountDataGridViewTextBoxColumn.Name = "paymentAmountDataGridViewTextBoxColumn";
            this.paymentAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // BookCasePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 455);
            this.Controls.Add(this.dgwPayment);
            this.Name = "BookCasePayment";
            this.Text = "BookCasePayment";
            this.Load += new System.EventHandler(this.BookCasePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPayment;
        private PaymentData paymentData;
        private PaymentDataTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private PaymentData paymentData1;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendDateReceivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentAmountDataGridViewTextBoxColumn;
    }
}