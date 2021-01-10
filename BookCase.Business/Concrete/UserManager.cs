using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCase.DataAccess.Concrete;
using BookCase.Entities.Concrete;

namespace BookCase.Business.Concrete
{
    public class UserManager
    {
        UserDal _userDal = new UserDal();
        public List<User> GetAll()
        {
            //Business Code
            return _userDal.GetAllUsers();
        }
        public List<User> GetAll(string _gender)
        {
            //Business Code
            return _userDal.GetAllUsers().Where(p => p.UserGender == _gender).ToList();
        }
        
        public void Add(string Name,string LastName,string TC,string Phone,string Mail,string Gender)
        {
            _userDal.Add(new User
            {
                UserName = Name,
                UserLastName=LastName,
                UserTC=TC,
                UserPhone= Phone,
                UserMail =Mail,
                UserGender=Gender,
            });
        }
        public void Update(int dgwCurrent,string Name, string LastName, string TC, string Phone, string Mail, string Gender)
        {
            _userDal.Update(new User
            {
                UserId = Convert.ToInt32(dgwCurrent),
                UserName = Name,
                UserLastName = LastName,
                UserTC = TC,
                UserPhone = Phone,
                UserMail = Mail,
                UserGender = Gender,
            });
        }
        public void Delete(string _TC)
        {
            _userDal.Delete(_TC);
        }

        public int tcToID(string _TC)
        {

            return _userDal.tcToID(_TC);
        }
    }
}

