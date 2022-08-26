using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Reposiotry;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : Controller
    {
        private readonly IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }


        [HttpPost("/CreateUser")]

        public async Task<IActionResult> Create(User user)
        {
            if(user == null)
            {
                return BadRequest("User cannot be null");
            }

            await _userRepo.CreateUser(user);

            return Ok(user);
        }

        [HttpGet("/GetAllUser")]

        public async Task<IActionResult> Get()
        {
            var allUsers = await _userRepo.GetAll();

            return Ok(allUsers);
        }

        [HttpGet("/get")]

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
