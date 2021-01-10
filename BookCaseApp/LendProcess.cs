using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookCase.Business.Concrete;

namespace BookCaseApp
{
    public partial class LendProcess : Form
    {
        public LendProcess()
        {
            InitializeComponent();
        }
        LendManager _lendManager = new LendManager();
        BookManager _bookManager = new BookManager();
        UserManager _userManager= new UserManager();
        string message;
        private void btnLendAdd_Click(object sender, EventArgs e)
        {
            try
            {
               message = _lendManager.Add(cbxTC.Text,cbxISBN.Text,dtpDate.Value);
               MessageBox.Show(message);
            }
            catch
            {
                MessageBox.Show("Yanlış TC veya ISBN girdiniz.");
            }
        }

         
        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                message = _lendManager.ChangeStatus(cbxReturnTC.Text, cbxReturnISBN.Text, dtpReturnDate.Value);
                MessageBox.Show(message);
            }
            catch
            {
                MessageBox.Show("Yanlış TC veya ISBN girdiniz.");
            }
        }

        private void LendProcess_Load(object sender, EventArgs e)
        {
            foreach (var item in _bookManager.GetAll().Where(p => p.BookStatus == true).ToList())//Kütüphandeki olan kitapları listelers
            {
                cbxISBN.Items.Add(item.ISBN);
            }
            foreach (var item in _bookManager.GetAll().Where(p => p.BookStatus == false).ToList())//Kütüphandeki olan kitapları listelers
            {
                cbxReturnISBN.Items.Add(item.ISBN);
            }
            foreach (var item in _userManager.GetAll())
            {
                cbxTC.Items.Add(item.UserTC);
                cbxReturnTC.Items.Add(item.UserTC);
            }
        }
    }
}
