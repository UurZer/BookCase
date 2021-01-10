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
    public partial class BookCasePayment : Form
    {
        public BookCasePayment()
        {
            InitializeComponent();
        }
        PaymentManager _paymentManager = new PaymentManager();
        private void BookCasePayment_Load(object sender, EventArgs e)
        {
            _paymentManager.Add();
            this.paymentsTableAdapter.Fill(this.paymentData1.Payments);
            for (int i = 0; i < this.paymentData1.Payments.Count; i++)
            {
                if (dgwPayment.Rows[i].Cells[6].Value.ToString() == "30.12.1899 00:00:00")
                {
                    dgwPayment.Rows[i].Cells[6].Value = "";
                }
            }
        }
    }
}
