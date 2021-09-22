using System;
using System.Threading.Tasks;
using Models;
using System.Collections.Generic;

namespace DL
{
    public interface IImageDL
    {
        Task<Image> AddImage(Image image);
        Task<List<Image>> GetImagesByUser(User user);
        Task<List<Image>> GetImagesSharedByOtherUsers(User user);
    }
}