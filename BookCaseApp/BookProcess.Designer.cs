namespace BookCaseApp
{
    partial class BookProcess
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
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.btnBookUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxUpdateAuthor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxUpdateISBN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgwBookList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxUpdatePageNumber = new System.Windows.Forms.TextBox();
            this.cbxUpdateType = new System.Windows.Forms.ComboBox();
            this.dtpUpdateDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxPageNumber = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxRemoveWithISBN = new System.Windows.Forms.TextBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.tbxUpdate = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Location = new System.Drawing.Point(31, 23);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(108, 30);
            this.btnRemoveBook.TabIndex = 27;
            this.btnRemoveBook.Text = "Sil";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // btnBookUpdate
            // 
            this.btnBookUpdate.Location = new System.Drawing.Point(302, 157);
            this.btnBookUpdate.Name = "btnBookUpdate";
            this.btnBookUpdate.Size = new System.Drawing.Size(162, 30);
            this.btnBookUpdate.TabIndex = 26;
            this.btnBookUpdate.Text = "Güncelle";
            this.btnBookUpdate.UseVisualStyleBackColor = true;
            this.btnBookUpdate.Click += new System.EventHandler(this.btnBookUpdate_Click);
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(81, 38);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(162, 22);
            this.tbxUpdateName.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Kitap Ad :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Türü:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Sayfa No:";
            // 
            // tbxUpdateAuthor
            // 
            this.tbxUpdateAuthor.Location = new System.Drawing.Point(345, 68);
            this.tbxUpdateAuthor.Name = "tbxUpdateAuthor";
            this.tbxUpdateAuthor.Size = new System.Drawing.Size(162, 22);
            this.tbxUpdateAuthor.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Yazar :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "ISBN :";
            // 
            // tbxUpdateISBN
            // 
            this.tbxUpdateISBN.Location = new System.Drawing.Point(81, 108);
            this.tbxUpdateISBN.Name = "tbxUpdateISBN";
            this.tbxUpdateISBN.Size = new System.Drawing.Size(162, 22);
            this.tbxUpdateISBN.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 552);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgwBookList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1102, 266);
            this.panel3.TabIndex = 19;
            // 
            // dgwBookList
            // 
            this.dgwBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBookList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwBookList.Location = new System.Drawing.Point(0, 0);
            this.dgwBookList.Name = "dgwBookList";
            this.dgwBookList.RowHeadersWidth = 51;
            this.dgwBookList.RowTemplate.Height = 24;
            this.dgwBookList.Size = new System.Drawing.Size(1102, 263);
            this.dgwBookList.TabIndex = 18;
            this.dgwBookList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBookList_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxUpdate);
            this.groupBox2.Controls.Add(this.tbxUpdatePageNumber);
            this.groupBox2.Controls.Add(this.cbxUpdateType);
            this.groupBox2.Controls.Add(this.dtpUpdateDate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnBookUpdate);
            this.groupBox2.Controls.Add(this.tbxUpdateName);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbxUpdateAuthor);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbxUpdateISBN);
            this.groupBox2.Location = new System.Drawing.Point(511, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt Güncelle";
            // 
            // tbxUpdatePageNumber
            // 
            this.tbxUpdatePageNumber.Location = new System.Drawing.Point(345, 108);
            this.tbxUpdatePageNumber.Name = "tbxUpdatePageNumber";
            this.tbxUpdatePageNumber.Size = new System.Drawing.Size(162, 22);
            this.tbxUpdatePageNumber.TabIndex = 29;
            // 
            // cbxUpdateType
            // 
            this.cbxUpdateType.FormattingEnabled = true;
            this.cbxUpdateType.Items.AddRange(new object[] {
            "Biyografi",
            "Edebiyat",
            "Felsefe",
            "Gezi",
            "Hikaye",
            "Roman",
            "Hikaye",
            "Bilim",
            "Polisiye"});
            this.cbxUpdateType.Location = new System.Drawing.Point(81, 71);
            this.cbxUpdateType.Name = "cbxUpdateType";
            this.cbxUpdateType.Size = new System.Drawing.Size(162, 24);
            this.cbxUpdateType.TabIndex = 16;
            // 
            // dtpUpdateDate
            // 
            this.dtpUpdateDate.Location = new System.Drawing.Point(345, 34);
            this.dtpUpdateDate.Name = "dtpUpdateDate";
            this.dtpUpdateDate.Size = new System.Drawing.Size(162, 22);
            this.dtpUpdateDate.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Yayım Tarih:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxPageNumber);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.cbxType);
            this.groupBox1.Controls.Add(this.btnBookAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxAuthor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxISBN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Location = new System.Drawing.Point(-1, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Ekle";
            // 
            // tbxPageNumber
            // 
            this.tbxPageNumber.Location = new System.Drawing.Point(339, 124);
            this.tbxPageNumber.Name = "tbxPageNumber";
            this.tbxPageNumber.Size = new System.Drawing.Size(162, 22);
            this.tbxPageNumber.TabIndex = 16;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(339, 35);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(162, 22);
            this.dtpDate.TabIndex = 15;
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Biyografi",
            "Edebiyat",
            "Felsefe",
            "Gezi",
            "Hikaye",
            "Roman",
            "Hikaye",
            "Bilim",
            "Polisiye"});
            this.cbxType.Location = new System.Drawing.Point(85, 76);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(162, 24);
            this.cbxType.TabIndex = 14;
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(178, 161);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(162, 30);
            this.btnBookAdd.TabIndex = 13;
            this.btnBookAdd.Text = "Ekle";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sayfa No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Yazar :";
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.Location = new System.Drawing.Point(339, 68);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.Size = new System.Drawing.Size(162, 22);
            this.tbxAuthor.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yayım Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "ISBN :";
            // 
            // tbxISBN
            // 
            this.tbxISBN.Location = new System.Drawing.Point(85, 127);
            this.tbxISBN.Name = "tbxISBN";
            this.tbxISBN.Size = new System.Drawing.Size(162, 22);
            this.tbxISBN.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Türü:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Ad :";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(85, 36);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(162, 22);
            this.tbxName.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearchBook);
            this.panel2.Controls.Add(this.btnRemoveBook);
            this.panel2.Controls.Add(this.tbxRemoveWithISBN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1102, 72);
            this.panel2.TabIndex = 14;
            // 
            // tbxRemoveWithISBN
            // 
            this.tbxRemoveWithISBN.Location = new System.Drawing.Point(156, 27);
            this.tbxRemoveWithISBN.Name = "tbxRemoveWithISBN";
            this.tbxRemoveWithISBN.Size = new System.Drawing.Size(147, 22);
            this.tbxRemoveWithISBN.TabIndex = 12;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(324, 23);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(108, 30);
            this.btnSearchBook.TabIndex = 28;
            this.btnSearchBook.Text = "Bul";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // tbxUpdate
            // 
            this.tbxUpdate.Location = new System.Drawing.Point(137, 161);
            this.tbxUpdate.Name = "tbxUpdate";
            this.tbxUpdate.Size = new System.Drawing.Size(147, 22);
            this.tbxUpdate.TabIndex = 29;
            // 
            // BookProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 552);
            this.Controls.Add(this.panel1);
            this.Name = "BookProcess";
            this.Text = "BookProcess";
            this.Load += new System.EventHandler(this.BookProcess_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Button btnBookUpdate;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxUpdateAuthor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxUpdateISBN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxRemoveWithISBN;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox cbxUpdateType;
        private System.Windows.Forms.DateTimePicker dtpUpdateDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxPageNumber;
        private System.Windows.Forms.TextBox tbxUpdatePageNumber;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgwBookList;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.TextBox tbxUpdate;
    }
}