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
using BookCase.Entities.Concrete;

namespace BookCaseApp
{
    public partial class BookCase : Form
    {
        public BookCase()
        {
            InitializeComponent();
        }
        UserManager _userManager = new UserManager();
        List<User> users = new List<User>();
        private void BookCase_Load(object sender, EventArgs e)
        {
            dgwUser.DataSource = _userManager.GetAll();
        }
        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            
            _userManager.Add(tbxName.Text, tbxLastName.Text, tbxTC.Text, tbxPhone.Text, tbxMail.Text, cbxGender.Text);
            dgwUser.DataSource = _userManager.GetAll();
            MessageBox.Show("Kayıt Eklendi.");

        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            users = _userManager.GetAll().Where(p => p.UserTC == tbxUpdateWithTC.Text).ToList();
            foreach (var item in users)
            {
                _userManager.Update(item.UserId, tbxUpdateName.Text, tbxUpdateLastName.Text, tbxUpdateTC.Text, tbxUpdatePhone.Text, tbxUpdateMail.Text, cbxUpdateGender.Text);
                dgwUser.DataSource = _userManager.GetAll();
            }
            MessageBox.Show("Kayıt Güncellendi.");
        }

        private void dgwUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillTextbox();
        }
        private void FillTextbox()
        {
            try
            {
                tbxUpdateName.Text = dgwUser.CurrentRow.Cells[1].Value.ToString();
                tbxUpdateLastName.Text = dgwUser.CurrentRow.Cells[2].Value.ToString();
                tbxUpdateTC.Text = dgwUser.CurrentRow.Cells[3].Value.ToString();
                cbxUpdateGender.Text = dgwUser.CurrentRow.Cells[4].Value.ToString();
                tbxUpdatePhone.Text = dgwUser.CurrentRow.Cells[5].Value.ToString();
                tbxUpdateMail.Text = dgwUser.CurrentRow.Cells[6].Value.ToString();
                tbxRemoveWithTC.Text = dgwUser.CurrentRow.Cells[3].Value.ToString();
                tbxUpdateWithTC.Text = dgwUser.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            _userManager.Delete(tbxRemoveWithTC.Text);
            dgwUser.DataSource = _userManager.GetAll();
            MessageBox.Show("Kayıt Silindi.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgwUser.DataSource = _userManager.GetAll().Where(p => p.UserTC == tbxRemoveWithTC.Text).ToList();
            FillTextbox();
        }
    }
}
