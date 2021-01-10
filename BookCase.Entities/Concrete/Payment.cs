using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCase.Entities.Concrete
{
    public class Payment// Ceza Tablosu
    {
        [Key]
        public int Payment_Id { get; set; }
        public int LendID { get; set; }
        public int DelayDay { get; set; }
        public Decimal PaymentAmount { get; set; }
    }
}
