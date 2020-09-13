using PreorderSystemForCanteenBekzat.Models;
using PreorderSystemForCanteenBekzat.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreorderSystemForCanteenBekzat.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> users;
        public UserRepository()
        {
            users = new List<User> {
            new User() {Id = 1, FirstName = "Arman", SecondName = "Paluasdn", Login = "armefanSila75"},
            new User() {Id = 1, FirstName = "Arman", SecondName = "Paluasdn", Login = "armefanSila75"},
            new User() {Id = 1, FirstName = "Arman", SecondName = "Paluasdn", Login = "armefanSila75"},
            new User() {Id = 1, FirstName = "Arman", SecondName = "Paluasdn", Login = "armefanSila75"},
            new User() {Id = 2, FirstName = "Arreman", SecondName = "Paluaden", Login = "armfdfanSila75"},
            new User() {Id = 3, FirstName = "Armayhtn", SecondName = "Parefluan", Login = "armagrwnSila75"},
            new User() {Id = 4, FirstName = "Armagrtfn", SecondName = "Palufan", Login = "armanSilwsdsa75"},
            new User() {Id = 5, FirstName = "Armawn", SecondName = "Prealuan", Login = "armanSiwfla75"},

            };
        }

        public List<User> AddUserById(int id, string firstName, string secondName, string login)
        {
            users.Add(new User
            {
                Id = id,
                FirstName = firstName,
                SecondName = secondName,
                Login = login
            });

            return users;
        }

        public List<User> GetUserById(int id)
        {
            return users.Where(u => u.Id == id).ToList();
        }

        public List<User> RemoveUserByName(string name)
        {
            var userList = users;

            var userss = userList.Where(a => a.FirstName == name).ToList();

            foreach (var author in userss)
            {
                userList.Remove(author);
            }
            return userList;

        }



    }
}
