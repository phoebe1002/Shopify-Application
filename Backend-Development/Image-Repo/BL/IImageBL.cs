using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace BL
{
    public interface IImageBL
    {
        Task<Image> AddImage(Image image);
        Task<List<Image>> GetAllVisibleImagesByUser(User user);
    }
}