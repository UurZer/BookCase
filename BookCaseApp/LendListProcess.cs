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
    public partial class LendListProcess : Form
    {
        public LendListProcess()
        {
            InitializeComponent();
        }

        LendManager _lendManager = new LendManager();

        //LendList
        //Öğrencinin şimdiye kadar teslim etmiş ve etmemiş kitaplar listesi sıralanacak
        //Teslim süresi aşılmış kitaplar kırmızı 14 Gün
        //Teslim süresi 2 gün kalmış kitaplar sarı


        //Emanet Kayıtları
        //Teslim edilmiş kitap listesi Emanet Kayıtlarında Gösterilicek

        //Kitap Takip
        //Kitap takibinde kitabın kutuphanede olup olmadığı ve bilgileri yansıtılacak
        //Kitap Takibinde aynı zamanda kitap seçildiği takdirde 
        //O kitabı teslim almış ve ya teslim etmmemiş olan kişiler de listelenecek

        List<Lend> GetLends = new List<Lend>();
        //1 USERID
        //2 BookID

        public void LoadDataGrid(int _userID)
        {
            dgwLendList.DataSource = _lendManager.GetAll(_userID);
        }
        private void LendListProcess_Load(object sender, EventArgs e)
        {
            
            this.lendsTableAdapter1.Fill(this.deliveredDataSet.Lends);
            this.lendsTableAdapter.Fill(this.lendDataSet.Lends);
            
            dgwColumColor(dgwLendList);
            dgwColumColor();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _lendManager.DateProcess();
            this.lendsTableAdapter1.Fill(this.deliveredDataSet.Lends);
            this.lendsTableAdapter.Fill(this.lendDataSet.Lends);
            dgwColumColor(dgwLendList);
            dgwColumColor();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            LoadDataGrid(_lendManager.tcToID(tbxUserTC.Text));
            dgwColumColor(dgwLendList);
            dgwColumColor();
        }
        public void dgwColumColor()
        {
            for (int i = 0; i < dgwRegisteredList.Rows.Count - 1; i++)
            {
                if (Convert.ToBoolean(dgwRegisteredList.Rows[i].Cells[7].Value) == true)
                {
                    dgwRegisteredList.Rows[i].Cells[6].Style.BackColor = Color.Green;
                    dgwRegisteredList.Rows[i].Cells[6].Value = "Teslim Edildi.";
                }
            }
        }
        public void dgwColumColor(DataGridView dgw)
        {
            List<bool> statusIDS = new List<bool>();
            statusIDS = _lendManager.getStatusId();
            dgw.Columns[6].DefaultCellStyle.ForeColor = Color.White;
            for (int i = 0; i < dgw.Rows.Count - 1; i++)
            {
                try
                {
                    if (Convert.ToInt16(dgw.Rows[i].Cells[5].Value) >= 12 && Convert.ToInt16(dgw.Rows[i].Cells[5].Value)<14)
                    {
                        dgw.Rows[i].Cells[6].Style.BackColor = Color.YellowGreen;
                        dgw.Rows[i].Cells[6].Value = "Yaklaşıyor";
                    }
                    else if (Convert.ToInt16(dgw.Rows[i].Cells[5].Value) >= 14)
                    {
                        //MessageBox.Show(_lendManager.DateProcess(Convert.ToDateTime(dgwLendList.Rows[i].Cells[5].Value)).ToString());
                        dgw.Rows[i].Cells[6].Value = "Gecikmede";
                        dgw.Rows[i].Cells[6].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        dgw.Rows[i].Cells[6].Style.BackColor = Color.CornflowerBlue;
                        dgw.Rows[i].Cells[6].Value = "Yeni";
                    }
                }
                catch
                {

                }
            }
        }
    }
}
