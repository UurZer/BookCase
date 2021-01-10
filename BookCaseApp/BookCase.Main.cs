using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookCase.Business.Concrete;
using BookCase.Entities.Concrete;
using ZedGraph;       
namespace BookCaseApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        LendManager _lendManager = new LendManager();
        BookManager _bookManager = new BookManager();
        List<Book> _books = new List<Book>();
        private void Main_Load(object sender, EventArgs e)
        {
            customizeDesign();

            _lendManager.DateProcess();
            _books = _bookManager.GetAll();

            double[] dateDay = { DateTime.Now.Day};
            double[] totalBook = { _books.Count};
            double[] lendBook = { _books.Where(p => p.BookStatus == true).ToList().Count };
            double[] currentBook = { _books.Where(p => p.BookStatus == false).ToList().Count };

            zedGraph.GraphPane.CurveList.Clear();

            zedGraph.GraphPane.AddBar("Toplam Kitap", dateDay, totalBook, Color.Blue);
            zedGraph.GraphPane.AddBar("Kütüphanedeki Kitap", dateDay, lendBook, Color.Green);
            zedGraph.GraphPane.AddBar("Emanetli Kitap", dateDay, currentBook, Color.Red);
            
            zedGraph.GraphPane.Title.Text = "Kütüphanedeki Kitaplar";
            zedGraph.GraphPane.XAxis.Title.Text = "Tarih";
            zedGraph.GraphPane.YAxis.Title.Text = "Kitap Sayısı";


            zedGraph.GraphPane.XAxis.ResetAutoScale(zedGraph.GraphPane, CreateGraphics());
            zedGraph.GraphPane.YAxis.ResetAutoScale(zedGraph.GraphPane, CreateGraphics());

            zedGraph.Refresh();
            GC.SuppressFinalize(_lendManager);
            GC.SuppressFinalize(_bookManager);
        }
        private void customizeDesign()
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panel3.Visible == true)
                panel3.Visible = false;

            if (panel4.Visible == true)
                panel4.Visible = false;

            if (panel5.Visible == true)
                panel5.Visible = false;

            if (panel6.Visible == true)
                panel6.Visible = false;
        }

        private void showMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showMenu(panel6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showMenu(panel3);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            showMenu(panel4);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            showMenu(panel5);
        }

        private void UserProcess_Click(object sender, EventArgs e)
        {
            BookCase UserProcess = new BookCase();
            UserProcess.Show();
            GC.SuppressFinalize(UserProcess);
        }

        private void BookProcess_Click(object sender, EventArgs e)
        {
            BookProcess _bookProcess = new BookProcess();
            _bookProcess.Show();
            GC.SuppressFinalize(_bookProcess);
        }

        private void bntLendProcess_Click(object sender, EventArgs e)
        {
            LendProcess _lendProcess = new LendProcess();
            _lendProcess.Show();
            GC.SuppressFinalize(_lendProcess);
        }

        private void btnLendList_Click(object sender, EventArgs e)
        {
            LendListProcess _lendListProcess = new LendListProcess();
            _lendListProcess.Show();
            GC.SuppressFinalize(_lendListProcess);
        }

        private void BookTracking_Click(object sender, EventArgs e)
        {
            BookTracking _bookTracking = new BookTracking();
            _bookTracking.Show();
            GC.SuppressFinalize(_bookTracking);
        }

        private void btnPaymentProcess_Click(object sender, EventArgs e)
        {
            BookCasePayment _bookPayment = new BookCasePayment();
            _bookPayment.Show();
            GC.SuppressFinalize(_bookPayment);
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
