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
    public partial class RegisteredLend : Form
    {
        LendManager _lendManager = new LendManager();
        BookManager _bookManager = new BookManager();
        List<Book> getList = new List<Book>();
        public RegisteredLend()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                for (int i = 0; i < this.registeredData.Lends.Count; i++)
                {
                    if(dgwLendRegistered.Rows[i].Cells[7].Value.ToString() == "30.12.1899 00:00:00")
                    {
                        dgwLendRegistered.Rows[i].Cells[7].Value = "";
                    }
                }
            }
            catch
            {

            }
        }

        private void RegisteredLend_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registeredData.Lends' table. You can move, or remove it, as needed.
            this.lendsTableAdapter.Fill(this.registeredData.Lends);
            getList = _bookManager.GetAll();
            foreach (var item in getList)
            {
                cbxBookName.Items.Add(item.BookName);
            }
            LoadData();
        }
        
        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            dgwLendRegistered.DataSource = this.lendsTableAdapter.GetData().Where(p => p.BookName == cbxBookName.Text).ToList();
            LoadData();
        }
    }
}
