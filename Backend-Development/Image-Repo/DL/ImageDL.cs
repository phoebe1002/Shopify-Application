using System;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace DL
{
    public class ImageDL : IImageDL
    {
        private readonly AppDBContext _context;
        public ImageDL(AppDBContext context)
        {
            _context = context;
        }
        public async Task<Image> AddImage(Image image)
        {
            Image added = _context.Images.Add(image).Entity;
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();
            return added;
        }
        public async Task<List<Image>> GetImagesByUser(User user)
        {
            return await _context.Images
                .AsNoTracking()
                .Where(target => target.UserId == target.Id)
                .ToListAsync();
        }
        public async Task<List<Image>> GetImagesSharedByOtherUsers(User user)
        {
            return await _context.Images
                .AsNoTracking()
                .Where(target => target.UserId != target.Id && target.IsShared == true)
                .ToListAsync();
        }
    }
}