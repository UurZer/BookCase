using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCase.DataAccess.Abstract;
using BookCase.Entities.Concrete;

namespace BookCase.DataAccess.Concrete
{
    public class UserDal: IUserDal
    {
        public List<User> GetAllUsers()
        {
            using (BookCaseContext context = new BookCaseContext())
            {
                return context.DbUsers.ToList();
            }
        }
        

        public void Add(User _user)
        {
            using (BookCaseContext context = new BookCaseContext())
            {
                context.DbUsers.Add(_user);
                context.SaveChanges();
            }
        }


        public void Update(User user)
        {
            using (BookCaseContext context = new BookCaseContext())
            {
                var Entity = context.Entry(user);
                Entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(string _TC)
        {
        
            using(BookCaseContext context =new BookCaseContext())
            {
                var Entity = context.DbUsers.FirstOrDefault(deleting => deleting.UserTC == _TC);
                context.DbUsers.Remove(Entity);
                context.SaveChanges();
            }
        }

        public int tcToID(string _TC)
        {
            using (BookCaseContext context = new BookCaseContext())
            {
                var result = from p in context.DbUsers
                             where p.UserTC == _TC
                             select p;

                foreach (var _User in result)
                {
                    return _User.UserId;
                }
            }
            return 0;
        }
        public string ıdToTC(int _userId)
        {
            using (BookCaseContext context = new BookCaseContext())
            {
                var result = from p in context.DbUsers
                             where p.UserId == _userId
                             select p;
                foreach (var _User in result)
                {
                    return _User.UserTC;
                }
            }
            return "";
        }
    }
}
