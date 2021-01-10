using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCase.Entities.Concrete;

namespace BookCase.DataAccess.Concrete
{
    public class PaymentDal
    {
        List<Payment> payments = new List<Payment>();
        public List<Payment> GetAll()
        {
            using(BookCaseContext context=new BookCaseContext())
            {
                return context.DbPayment.ToList();
            }
        }

        public void Add(Payment _payment)
        {
            using (BookCaseContext context = new BookCaseContext())
            {
                context.DbPayment.Add(_payment);
                context.SaveChanges();
            }
        }
        
        public void UpdateDelayDay(int lendId,int lendDay)
        {
            
            using (BookCaseContext context = new BookCaseContext())
            {
                var query =
                  from p in context.DbPayment
                  where lendId == p.LendID
                  select p;

                foreach (var payment in query)
                {
                    payment.DelayDay = lendDay - 15;
                    payment.PaymentAmount = payment.DelayDay;
                }
                context.SaveChanges();
            }
        }
    }
}
