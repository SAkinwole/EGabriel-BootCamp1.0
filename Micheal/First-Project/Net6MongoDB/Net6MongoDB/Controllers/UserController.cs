using Microsoft.AspNetCore.Mvc;
using Net6MongoDB.Models;
using Net6MongoDB.Repository;

namespace Net6MongoDB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController:ControllerBase
    {
        private readonly IuserRepo userRepo;

        public UserController(IuserRepo userRepo)
        {
            this.userRepo = userRepo;
        }

        [HttpPost("/CreateUser")]
        public async Task<IActionResult> CreateUser(User user)
        {
            if (user == null) return BadRequest("User must not be null");
            await userRepo.CreateUser(user);
            return Ok(user);    

        }
        [HttpGet("/Get-All")]
        public async Task<IActionResult> GetAll()
        {
            var allUsers  = await userRepo.GetAll();
            return Ok(allUsers);
        }

        [HttpGet("/GetOne")]
        public async Task<IActionResult> GetOne(string Id)
        {
            var user = await userRepo.GetById(Id);
            return Ok(user);
        }
        [HttpPut("/UpdateUser")]
        public async Task<IActionResult> Update(string Id, User user)
        {
            var updatedUser= await userRepo.UpdateUser(Id, user);
            return Ok(updatedUser);
        }
    }
}
