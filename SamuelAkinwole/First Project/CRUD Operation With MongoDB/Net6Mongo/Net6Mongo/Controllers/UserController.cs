using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net6Mongo.Models;
using Net6Mongo.Models.Repository;
using Net6Mongo.Repository;

namespace Net6Mongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _userRepo;
        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }


        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (user == null) return BadRequest("User must be null");

           await  _userRepo.CreateUser(user);

            return Ok(user);
        }

        [HttpGet("/get-all")]
        public async Task<IActionResult> Get()
        {
            var allUsers = await _userRepo.GetAll();
            return Ok(allUsers);
        }


        [HttpGet("/get-ByID")]
        public async Task<IActionResult> GetOne(string Id)
        {
            var user = await _userRepo.Get(Id);

            return Ok(user);
        }

        [HttpPut]
        public async Task<IActionResult> Update(string Id, User user)
        {
            var updatedUser = await _userRepo.Update(Id, user);

            return Ok(updatedUser);
        }
    }
}
