
using Microsoft.AspNetCore.Mvc;
using mongoCRUD.Models;
using mongoCRUD.Repository;

namespace mongoCRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
       {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        { 
            _userRepository = userRepository;
        }


        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (user == null) return BadRequest("User cannot be null");
            await _userRepository.Create(user);
            return Ok();
        }

        [HttpGet("/getAll")]
        public async Task<IActionResult> GetAll()
        {
            var allUser = await _userRepository.GetAll();
            
            return Ok(allUser);
        }

        [HttpGet("/get")]
        public async Task<IActionResult> Get(string Id)
        {
            var allUser = await _userRepository.Get(Id);

            return Ok(allUser);

        }

        [HttpPut]
        public async Task<IActionResult> Update (string Id, User user)
        {
            var UpdatedUser = await _userRepository.Update(Id, user);

            return Ok(UpdatedUser);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete (string Id)
        {
            await _userRepository.Delete(Id);

            return Ok("Deleted");
        }
    }
}