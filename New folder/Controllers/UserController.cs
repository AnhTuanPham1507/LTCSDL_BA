using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Museco.Models;
using Museco.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Museco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //public async Task<IEnumerable<User>> 
        //{
        //    return await _userRepository
        //}
    }
}
