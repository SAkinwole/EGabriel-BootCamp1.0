using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NET6MONGODB.Models;
using NET6MONGODB.Repository;

namespace Net6MongoDB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var allUsers = await  _userRepo.GetAll();
            return Ok(allUsers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string Id)
        {
            var user = await  _userRepo.Get(Id);
            return Ok(user);
        }
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            await _userRepo.CreateUser(user);
            return Ok(user);
        }

        [HttpPut]
        public async Task<IActionResult> update(string Id, User user)
        {
            var updatedUser = await _userRepo.update(Id, user);
            return Ok(updatedUser);
        }
    }
}