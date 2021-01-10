using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookCase.Entities.Concrete;
using BookCase.DataAccess.Concrete;
namespace BookCase.Business.Concrete
{
    public class LendManager
    {
        LendDal _lendDal = new LendDal();
        UserDal _userDal = new UserDal();
        BookDal _bookDal = new BookDal();
        public List<Lend> GetAll()
        {
            return _lendDal.GetAll();
        }
        public List<Lend> GetAll(int _userID)
        {
            return _lendDal.GetAll(_userID);
        }

        public string Add(string _TC,string _ISBN,DateTime _Date)
        {
            if (_bookDal.CheckingStatus(_ISBN) == true)
            {
                _lendDal.Add(new Lend {
                    LendDate= _Date,
                    UserId= _userDal.tcToID(_TC),
                    BookId= _bookDal.ISBNToID(_ISBN),
                    LendDateReceived= Convert.ToDateTime(null),
                    LendStatus=false,
                });
                _bookDal.UpdateStatus(_ISBN, false,"Emanetli");

                return "Başarılı Emanet Edildi.";
            }
            else
            {
                return "Bu kitap zaten emanet edilmişti.";
            }
        }
        public string ChangeStatus(string _TC, string _ISBN, DateTime _Date)
        {
            int _userıd = _userDal.tcToID(_TC);
            int _bookıd = _bookDal.ISBNToID(_ISBN);
            int _lendId = _lendDal.userIDToLendID(_userıd,_bookıd);


            //Lend tablosundaki _Tc den Lend ID alıp orda değişiklik

            foreach (var item in GetAll().Where(p=>p.LendId == _lendId))
            {
                if(item.UserId==_userıd && item.BookId == _bookıd)
                {
                    _lendDal.ChangeStatus(item.LendId, true, _Date);

                    _bookDal.UpdateStatus(_ISBN, true, "Teslim Edildi");

                    return "Başarılı İADE Alındı.";
                }
                else
                {
                    return "Bu kitap zaten İADE alınmıştı";
                }
            }
            GC.SuppressFinalize(_userDal);
            GC.SuppressFinalize(_bookDal);
            GC.SuppressFinalize(_lendDal);
            return "HATA";
        }

        public List<bool> getStatusId()
        {
            return _lendDal.getStatusId();
        }

        public int tcToID(string _TC)
        {
            return _lendDal.tcToID(_TC);
        }
        public string ıdToTc(int _userID)
        {
            return _lendDal.ıdToTC(_userID);
        }

        public string ıdToBookName(int _bookID)
        {
            return _bookDal.ıdToBookName(_bookID);
        }

        public TimeSpan diff { get; set; }
        public void DateProcess()
        {
            foreach (var item in GetAll())
            {
                 diff = DateTime.Now - item.LendDate;
                _lendDal.UpdateLendDay(item.LendId, diff);
            }
        }
    }
}
