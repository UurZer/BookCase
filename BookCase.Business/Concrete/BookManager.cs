using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCase.DataAccess.Concrete;
using BookCase.Entities.Concrete;

namespace BookCase.Business.Concrete
{
    public class BookManager
    {
        BookDal _bookDal = new BookDal();
        string _BookStatusText;
        bool _BookStatus;
        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public List<Book> GetAll(string _Category)//Bunu BookDala Taşı Sql Komutları var orda olmalı
        {

            return _bookDal.GetAll(_Category);        
        }

        public void Add(string _category,string _bookName,string _ISBN,DateTime _bookDate,string _authorName,int _pageNumber)
        {
            _bookDal.Add(new Book
            {
                CategoryName=_category,
                BookName=_bookName,
                ISBN=_ISBN,
                BookDate=_bookDate,
                PageNumber= _pageNumber,
                AuthorName=_authorName,
                BookStatus=true,
                BookStatusText= "Teslim Edildi",
            });
        }

        public void Update(int dgwCurrent, string _category, string _bookName, string _ISBN, DateTime _bookDate, string _authorName, int _pageNumber)
        {
            
                if(_bookDal.CheckingStatus(_ISBN)==true)
                {
                    _BookStatusText= "Teslim Edildi";
                    _BookStatus = true;
                }
                else
                {
                    _BookStatusText= "Emanetli";
                    _BookStatus = false;
                }

            _bookDal.Update(new Book
            {
                BookId = Convert.ToInt32(dgwCurrent),
                BookName = _bookName,
                CategoryName = _category,
                ISBN = _ISBN,
                BookDate= _bookDate,
                AuthorName = _authorName,
                PageNumber = _pageNumber,
                BookStatusText= _BookStatusText,
                BookStatus= _BookStatus,
            });
        }
        public void Delete(string _ISBN, string _orISBN)
        {
            _bookDal.Delete(_ISBN, _orISBN);
        }
    }
}
