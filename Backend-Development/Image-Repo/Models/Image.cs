using System;

namespace Models
{
    public class Image
    {
        public Image(){}
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }        
        public Boolean IsShared { get; set; }
        public int UserId { get; set; }
    }
}