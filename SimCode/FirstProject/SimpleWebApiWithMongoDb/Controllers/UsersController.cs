using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleWebApiWithMongoDb.Models.Users;

namespace SimpleWebApiWithMongoDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserRepo _repo;

        public UsersController(IUserRepo repo)
        {
            _repo = repo;
        }

        [HttpPost]
        [Route("CreateUser")]
        public async Task<IActionResult> Create(User user)
        {
            if (user == null) return BadRequest("User can not be null");

            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _repo.CreateUser(user);
            return Ok(user);
        }

        [HttpGet]
        [Route("Users")]
        public async Task<IActionResult> Get()
        {
            var users = await _repo.GetUsers();
            return Ok(users);
        }

        [HttpGet]
        [Route("User")]
        public async Task<IActionResult> Get(string id)
        {
            var user = await _repo.GetUser(id);
            return Ok(user);
        }

        [HttpGet]
        [Route("UpdateUser")]
        public async Task<IActionResult> Update(string id, User user)
        {
            var updateUser = await _repo.UpdateUser(id, user);
            return Ok(updateUser);
        }
    }
}
