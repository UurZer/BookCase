using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCase.Entities.Concrete;

namespace BookCase.DataAccess.Abstract
{
    public interface IUserDal
    {
        List<User> GetAllUsers();
        void Add(User _user);
        void Update(User user);
        void Delete(string _TC);
    }
}
