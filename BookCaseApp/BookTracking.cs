using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookCaseApp.BookTrackForms;

namespace BookCaseApp
{
    public partial class BookTracking : Form
    {
        public BookTracking()
        {
            InitializeComponent();
        }
        //Kitap Takip
        //Kitap takibinde kitabın kutuphanede olup olmadığı ve bilgileri yansıtılacak
        //Kitap Takibinde aynı zamanda kitap seçildiği takdirde
        //O kitabı teslim almış ve ya teslim etmmemiş olan kişiler de listelenecek


          public Form ActiveForm;
        public void OpenBookTrack(Form ChildForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            btnBookTrack.Enabled = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            panelChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void btnBookTrack_Click(object sender, EventArgs e)//Active ise 
        {
            OpenBookTrack(new BookTrack());
            btnLendList.Enabled = true;
        }

       
        private void BookTracking_Load(object sender, EventArgs e)
        {
            OpenBookTrack(new BookTrack());
        }

        private void btnLendList_Click(object sender, EventArgs e)
        {
            OpenBookTrack(new RegisteredLend());
            btnBookTrack.Enabled = true;
            btnLendList.Enabled = false;
        }
    }
}
