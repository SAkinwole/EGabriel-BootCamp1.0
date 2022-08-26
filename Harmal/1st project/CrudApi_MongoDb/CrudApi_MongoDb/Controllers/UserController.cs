using CrudApiMongodb.Models;
using CrudApiMongodb.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudApiMongodb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo userRepo;

        public UserController(IUserRepo userRepo)
        {
            this.userRepo = userRepo;
        }
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (user == null) { return BadRequest("User must not be null"); }

            await this.userRepo.CreaterUser(user);
            return Ok(user);
        }
        [HttpGet("/get-all")]
        public async Task<IActionResult> Get()
        {
            var allUsers = await this.userRepo.GetAll();
            return Ok(allUsers);

        }
        [HttpGet("/get")]
        public async Task<IActionResult> GetId(String Id)
        {
            var user = await this.userRepo.GetOne(Id);
            return Ok(user);

        }
        [HttpPut]
        public async Task<IActionResult> update(String Id, User user)
        {
            var UpdateUser = await this.userRepo.Update(Id, user);
            return Ok(UpdateUser);

        }
    }
}
