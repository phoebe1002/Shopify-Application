using System;
using System.Threading.Tasks;
using Models;

namespace DL
{
    public interface IUserDL
    {
        Task<User> AddUser(User user);
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserById(int id);
    }
}