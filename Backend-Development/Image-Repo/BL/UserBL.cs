using System;
using System.Threading.Tasks;
using Models;
using DL;

namespace BL
{
    public class UserBL : IUserBL
    {
        private readonly IUserDL _userDL;
        public UserBL(IUserDL userDL)
        {
            _userDL = userDL;
        }
        public async Task<User> AddUser(User user)
        {
            return await _userDL.AddUser(user);
        }
        public async Task<User> GetUserByPhoneNumber(string phoneNumber)
        {
            return await _userDL.GetUserByPhoneNumber(phoneNumber);
        }
        public async Task<User> GetUserById(int id)
        {
            return await _userDL.GetUserById(id);
        }
    }
}