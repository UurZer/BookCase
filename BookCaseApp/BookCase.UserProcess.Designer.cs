namespace BookCaseApp
{
    partial class BookCase
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
            this.dgwUser = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxRemoveWithTC = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxUpdateWithTC = new System.Windows.Forms.TextBox();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxUpdateLastName = new System.Windows.Forms.TextBox();
            this.cbxUpdateGender = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxUpdateTC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxUpdatePhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxUpdateMail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUser
            // 
            this.dgwUser.AllowUserToAddRows = false;
            this.dgwUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwUser.Location = new System.Drawing.Point(0, 70);
            this.dgwUser.Name = "dgwUser";
            this.dgwUser.RowHeadersWidth = 51;
            this.dgwUser.RowTemplate.Height = 24;
            this.dgwUser.Size = new System.Drawing.Size(1124, 248);
            this.dgwUser.TabIndex = 0;
            this.dgwUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUser_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUserAdd);
            this.groupBox1.Controls.Add(this.cbxGender);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxMail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxPhone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxLastName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 219);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Ekle";
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Location = new System.Drawing.Point(189, 179);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(162, 30);
            this.btnUserAdd.TabIndex = 13;
            this.btnUserAdd.Text = "Ekle";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbxGender.Location = new System.Drawing.Point(339, 114);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(162, 24);
            this.cbxGender.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cinsiyet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mail :";
            // 
            // tbxMail
            // 
            this.tbxMail.Location = new System.Drawing.Point(339, 74);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(162, 22);
            this.tbxMail.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon :";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(339, 35);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(162, 22);
            this.tbxPhone.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "TC :";
            // 
            // tbxTC
            // 
            this.tbxTC.Location = new System.Drawing.Point(92, 116);
            this.tbxTC.Name = "tbxTC";
            this.tbxTC.Size = new System.Drawing.Size(162, 22);
            this.tbxTC.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(92, 74);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(162, 22);
            this.tbxLastName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad :";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(92, 35);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(162, 22);
            this.tbxName.TabIndex = 2;
            // 
            // tbxRemoveWithTC
            // 
            this.tbxRemoveWithTC.Location = new System.Drawing.Point(497, 39);
            this.tbxRemoveWithTC.Name = "tbxRemoveWithTC";
            this.tbxRemoveWithTC.Size = new System.Drawing.Size(147, 22);
            this.tbxRemoveWithTC.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgwUser);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 537);
            this.panel1.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxUpdateWithTC);
            this.groupBox2.Controls.Add(this.btnUserUpdate);
            this.groupBox2.Controls.Add(this.tbxUpdateName);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbxUpdateLastName);
            this.groupBox2.Controls.Add(this.cbxUpdateGender);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbxUpdateTC);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbxUpdatePhone);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbxUpdateMail);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(551, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt Güncelle";
            // 
            // tbxUpdateWithTC
            // 
            this.tbxUpdateWithTC.Location = new System.Drawing.Point(138, 183);
            this.tbxUpdateWithTC.Name = "tbxUpdateWithTC";
            this.tbxUpdateWithTC.Size = new System.Drawing.Size(162, 22);
            this.tbxUpdateWithTC.TabIndex = 29;
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Location = new System.Drawing.Point(317, 179);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(162, 30);
            this.btnUserUpdate.TabIndex = 26;
            this.btnUserUpdate.Text = "Güncelle";
            this.btnUserUpdate.UseVisualStyleBackColor = true;
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(97, 41);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(162, 22);
            this.tbxUpdateName.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Ad :";
            // 
            // tbxUpdateLastName
            // 
            this.tbxUpdateLastName.Location = new System.Drawing.Point(97, 71);
            this.tbxUpdateLastName.Name = "tbxUpdateLastName";
            this.tbxUpdateLastName.Size = new System.Drawing.Size(162, 22);
            this.tbxUpdateLastName.TabIndex = 17;
            // 
            // cbxUpdateGender
            // 
            this.cbxUpdateGender.FormattingEnabled = true;
            this.cbxUpdateGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbxUpdateGender.Location = new System.Drawing.Point(361, 109);
            this.cbxUpdateGender.Name = "cbxUpdateGender";
            this.cbxUpdateGender.Size = new System.Drawing.Size(162, 24);
            this.cbxUpdateGender.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Soyad";
            // 
            // tbxUpdateTC
            // 
            this.tbxUpdateTC.Location = new System.Drawing.Point(361, 40);
            this.tbxUpdateTC.Name = "tbxUpdateTC";
            this.tbxUpdateTC.Size = new System.Drawing.Size(162, 22);
            this.tbxUpdateTC.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cinsiyet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(282, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "TC :";
            // 
            // tbxUpdatePhone
            // 
            this.tbxUpdatePhone.Location = new System.Drawing.Point(361, 71);
            this.tbxUpdatePhone.Name = "tbxUpdatePhone";
            this.tbxUpdatePhone.Size = new System.Drawing.Size(162, 22);
            this.tbxUpdatePhone.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Telefon :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Mail :";
            // 
            // tbxUpdateMail
            // 
            this.tbxUpdateMail.Location = new System.Drawing.Point(97, 111);
            this.tbxUpdateMail.Name = "tbxUpdateMail";
            this.tbxUpdateMail.Size = new System.Drawing.Size(162, 22);
            this.tbxUpdateMail.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnRemoveUser);
            this.panel2.Controls.Add(this.tbxRemoveWithTC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 70);
            this.panel2.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(574, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 30);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(497, 3);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(70, 30);
            this.btnRemoveUser.TabIndex = 27;
            this.btnRemoveUser.Text = "Sil";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // BookCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 552);
            this.Controls.Add(this.panel1);
            this.Name = "BookCase";
            this.Text = "BookCase-User";
            this.Load += new System.EventHandler(this.BookCase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxRemoveWithTC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxUpdateLastName;
        private System.Windows.Forms.ComboBox cbxUpdateGender;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxUpdateTC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxUpdatePhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxUpdateMail;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxUpdateWithTC;
    }
}