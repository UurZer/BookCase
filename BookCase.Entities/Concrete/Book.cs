using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCase.Entities.Concrete
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string CategoryName { get; set; }
        public string BookName { get; set; }
        public string ISBN { get; set; }
        public DateTime BookDate { get; set; }
        public string AuthorName { get; set; }
        public int PageNumber { get; set; }
        public bool BookStatus { get; set; }
        public string BookStatusText { get; set; }


    }
}
