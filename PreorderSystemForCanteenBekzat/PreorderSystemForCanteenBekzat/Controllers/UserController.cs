using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PreorderSystemForCanteenBekzat.Models;
using PreorderSystemForCanteenBekzat.Repositories.Interfaces;

namespace PreorderSystemForCanteenBekzat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }




        [HttpGet("id/{id}")]
        public IActionResult GetUserById(int id)
        {

            return Ok(_userRepository.GetUserById(id));
        }

        [HttpGet("remove/{name}")]
        public IActionResult RemoveUserByName(string name)
        {
            return Ok(_userRepository.RemoveUserByName(name));
        }

        [HttpGet("add/{id}/{firstName}/{secondName}/{login}")]
        public IActionResult AddUserById(int id, string firstName, string secondName, string login)
        {
            return Ok(_userRepository.AddUserById(id, firstName, secondName, login));
        }




    }
}
