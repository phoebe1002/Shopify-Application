using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Models;
using DL;

namespace BL    
{
    public class ImageBL : IImageBL
    {
        private readonly IImageDL _imageDL;
        public ImageBL(IImageDL imageDL)
        {
            _imageDL = imageDL;
        }
        public async Task<Image> AddImage(Image image)
        {
            return await _imageDL.AddImage(image);
        }
        public async Task<List<Image>> GetAllVisibleImagesByUser(User user)
        {
            List<Image> userImages = await _imageDL.GetImagesByUser(user);
            List<Image> otherUserSharedImages = await _imageDL.GetImagesSharedByOtherUsers(user);
            if (userImages == null) return otherUserSharedImages;
            if (otherUserSharedImages == null) return userImages;
            return userImages.Concat(otherUserSharedImages).ToList();
        }
    }
}