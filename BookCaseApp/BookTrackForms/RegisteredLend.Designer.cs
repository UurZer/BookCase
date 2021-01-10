namespace BookCaseApp.BookTrackForms
{
    partial class RegisteredLend
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgwLendRegistered = new System.Windows.Forms.DataGridView();
            this.registeredDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registeredData = new BookCaseApp.RegisteredData();
            this.lendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lendsTableAdapter = new BookCaseApp.RegisteredDataTableAdapters.LendsTableAdapter();
            this.lendIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendDateReceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lendDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.cbxBookName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLendRegistered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emanet Kayıtları";
            // 
            // dgwLendRegistered
            // 
            this.dgwLendRegistered.AutoGenerateColumns = false;
            this.dgwLendRegistered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLendRegistered.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lendIdDataGridViewTextBoxColumn,
            this.userTCDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userLastNameDataGridViewTextBoxColumn,
            this.ıSBNDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.lendDateDataGridViewTextBoxColumn,
            this.lendDateReceivedDataGridViewTextBoxColumn,
            this.lendStatusDataGridViewCheckBoxColumn,
            this.lendDayDataGridViewTextBoxColumn});
            this.dgwLendRegistered.DataSource = this.lendsBindingSource;
            this.dgwLendRegistered.Location = new System.Drawing.Point(12, 124);
            this.dgwLendRegistered.Name = "dgwLendRegistered";
            this.dgwLendRegistered.RowHeadersWidth = 51;
            this.dgwLendRegistered.RowTemplate.Height = 24;
            this.dgwLendRegistered.Size = new System.Drawing.Size(1179, 288);
            this.dgwLendRegistered.TabIndex = 1;
            // 
            // registeredDataBindingSource
            // 
            this.registeredDataBindingSource.DataSource = this.registeredData;
            this.registeredDataBindingSource.Position = 0;
            // 
            // registeredData
            // 
            this.registeredData.DataSetName = "RegisteredData";
            this.registeredData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lendsBindingSource
            // 
            this.lendsBindingSource.DataMember = "Lends";
            this.lendsBindingSource.DataSource = this.registeredDataBindingSource;
            // 
            // lendsTableAdapter
            // 
            this.lendsTableAdapter.ClearBeforeFill = true;
            // 
            // lendIdDataGridViewTextBoxColumn
            // 
            this.lendIdDataGridViewTextBoxColumn.DataPropertyName = "LendId";
            this.lendIdDataGridViewTextBoxColumn.HeaderText = "LendId";
            this.lendIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lendIdDataGridViewTextBoxColumn.Name = "lendIdDataGridViewTextBoxColumn";
            this.lendIdDataGridViewTextBoxColumn.Visible = false;
            this.lendIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // userTCDataGridViewTextBoxColumn
            // 
            this.userTCDataGridViewTextBoxColumn.DataPropertyName = "UserTC";
            this.userTCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.userTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userTCDataGridViewTextBoxColumn.Name = "userTCDataGridViewTextBoxColumn";
            this.userTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "İsim";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // userLastNameDataGridViewTextBoxColumn
            // 
            this.userLastNameDataGridViewTextBoxColumn.DataPropertyName = "UserLastName";
            this.userLastNameDataGridViewTextBoxColumn.HeaderText = "Soyisim";
            this.userLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userLastNameDataGridViewTextBoxColumn.Name = "userLastNameDataGridViewTextBoxColumn";
            this.userLastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıSBNDataGridViewTextBoxColumn
            // 
            this.ıSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.ıSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.ıSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıSBNDataGridViewTextBoxColumn.Name = "ıSBNDataGridViewTextBoxColumn";
            this.ıSBNDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Kitap Adı";
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
            // lendStatusDataGridViewCheckBoxColumn
            // 
            this.lendStatusDataGridViewCheckBoxColumn.DataPropertyName = "LendStatus";
            this.lendStatusDataGridViewCheckBoxColumn.HeaderText = "Teslim Durumu";
            this.lendStatusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.lendStatusDataGridViewCheckBoxColumn.Name = "lendStatusDataGridViewCheckBoxColumn";
            this.lendStatusDataGridViewCheckBoxColumn.Width = 125;
            // 
            // lendDayDataGridViewTextBoxColumn
            // 
            this.lendDayDataGridViewTextBoxColumn.DataPropertyName = "LendDay";
            this.lendDayDataGridViewTextBoxColumn.HeaderText = "Geçen Gün";
            this.lendDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lendDayDataGridViewTextBoxColumn.Name = "lendDayDataGridViewTextBoxColumn";
            this.lendDayDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(168, 77);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(98, 32);
            this.btnSearchBook.TabIndex = 2;
            this.btnSearchBook.Text = "Kitap Bul";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // cbxBookName
            // 
            this.cbxBookName.FormattingEnabled = true;
            this.cbxBookName.Location = new System.Drawing.Point(41, 82);
            this.cbxBookName.Name = "cbxBookName";
            this.cbxBookName.Size = new System.Drawing.Size(121, 24);
            this.cbxBookName.TabIndex = 3;
            // 
            // RegisteredLend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1238, 493);
            this.Controls.Add(this.cbxBookName);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.dgwLendRegistered);
            this.Controls.Add(this.label1);
            this.Name = "RegisteredLend";
            this.Text = "RegisteredLend";
            this.Load += new System.EventHandler(this.RegisteredLend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLendRegistered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwLendRegistered;
        private System.Windows.Forms.BindingSource registeredDataBindingSource;
        private RegisteredData registeredData;
        private System.Windows.Forms.BindingSource lendsBindingSource;
        private RegisteredDataTableAdapters.LendsTableAdapter lendsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendDateReceivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lendStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.ComboBox cbxBookName;
    }
}