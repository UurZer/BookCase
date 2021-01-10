namespace BookCaseApp
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPaymentProcess = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLendList = new System.Windows.Forms.Button();
            this.bntLendProcess = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BookTracking = new System.Windows.Forms.Button();
            this.BookProcess = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.UserProcess = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.zedGraph);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(-108, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 506);
            this.panel1.TabIndex = 0;
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(409, 36);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(636, 404);
            this.zedGraph.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 506);
            this.panel2.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 540);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(233, 39);
            this.button6.TabIndex = 32;
            this.button6.Text = "Bilgi";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.button15.Dock = System.Windows.Forms.DockStyle.Top;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(0, 501);
            this.button15.Name = "button15";
            this.button15.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button15.Size = new System.Drawing.Size(233, 39);
            this.button15.TabIndex = 31;
            this.button15.Text = "Hakkında";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.panel5.Controls.Add(this.btnPaymentProcess);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 461);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(233, 40);
            this.panel5.TabIndex = 30;
            // 
            // btnPaymentProcess
            // 
            this.btnPaymentProcess.AutoSize = true;
            this.btnPaymentProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.btnPaymentProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaymentProcess.FlatAppearance.BorderSize = 0;
            this.btnPaymentProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentProcess.ForeColor = System.Drawing.Color.White;
            this.btnPaymentProcess.Location = new System.Drawing.Point(0, 0);
            this.btnPaymentProcess.Margin = new System.Windows.Forms.Padding(0);
            this.btnPaymentProcess.Name = "btnPaymentProcess";
            this.btnPaymentProcess.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPaymentProcess.Size = new System.Drawing.Size(233, 40);
            this.btnPaymentProcess.TabIndex = 0;
            this.btnPaymentProcess.Text = "Cezalar";
            this.btnPaymentProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaymentProcess.UseVisualStyleBackColor = false;
            this.btnPaymentProcess.Click += new System.EventHandler(this.btnPaymentProcess_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.button14.Dock = System.Windows.Forms.DockStyle.Top;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(0, 421);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button14.Size = new System.Drawing.Size(233, 40);
            this.button14.TabIndex = 29;
            this.button14.Text = "Cezai İşlemler";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.panel4.Controls.Add(this.btnLendList);
            this.panel4.Controls.Add(this.bntLendProcess);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 341);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 80);
            this.panel4.TabIndex = 28;
            // 
            // btnLendList
            // 
            this.btnLendList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.btnLendList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLendList.FlatAppearance.BorderSize = 0;
            this.btnLendList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLendList.ForeColor = System.Drawing.Color.White;
            this.btnLendList.Location = new System.Drawing.Point(0, 40);
            this.btnLendList.Name = "btnLendList";
            this.btnLendList.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLendList.Size = new System.Drawing.Size(233, 40);
            this.btnLendList.TabIndex = 1;
            this.btnLendList.Text = "Emanet Listele";
            this.btnLendList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLendList.UseVisualStyleBackColor = false;
            this.btnLendList.Click += new System.EventHandler(this.btnLendList_Click);
            // 
            // bntLendProcess
            // 
            this.bntLendProcess.AutoSize = true;
            this.bntLendProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.bntLendProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntLendProcess.FlatAppearance.BorderSize = 0;
            this.bntLendProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLendProcess.ForeColor = System.Drawing.Color.White;
            this.bntLendProcess.Location = new System.Drawing.Point(0, 0);
            this.bntLendProcess.Margin = new System.Windows.Forms.Padding(0);
            this.bntLendProcess.Name = "bntLendProcess";
            this.bntLendProcess.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bntLendProcess.Size = new System.Drawing.Size(233, 40);
            this.bntLendProcess.TabIndex = 0;
            this.bntLendProcess.Text = "İşlemler";
            this.bntLendProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntLendProcess.UseVisualStyleBackColor = false;
            this.bntLendProcess.Click += new System.EventHandler(this.bntLendProcess_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(0, 301);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(233, 40);
            this.button11.TabIndex = 27;
            this.button11.Text = "Kitap Emanet";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.BookTracking);
            this.panel3.Controls.Add(this.BookProcess);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 80);
            this.panel3.TabIndex = 26;
            // 
            // BookTracking
            // 
            this.BookTracking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BookTracking.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookTracking.FlatAppearance.BorderSize = 0;
            this.BookTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookTracking.ForeColor = System.Drawing.Color.White;
            this.BookTracking.Location = new System.Drawing.Point(0, 40);
            this.BookTracking.Name = "BookTracking";
            this.BookTracking.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BookTracking.Size = new System.Drawing.Size(233, 40);
            this.BookTracking.TabIndex = 4;
            this.BookTracking.Text = "Kitap Takip";
            this.BookTracking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookTracking.UseVisualStyleBackColor = false;
            this.BookTracking.Click += new System.EventHandler(this.BookTracking_Click);
            // 
            // BookProcess
            // 
            this.BookProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BookProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookProcess.FlatAppearance.BorderSize = 0;
            this.BookProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookProcess.ForeColor = System.Drawing.Color.White;
            this.BookProcess.Location = new System.Drawing.Point(0, 0);
            this.BookProcess.Name = "BookProcess";
            this.BookProcess.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BookProcess.Size = new System.Drawing.Size(233, 40);
            this.BookProcess.TabIndex = 1;
            this.BookProcess.Text = "İşemler";
            this.BookProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookProcess.UseVisualStyleBackColor = false;
            this.BookProcess.Click += new System.EventHandler(this.BookProcess_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(0, 181);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(233, 40);
            this.button7.TabIndex = 25;
            this.button7.Text = "Kitaplar";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.panel6.Controls.Add(this.UserProcess);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 141);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(233, 40);
            this.panel6.TabIndex = 24;
            // 
            // UserProcess
            // 
            this.UserProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.UserProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserProcess.FlatAppearance.BorderSize = 0;
            this.UserProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserProcess.ForeColor = System.Drawing.Color.White;
            this.UserProcess.Location = new System.Drawing.Point(0, 0);
            this.UserProcess.Name = "UserProcess";
            this.UserProcess.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.UserProcess.Size = new System.Drawing.Size(233, 40);
            this.UserProcess.TabIndex = 1;
            this.UserProcess.Text = "İşlemler";
            this.UserProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserProcess.UseVisualStyleBackColor = false;
            this.UserProcess.Click += new System.EventHandler(this.UserProcess_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 99);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(233, 42);
            this.button1.TabIndex = 23;
            this.button1.Text = "Öğrenci";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(233, 99);
            this.panel7.TabIndex = 22;
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(976, 506);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnPaymentProcess;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLendList;
        private System.Windows.Forms.Button bntLendProcess;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BookProcess;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button UserProcess;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BookTracking;
        private ZedGraph.ZedGraphControl zedGraph;
    }
}