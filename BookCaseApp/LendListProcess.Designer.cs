namespace BookCaseApp
{
    partial class LendListProcess
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.tbxUserTC = new System.Windows.Forms.TextBox();
            this.dgwLendList = new System.Windows.Forms.DataGridView();
            this.lendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lendDataSet = new BookCaseApp.LendDataSet();
            this.dgwRegisteredList = new System.Windows.Forms.DataGridView();
            this.lendIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTCDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendDateReceivedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendDayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LendStatusText2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendStatusDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lendsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deliveredDataSet = new BookCaseApp.DeliveredDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.lendsTableAdapter = new BookCaseApp.LendDataSetTableAdapters.LendsTableAdapter();
            this.lendsTableAdapter1 = new BookCaseApp.DeliveredDataSetTableAdapters.LendsTableAdapter();
            this.lendIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendDateReceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LendStatusText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLendList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRegisteredList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveredDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1123, 68);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 40);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(1211, 21);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(74, 28);
            this.btnSearchUser.TabIndex = 2;
            this.btnSearchUser.Text = "Bul";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // tbxUserTC
            // 
            this.tbxUserTC.Location = new System.Drawing.Point(1123, 24);
            this.tbxUserTC.Name = "tbxUserTC";
            this.tbxUserTC.Size = new System.Drawing.Size(82, 22);
            this.tbxUserTC.TabIndex = 3;
            // 
            // dgwLendList
            // 
            this.dgwLendList.AutoGenerateColumns = false;
            this.dgwLendList.BackgroundColor = System.Drawing.Color.White;
            this.dgwLendList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwLendList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgwLendList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLendList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lendIdDataGridViewTextBoxColumn,
            this.userTCDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.lendDateDataGridViewTextBoxColumn,
            this.lendDateReceivedDataGridViewTextBoxColumn,
            this.lendDayDataGridViewTextBoxColumn,
            this.LendStatusText,
            this.lendStatusDataGridViewCheckBoxColumn});
            this.dgwLendList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwLendList.DataSource = this.lendsBindingSource;
            this.dgwLendList.GridColor = System.Drawing.Color.White;
            this.dgwLendList.Location = new System.Drawing.Point(0, 0);
            this.dgwLendList.MultiSelect = false;
            this.dgwLendList.Name = "dgwLendList";
            this.dgwLendList.ReadOnly = true;
            this.dgwLendList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwLendList.RowHeadersVisible = false;
            this.dgwLendList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwLendList.RowTemplate.Height = 24;
            this.dgwLendList.Size = new System.Drawing.Size(1117, 360);
            this.dgwLendList.TabIndex = 4;
            // 
            // lendsBindingSource
            // 
            this.lendsBindingSource.DataMember = "Lends";
            this.lendsBindingSource.DataSource = this.lendDataSet;
            // 
            // lendDataSet
            // 
            this.lendDataSet.DataSetName = "LendDataSet";
            this.lendDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgwRegisteredList
            // 
            this.dgwRegisteredList.AutoGenerateColumns = false;
            this.dgwRegisteredList.BackgroundColor = System.Drawing.Color.White;
            this.dgwRegisteredList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwRegisteredList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgwRegisteredList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRegisteredList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lendIdDataGridViewTextBoxColumn1,
            this.userTCDataGridViewTextBoxColumn1,
            this.bookNameDataGridViewTextBoxColumn1,
            this.lendDateDataGridViewTextBoxColumn1,
            this.lendDateReceivedDataGridViewTextBoxColumn1,
            this.lendDayDataGridViewTextBoxColumn1,
            this.LendStatusText2,
            this.lendStatusDataGridViewCheckBoxColumn1});
            this.dgwRegisteredList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwRegisteredList.DataSource = this.lendsBindingSource1;
            this.dgwRegisteredList.GridColor = System.Drawing.Color.White;
            this.dgwRegisteredList.Location = new System.Drawing.Point(0, 358);
            this.dgwRegisteredList.MultiSelect = false;
            this.dgwRegisteredList.Name = "dgwRegisteredList";
            this.dgwRegisteredList.ReadOnly = true;
            this.dgwRegisteredList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwRegisteredList.RowHeadersVisible = false;
            this.dgwRegisteredList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwRegisteredList.RowTemplate.Height = 24;
            this.dgwRegisteredList.Size = new System.Drawing.Size(1117, 360);
            this.dgwRegisteredList.TabIndex = 5;
            // 
            // lendIdDataGridViewTextBoxColumn1
            // 
            this.lendIdDataGridViewTextBoxColumn1.DataPropertyName = "LendId";
            this.lendIdDataGridViewTextBoxColumn1.HeaderText = "LendId";
            this.lendIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lendIdDataGridViewTextBoxColumn1.Name = "lendIdDataGridViewTextBoxColumn1";
            this.lendIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lendIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // userTCDataGridViewTextBoxColumn1
            // 
            this.userTCDataGridViewTextBoxColumn1.DataPropertyName = "UserTC";
            this.userTCDataGridViewTextBoxColumn1.HeaderText = "UserTC";
            this.userTCDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.userTCDataGridViewTextBoxColumn1.Name = "userTCDataGridViewTextBoxColumn1";
            this.userTCDataGridViewTextBoxColumn1.ReadOnly = true;
            this.userTCDataGridViewTextBoxColumn1.Width = 125;
            // 
            // bookNameDataGridViewTextBoxColumn1
            // 
            this.bookNameDataGridViewTextBoxColumn1.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn1.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn1.Name = "bookNameDataGridViewTextBoxColumn1";
            this.bookNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bookNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lendDateDataGridViewTextBoxColumn1
            // 
            this.lendDateDataGridViewTextBoxColumn1.DataPropertyName = "LendDate";
            this.lendDateDataGridViewTextBoxColumn1.HeaderText = "LendDate";
            this.lendDateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lendDateDataGridViewTextBoxColumn1.Name = "lendDateDataGridViewTextBoxColumn1";
            this.lendDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lendDateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lendDateReceivedDataGridViewTextBoxColumn1
            // 
            this.lendDateReceivedDataGridViewTextBoxColumn1.DataPropertyName = "LendDateReceived";
            this.lendDateReceivedDataGridViewTextBoxColumn1.HeaderText = "LendDateReceived";
            this.lendDateReceivedDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lendDateReceivedDataGridViewTextBoxColumn1.Name = "lendDateReceivedDataGridViewTextBoxColumn1";
            this.lendDateReceivedDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lendDateReceivedDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lendDayDataGridViewTextBoxColumn1
            // 
            this.lendDayDataGridViewTextBoxColumn1.DataPropertyName = "LendDay";
            this.lendDayDataGridViewTextBoxColumn1.HeaderText = "LendDay";
            this.lendDayDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lendDayDataGridViewTextBoxColumn1.Name = "lendDayDataGridViewTextBoxColumn1";
            this.lendDayDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lendDayDataGridViewTextBoxColumn1.Width = 125;
            // 
            // LendStatusText2
            // 
            this.LendStatusText2.HeaderText = "LendStatusText";
            this.LendStatusText2.MinimumWidth = 6;
            this.LendStatusText2.Name = "LendStatusText2";
            this.LendStatusText2.ReadOnly = true;
            this.LendStatusText2.Width = 125;
            // 
            // lendStatusDataGridViewCheckBoxColumn1
            // 
            this.lendStatusDataGridViewCheckBoxColumn1.DataPropertyName = "LendStatus";
            this.lendStatusDataGridViewCheckBoxColumn1.HeaderText = "LendStatus";
            this.lendStatusDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.lendStatusDataGridViewCheckBoxColumn1.Name = "lendStatusDataGridViewCheckBoxColumn1";
            this.lendStatusDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.lendStatusDataGridViewCheckBoxColumn1.Visible = false;
            this.lendStatusDataGridViewCheckBoxColumn1.Width = 125;
            // 
            // lendsBindingSource1
            // 
            this.lendsBindingSource1.DataMember = "Lends";
            this.lendsBindingSource1.DataSource = this.deliveredDataSet;
            // 
            // deliveredDataSet
            // 
            this.deliveredDataSet.DataSetName = "DeliveredDataSet";
            this.deliveredDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Button Koy 2 Table birleştir";
            // 
            // lendsTableAdapter
            // 
            this.lendsTableAdapter.ClearBeforeFill = true;
            // 
            // lendsTableAdapter1
            // 
            this.lendsTableAdapter1.ClearBeforeFill = true;
            // 
            // lendIdDataGridViewTextBoxColumn
            // 
            this.lendIdDataGridViewTextBoxColumn.DataPropertyName = "LendId";
            this.lendIdDataGridViewTextBoxColumn.HeaderText = "LendId";
            this.lendIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lendIdDataGridViewTextBoxColumn.Name = "lendIdDataGridViewTextBoxColumn";
            this.lendIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.lendIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // userTCDataGridViewTextBoxColumn
            // 
            this.userTCDataGridViewTextBoxColumn.DataPropertyName = "UserTC";
            this.userTCDataGridViewTextBoxColumn.HeaderText = "UserTC";
            this.userTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userTCDataGridViewTextBoxColumn.Name = "userTCDataGridViewTextBoxColumn";
            this.userTCDataGridViewTextBoxColumn.ReadOnly = true;
            this.userTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lendDateDataGridViewTextBoxColumn
            // 
            this.lendDateDataGridViewTextBoxColumn.DataPropertyName = "LendDate";
            this.lendDateDataGridViewTextBoxColumn.HeaderText = "LendDate";
            this.lendDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lendDateDataGridViewTextBoxColumn.Name = "lendDateDataGridViewTextBoxColumn";
            this.lendDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.lendDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // lendDateReceivedDataGridViewTextBoxColumn
            // 
            this.lendDateReceivedDataGridViewTextBoxColumn.DataPropertyName = "LendDateReceived";
            this.lendDateReceivedDataGridViewTextBoxColumn.HeaderText = "LendDateReceived";
            this.lendDateReceivedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lendDateReceivedDataGridViewTextBoxColumn.Name = "lendDateReceivedDataGridViewTextBoxColumn";
            this.lendDateReceivedDataGridViewTextBoxColumn.ReadOnly = true;
            this.lendDateReceivedDataGridViewTextBoxColumn.Visible = false;
            this.lendDateReceivedDataGridViewTextBoxColumn.Width = 125;
            // 
            // lendDayDataGridViewTextBoxColumn
            // 
            this.lendDayDataGridViewTextBoxColumn.DataPropertyName = "LendDay";
            this.lendDayDataGridViewTextBoxColumn.HeaderText = "LendDay";
            this.lendDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lendDayDataGridViewTextBoxColumn.Name = "lendDayDataGridViewTextBoxColumn";
            this.lendDayDataGridViewTextBoxColumn.ReadOnly = true;
            this.lendDayDataGridViewTextBoxColumn.Width = 125;
            // 
            // LendStatusText
            // 
            this.LendStatusText.HeaderText = "LendStatusText";
            this.LendStatusText.MinimumWidth = 6;
            this.LendStatusText.Name = "LendStatusText";
            this.LendStatusText.ReadOnly = true;
            this.LendStatusText.Width = 125;
            // 
            // lendStatusDataGridViewCheckBoxColumn
            // 
            this.lendStatusDataGridViewCheckBoxColumn.DataPropertyName = "LendStatus";
            this.lendStatusDataGridViewCheckBoxColumn.HeaderText = "LendStatus";
            this.lendStatusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.lendStatusDataGridViewCheckBoxColumn.Name = "lendStatusDataGridViewCheckBoxColumn";
            this.lendStatusDataGridViewCheckBoxColumn.ReadOnly = true;
            this.lendStatusDataGridViewCheckBoxColumn.Visible = false;
            this.lendStatusDataGridViewCheckBoxColumn.Width = 125;
            // 
            // LendListProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 738);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwRegisteredList);
            this.Controls.Add(this.dgwLendList);
            this.Controls.Add(this.tbxUserTC);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.btnRefresh);
            this.Name = "LendListProcess";
            this.Text = "LendListProcess";
            this.Load += new System.EventHandler(this.LendListProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLendList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRegisteredList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveredDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox tbxUserTC;
        private System.Windows.Forms.DataGridView dgwLendList;
        private System.Windows.Forms.DataGridView dgwRegisteredList;
        private System.Windows.Forms.Label label1;
        private LendDataSet lendDataSet;
        private System.Windows.Forms.BindingSource lendsBindingSource;
        private LendDataSetTableAdapters.LendsTableAdapter lendsTableAdapter;
        private DeliveredDataSet deliveredDataSet;
        private DeliveredDataSetTableAdapters.LendsTableAdapter lendsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTCDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendDateReceivedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendDayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LendStatusText2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lendStatusDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource lendsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendDateReceivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LendStatusText;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lendStatusDataGridViewCheckBoxColumn;
    }
}