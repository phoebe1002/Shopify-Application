using System;
using System.Collections.Generic;

namespace Models 
{
    public class User
    {
        public User() {}
        public User(User user)
        {
            Id = user.Id;
            Email = user.Email;
        }
        public int Id { get; set; }
        public string Email { get; set; }
        public List<Image> Images { get; set; }
    }
}