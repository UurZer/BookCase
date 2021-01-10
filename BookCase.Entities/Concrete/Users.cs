using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCase.Entities.Concrete
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserTC { get; set; }
        public string UserGender{ get; set; }
        public string  UserPhone { get; set; }
        public string UserMail { get; set; }
    }
}
