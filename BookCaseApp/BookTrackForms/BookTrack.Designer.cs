namespace BookCaseApp.BookTrackForms
{
    partial class BookTrack
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
            this.dgwBookList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.registeredData = new BookCaseApp.RegisteredData();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new BookCaseApp.RegisteredDataTableAdapters.BooksTableAdapter();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bookStatusTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxSearchBook = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Takip";
            // 
            // dgwBookList
            // 
            this.dgwBookList.AutoGenerateColumns = false;
            this.dgwBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.ıSBNDataGridViewTextBoxColumn,
            this.bookDateDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.pageNumberDataGridViewTextBoxColumn,
            this.bookStatusDataGridViewCheckBoxColumn,
            this.bookStatusTextDataGridViewTextBoxColumn});
            this.dgwBookList.DataSource = this.booksBindingSource;
            this.dgwBookList.Location = new System.Drawing.Point(15, 117);
            this.dgwBookList.Name = "dgwBookList";
            this.dgwBookList.RowHeadersWidth = 51;
            this.dgwBookList.RowTemplate.Height = 24;
            this.dgwBookList.Size = new System.Drawing.Size(1178, 330);
            this.dgwBookList.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(158, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 37);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Kitap Bul";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // registeredData
            // 
            this.registeredData.DataSetName = "RegisteredData";
            this.registeredData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.registeredData;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "BookId";
            this.bookIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            this.bookIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıSBNDataGridViewTextBoxColumn
            // 
            this.ıSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.ıSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.ıSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıSBNDataGridViewTextBoxColumn.Name = "ıSBNDataGridViewTextBoxColumn";
            this.ıSBNDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookDateDataGridViewTextBoxColumn
            // 
            this.bookDateDataGridViewTextBoxColumn.DataPropertyName = "BookDate";
            this.bookDateDataGridViewTextBoxColumn.HeaderText = "BookDate";
            this.bookDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookDateDataGridViewTextBoxColumn.Name = "bookDateDataGridViewTextBoxColumn";
            this.bookDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            this.authorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // pageNumberDataGridViewTextBoxColumn
            // 
            this.pageNumberDataGridViewTextBoxColumn.DataPropertyName = "PageNumber";
            this.pageNumberDataGridViewTextBoxColumn.HeaderText = "PageNumber";
            this.pageNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pageNumberDataGridViewTextBoxColumn.Name = "pageNumberDataGridViewTextBoxColumn";
            this.pageNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookStatusDataGridViewCheckBoxColumn
            // 
            this.bookStatusDataGridViewCheckBoxColumn.DataPropertyName = "BookStatus";
            this.bookStatusDataGridViewCheckBoxColumn.HeaderText = "BookStatus";
            this.bookStatusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.bookStatusDataGridViewCheckBoxColumn.Name = "bookStatusDataGridViewCheckBoxColumn";
            this.bookStatusDataGridViewCheckBoxColumn.Width = 125;
            // 
            // bookStatusTextDataGridViewTextBoxColumn
            // 
            this.bookStatusTextDataGridViewTextBoxColumn.DataPropertyName = "BookStatusText";
            this.bookStatusTextDataGridViewTextBoxColumn.HeaderText = "BookStatusText";
            this.bookStatusTextDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookStatusTextDataGridViewTextBoxColumn.Name = "bookStatusTextDataGridViewTextBoxColumn";
            this.bookStatusTextDataGridViewTextBoxColumn.Width = 125;
            // 
            // cbxSearchBook
            // 
            this.cbxSearchBook.FormattingEnabled = true;
            this.cbxSearchBook.Location = new System.Drawing.Point(32, 81);
            this.cbxSearchBook.Name = "cbxSearchBook";
            this.cbxSearchBook.Size = new System.Drawing.Size(110, 24);
            this.cbxSearchBook.TabIndex = 3;
            // 
            // BookTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1229, 517);
            this.Controls.Add(this.cbxSearchBook);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgwBookList);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "BookTrack";
            this.Text = "BookTrack";
            this.Load += new System.EventHandler(this.BookTrack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwBookList;
        private System.Windows.Forms.Button btnSearch;
        private RegisteredData registeredData;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private RegisteredDataTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bookStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookStatusTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbxSearchBook;
    }
}