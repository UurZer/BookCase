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
    public partial class BookProcess : Form
    {
        public BookProcess()
        {
            InitializeComponent();
        }
        BookManager _bookManager = new BookManager();
        List<Book> _books = new List<Book>();
        private void BookProcess_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            dgwColumColor();
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _bookManager.Add(cbxType.Text, tbxName.Text, tbxISBN.Text, dtpDate.Value, tbxAuthor.Text, Convert.ToInt32(tbxPageNumber.Text));
            }
            catch
            {
                MessageBox.Show("Verileri girdiğinizden emin olunuz.");
            }
            LoadDataGrid();
        }

   
        private void LoadDataGrid()
        {
            dgwBookList.DataSource = _bookManager.GetAll();
            dgwBookList.Columns[7].Visible = false;
        }
        //Message B
        private void btnBookUpdate_Click(object sender, EventArgs e)
        {
            _books = _bookManager.GetAll().Where(p => p.ISBN == tbxUpdate.Text).ToList();
            foreach (var item in _books)
            {
                _bookManager.Update(item.BookId, cbxUpdateType.Text, tbxUpdateName.Text, tbxUpdateISBN.Text, dtpUpdateDate.Value, tbxUpdateAuthor.Text, Convert.ToInt32(tbxUpdatePageNumber.Text));
                LoadDataGrid();
            }
            MessageBox.Show("Kayıt Güncellendi.");
        }

        private void FillTextbox()
        {
            try
            {
                tbxUpdateName.Text = dgwBookList.CurrentRow.Cells[2].Value.ToString();
                cbxUpdateType.Text = dgwBookList.CurrentRow.Cells[1].Value.ToString();
                tbxUpdateISBN.Text = dgwBookList.CurrentRow.Cells[3].Value.ToString();
                tbxUpdateAuthor.Text = dgwBookList.CurrentRow.Cells[5].Value.ToString();
                tbxUpdatePageNumber.Text = dgwBookList.CurrentRow.Cells[6].Value.ToString();
                tbxUpdate.Text = dgwBookList.CurrentRow.Cells[3].Value.ToString();
                tbxRemoveWithISBN.Text = dgwBookList.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Verileri girdiğinizden emin olunuz.");
            }
        }
        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
                try
                {
                _bookManager.Delete(dgwBookList.CurrentRow.Cells[3].Value.ToString(),tbxRemoveWithISBN.Text);
                    MessageBox.Show("Kayıt silindi.");
                }
                catch
                {
                    _bookManager.Delete(dgwBookList.CurrentRow.Cells[3].Value.ToString(), "");
                }
            LoadDataGrid();
            dgwColumColor();
        }
        private void dgwColumColor()
        {
            dgwBookList.Columns[8].DefaultCellStyle.ForeColor = Color.White;
            for (int i = 0; i < dgwBookList.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgwBookList.Rows[i].Cells[7].Value)== true)
                    dgwBookList.Rows[i].Cells[8].Style.BackColor = Color.Green;
                else
                    dgwBookList.Rows[i].Cells[8].Style.BackColor = Color.Red;
            }
        }


    

        private void dgwBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillTextbox();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            dgwBookList.DataSource = _bookManager.GetAll().Where(p => p.ISBN == tbxRemoveWithISBN.Text).ToList();
            FillTextbox();
            dgwColumColor();
        }
    }
}
