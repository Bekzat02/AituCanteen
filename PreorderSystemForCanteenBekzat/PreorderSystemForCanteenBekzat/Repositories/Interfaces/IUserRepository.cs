using PreorderSystemForCanteenBekzat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreorderSystemForCanteenBekzat.Repositories.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetUserById(int id);
        List<User> RemoveUserByName(string name);
        List<User> AddUserById(int id, string firstName, string secondName, string login);
    }
}
