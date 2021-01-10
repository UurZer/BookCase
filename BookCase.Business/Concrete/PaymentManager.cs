using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCase.DataAccess.Concrete;
using BookCase.Entities.Concrete;

namespace BookCase.Business.Concrete
{
    public class PaymentManager
    {
        PaymentDal _paymentDal = new PaymentDal();
        LendManager _lendManager = new LendManager();
        LendDal _lendDal = new LendDal();
        List<Lend> lends = new List<Lend>();
        List<Payment> payments= new List<Payment>();
        public List<Payment> GetAll()
        {
            return _paymentDal.GetAll();
        }
        public void Add()//Burada birde sadece delay günü güncellencek kod yazılcak 
        {
            int num = 15;
            lends =_lendManager.GetAll().Where(p=>p.LendDay>15 && p.PaymentStatus == false).ToList();
            foreach(Lend _lend in lends)
            {
                _paymentDal.Add(new Payment
                {
                    LendID = _lend.LendId,
                    DelayDay = _lend.LendDay - num,
                    PaymentAmount= _lend.LendDay - num,
                });
                _lendDal.ChangePaymentStatus(_lend.LendId, true);
            }

            lends = _lendManager.GetAll().Where(p => p.LendDay > 15 && p.LendStatus == false).ToList();
            foreach (var item in lends)
            {
                _paymentDal.UpdateDelayDay(item.LendId, item.LendDay);
            }
        }
    }
}
