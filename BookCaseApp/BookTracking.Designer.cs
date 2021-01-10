namespace BookCaseApp
{
    partial class BookTracking
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
            this.btnBookTrack = new System.Windows.Forms.Button();
            this.btnLendList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBookTrack
            // 
            this.btnBookTrack.Location = new System.Drawing.Point(24, 12);
            this.btnBookTrack.Name = "btnBookTrack";
            this.btnBookTrack.Size = new System.Drawing.Size(131, 34);
            this.btnBookTrack.TabIndex = 0;
            this.btnBookTrack.Text = "Kitap Takip";
            this.btnBookTrack.UseVisualStyleBackColor = true;
            this.btnBookTrack.Click += new System.EventHandler(this.btnBookTrack_Click);
            // 
            // btnLendList
            // 
            this.btnLendList.Location = new System.Drawing.Point(180, 12);
            this.btnLendList.Name = "btnLendList";
            this.btnLendList.Size = new System.Drawing.Size(151, 34);
            this.btnLendList.TabIndex = 1;
            this.btnLendList.Text = "Emanet Kayıtları";
            this.btnLendList.UseVisualStyleBackColor = true;
            this.btnLendList.Click += new System.EventHandler(this.btnLendList_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBookTrack);
            this.panel1.Controls.Add(this.btnLendList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 70);
            this.panel1.TabIndex = 2;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChildForm.Location = new System.Drawing.Point(0, 70);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(955, 500);
            this.panelChildForm.TabIndex = 3;
            // 
            // BookTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 566);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Name = "BookTracking";
            this.Text = "BookTracking";
            this.Load += new System.EventHandler(this.BookTracking_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBookTrack;
        private System.Windows.Forms.Button btnLendList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChildForm;
    }
}