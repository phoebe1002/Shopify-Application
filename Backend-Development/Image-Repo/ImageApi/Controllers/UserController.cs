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
    public class UserController : ControllerBase
    {
        private readonly IUserBL _userBL;
        public UserController(IUserBL userBL)
        {
            _userBL = userBL;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] User newUser)
        {
            return Created("api/Users", await _userBL.AddUser(newUser));
        }

        [HttpGet("{phoneNumber}")]
        public async Task<IActionResult> GetUserByPhoneNumber(string phoneNumber)
        {
            return Ok(await _userBL.GetUserByPhoneNumber(phoneNumber));
        }
    }
}