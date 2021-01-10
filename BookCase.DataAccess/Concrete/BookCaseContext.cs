using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCase.Entities.Concrete;

namespace BookCase.DataAccess.Concrete
{
    public class BookCaseContext:DbContext
    {
        public BookCaseContext() : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<User> DbUsers { get; set; }
        public DbSet<Book> DbBook { get; set; }
        public DbSet<Payment> DbPayment { get; set; }
        public DbSet<Lend> DbLend { get; set; }
    }
}
