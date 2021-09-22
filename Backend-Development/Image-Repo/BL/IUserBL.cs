﻿using System;
using System.Threading.Tasks;
using Models;

namespace BL
{
    public interface IUserBL
    {
        Task<User> AddUser(User user);
        Task<User> GetUserByPhoneNumber(string phone);
        Task<User> GetUserById(int id);
    }
}
