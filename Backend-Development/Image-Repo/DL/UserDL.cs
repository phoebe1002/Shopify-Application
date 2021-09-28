using System;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using Models;

namespace  DL
{
    public class UserDL : IUserDL
    {
        private readonly AppDBContext _context;
        public UserDL(AppDBContext context)
        {
            _context = context;
        }
        public async Task<User> AddUser(User user)
        {
            User added = _context.Users.Add(user).Entity;
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();
            return added;
        }
        public async Task<User> GetUserByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(user => user.Email == email);
        }
        public async Task<User> GetUserById(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(user => user.Id == id);
        }
    }
}