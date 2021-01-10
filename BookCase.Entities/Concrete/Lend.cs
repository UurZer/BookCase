using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCase.Entities.Concrete
{
    public class Lend//Emanet Tablosu
    {
        [Key]
        public int LendId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime LendDate { get; set; }
        public DateTime LendDateReceived { get; set; }
        public bool LendStatus { get; set; }
        public int LendDay { get; set; }
        public bool PaymentStatus { get; set; }
    }
}
