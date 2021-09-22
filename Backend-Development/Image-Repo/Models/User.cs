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
            PhoneNumber = user.PhoneNumber;
        }
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public List<Image> Images { get; set; }
    }
}