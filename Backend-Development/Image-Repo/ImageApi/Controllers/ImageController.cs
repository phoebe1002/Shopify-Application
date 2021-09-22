using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BL;
using Models;

namespace ImageApi.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly IImageBL _imageBL;
        private readonly IUserBL _userBL;
        public ImageController(IImageBL imageBL, IUserBL userBL)
        {
            _imageBL = imageBL;
            _userBL = userBL;
        }

        [HttpPost]
        public async Task<IActionResult> AddImage([FromBody] Image newImage)
        {
            return Created("api/Image", await _imageBL.AddImage(newImage));
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetAllVisibleImagesByUser(int userId)
        {
            User user = await _userBL.GetUserById(userId);
            return Ok(await _imageBL.GetAllVisibleImagesByUser(user));
        }
    }
}