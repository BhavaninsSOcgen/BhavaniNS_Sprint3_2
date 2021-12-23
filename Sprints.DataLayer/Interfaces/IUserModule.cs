using Sprints.DataLayer.Models;

using System.Collections.Generic;

namespace Sprints.DataLayer.Interfaces
{
    public interface IUserModule
    {
        List<UserModule> GetAllUsers();
        UserModule GetUserById(int id);
        UserModule AddUser(UserModule user);
        UserModule UpdateUser(int id, UserModule user);
        void DeleteUser(int id);
    }
}
