using Sprints.DataLayer.Context;
using Sprints.DataLayer.Interfaces;
using Sprints.DataLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace Sprints.PersistenceLayer.Models
{
    public class UserModuleEf : IUserModule
    {
        private readonly AppDbContext _context;

        public UserModuleEf(AppDbContext context)
        {
            _context = context;
        }
        public UserModule AddUser(UserModule user)
        {
            _context.UserModule.Add(user);
            _context.SaveChanges();
            return user;
        }

        public void DeleteUser(int id)
        {
            UserModule user = GetUserById(id);
            _context.UserModule.Remove(user);
            _context.SaveChanges();
        }

        public List<UserModule> GetAllUsers()
        {
            return _context.UserModule.ToList();
        }

        public UserModule GetUserById(int id)
        {
            return _context.UserModule.FirstOrDefault(usr => usr.Id == id);
        }

        public UserModule UpdateUser(int id, UserModule user)
        {
            var DatatobeUpdated = _context.UserModule.FirstOrDefault(usr => usr.Id == id);
            if (DatatobeUpdated != null)
            {
                DatatobeUpdated.FirstName = user.FirstName;
                DatatobeUpdated.LastName = user.LastName;
                DatatobeUpdated.Email = user.Email;
                DatatobeUpdated.Password = user.Password;
                _context.SaveChanges();

            }
            return user;
        }
    }
}
