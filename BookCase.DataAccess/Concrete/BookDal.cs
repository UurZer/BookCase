using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCase.Entities.Concrete;

namespace BookCase.DataAccess.Concrete
{
    public class BookDal
    {
        public List<Book> GetAll()
        {
            using (BookCaseContext context =new BookCaseContext())
            {
                return context.DbBook.ToList();
            }
        }

        public List<Book> GetAll(string _Category)
        {
            using (BookCaseContext context = new BookCaseContext())
            {
                List<Book> result = (from c in context.DbBook select c).Where(cate => cate.CategoryName == _Category).ToList();
                return result;
            }
        }
        public void Add(Book _book)
        {
            using(BookCaseContext context =new BookCaseContext())
            {
                 context.DbBook.Add(_book);
                 context.SaveChanges();
            }
        }

        public void Update(Book _book)
        {
            using (BookCaseContext context = new BookCaseContext())
            {
                var Entity = context.Entry(_book);
                Entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public bool CheckingStatus(string _ISBN)
        {
            using(BookCaseContext context =new BookCaseContext())
            {
                var result =
                    from p in context.DbBook
                    where p.ISBN == _ISBN
                    select p;
                foreach (var _Book in result)
                {
                    return _Book.BookStatus;
                }
            }
            return false;
        }

        public void UpdateStatus(string _ISBN,bool _bool,string _statusText)
        {
            using (BookCaseContext context = new BookCaseContext())
            {
                var query =
                    from p in context.DbBook
                    where p.ISBN == _ISBN
                    select p;

                foreach (var _Book  in query)
                {
                    _Book.BookStatusText = _statusText;
                    _Book.BookStatus = _bool;
                }
                context.SaveChanges();
            }
        }
        public void Delete(string  _ISBN, string _or_ISBN)
        {
            if (_or_ISBN != "")
                _ISBN = _or_ISBN;

            //2 Seçeneği ekle Buraya
            using (BookCaseContext context = new BookCaseContext())
            {
                var Entity = context.DbBook.FirstOrDefault(deleting => deleting.ISBN == _ISBN);
                context.DbBook.Remove(Entity);
                context.SaveChanges();
            }
        }
        public int ISBNToID(string _ISBN)
        {
            using (BookCaseContext context = new BookCaseContext())
            {
                var result = from p in context.DbBook
                             where p.ISBN == _ISBN
                             select p;

                foreach (var _Book in result)
                {
                    return _Book.BookId;
                }
            }
            return 0;
        }

        public string ıdToBookName(int _bookID)
        {
            using (BookCaseContext context = new BookCaseContext())
            {
                var result = from p in context.DbBook
                             where p.BookId == _bookID
                             select p;
                foreach (var _Book in result)
                {
                    return _Book.BookName;
                }
            }
            return "";
        }

    }
}
