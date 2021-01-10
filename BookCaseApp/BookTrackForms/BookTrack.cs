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

namespace BookCaseApp.BookTrackForms
{
    public partial class BookTrack : Form
    {
        public BookTrack()
        {
            InitializeComponent();
            
        }
        BookManager _bookManager = new BookManager();
        List<Book> getList = new List<Book>();
        private void LoadBookList()
        {

            getList = _bookManager.GetAll();
            for(int i = 0; i < getList.Count ;i++)
            {
                cbxSearchBook.Items.Add(getList[i].BookName);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgwBookList.DataSource = this.booksTableAdapter.GetData().Where(p => p.BookName == cbxSearchBook.Text).ToList();
        }

        private void dgwColumColor()
        {
            for (int i = 0; i < dgwBookList.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgwBookList.Rows[i].Cells[7].Value) == true)
                {
                    dgwBookList.Rows[i].Cells[8].Style.BackColor = Color.Green;
                }
                else 
                    dgwBookList.Rows[i].Cells[8].Style.BackColor = Color.Yellow;
            }
            //dgwBookList.Rows[i].Cells[7].Style.BackColor= Color.Red;
            //dgwBookList.CurrentRow.Cells[7].Style.BackColor= Color.Green;
        }

        private void BookTrack_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registeredData.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.registeredData.Books);
            LoadBookList();
            dgwColumColor();
            dgwBookList.Columns[7].Visible = false;//Bak Buraya
        }
    }
}
