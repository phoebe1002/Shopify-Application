using System;
using System.Threading.Tasks;
using Models;

namespace DL
{
    public interface IUserDL
    {
        Task<User> AddUser(User user);
        Task<User> GetUserByPhoneNumber(string phoneNumber);
        Task<User> GetUserById(int id);
    }
}