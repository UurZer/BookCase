using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCase.Entities.Concrete;

namespace BookCase.DataAccess.Concrete
{
    public class LendDal:UserDal
    {
        public List<Lend> GetAll()
        {
            using(BookCaseContext context=new BookCaseContext())
            {
                    return context.DbLend.ToList();
            }
        }


        public List<Lend> GetAll(int _userID)
        {
            using (BookCaseContext context = new BookCaseContext())
            {
                var result = from p in context.DbLend
                             where p.UserId == _userID
                             select p;
                return result.ToList();
            }
        }

        public void  Add(Lend _lend)
        {
            using (BookCaseContext context = new BookCaseContext())
            {
                context.DbLend.Add(_lend);
                context.SaveChanges();
            }
        }
        public int userIDToLendID(int _userID ,int _bookID)
        {
            using (BookCaseContext context = new BookCaseContext())
            {
                var result = from p in context.DbLend
                             where p.UserId == _userID && p.BookId==_bookID
                             select p;

                foreach (var _lend in result)
                {
                    return _lend.LendId;
                }
            }
            return 0;
        }
        public List<bool> getStatusId()
        {
             List<bool> userIDS = new List<bool>();
            using (BookCaseContext context = new BookCaseContext())
            {
                var result = from p in context.DbLend
                             select p;

                foreach (var _lend in result)
                {
                    userIDS.Add(_lend.LendStatus);
                }
                return userIDS;
            }
        }
        public DateTime getDate(int _lendID)
        {
            using (BookCaseContext context = new BookCaseContext())
            {
                var result = from p in context.DbLend
                             where p.LendId == _lendID
                             select p;

                foreach (var _lend in result)
                {
                    return _lend.LendDate;
                }
                return DateTime.Now;
            }
        }
        public void ChangeStatus(int _lendID, bool _lendStatus,DateTime _date)
        {
            using (BookCaseContext context = new BookCaseContext())
            {
                var query =
                   from p in context.DbLend
                   where _lendID == p.LendId 
                   select p;
                foreach (var _Lend in query)
                {
                    _Lend.LendStatus = _lendStatus;
                    _Lend.LendDateReceived = _date;
                }
                context.SaveChanges();
                //var Entity = context.Entry(_lend);
                //Entity.State = System.Data.Entity.EntityState.Modified;
                //context.SaveChanges();
            }
        }
        public void UpdateLendDay(int _lendID,TimeSpan getTime)
        {
            using (BookCaseContext context = new BookCaseContext())
            {
                var query =
                    from p in context.DbLend where _lendID == p.LendId && p.LendStatus==false
                    select p;
                foreach (var _Lend in query)
                {
                    _Lend.LendDay = Convert.ToInt16(getTime.TotalDays);
                }
                context.SaveChanges();
            }
        }
        public void ChangePaymentStatus(int _lendID,bool _paymentStatus)
        {
            using (BookCaseContext context = new BookCaseContext())
            {
                var query =
                    from p in context.DbLend
                    where _lendID == p.LendId
                    select p;
                foreach (var _Lend in query)
                {
                    _Lend.PaymentStatus = _paymentStatus;
                }
                context.SaveChanges();
            }
        }



    }
}
