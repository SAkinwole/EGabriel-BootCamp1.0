using Microsoft.AspNetCore.Mvc;
using API_MongoDB.Respository;
using API_MongoDB.Model;

namespace API_MongoDB.Controllers
{
    [Route("/api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _UserRepo;

        public UserController(IUserRepo userRepo)
        { _UserRepo = userRepo; }


        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (user == null) return BadRequest("User cannot be null");
            await _UserRepo.CreateUser(user);
            return Ok();
        }

        [HttpGet("/getAll")]
        public async Task<IActionResult> GetAll()
        {
            var allUser = await _UserRepo.GetAll();
            
            return Ok(allUser);
        }

        [HttpGet("/get")]
        public async Task<IActionResult> Get(string Id)
        {
            var allUser = await _UserRepo.GetbyId(Id);

            return Ok(allUser);

        }

        [HttpPut]
        public async Task<IActionResult> UpdateAll (string Id, User user)
            {
                var UpdatedUser = await _UserRepo.Update(Id, user);

                return Ok(UpdatedUser);
            }
        }
}
