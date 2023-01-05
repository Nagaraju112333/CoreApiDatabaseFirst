using CoreDataBaseFirstApproach22.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreDataBaseFirstApproach22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly venkatContext _contect;
        public UserController(venkatContext contect)
        {
            _contect = contect;
        }
        [HttpGet]
        [Route("Getallusers")]
        public  IActionResult GetallUsers()
        {
            var result = _contect.UserLogins.ToList();
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        [Route("saveuserdata")]
        public IActionResult SaveUserDetails(UserLogin user)
        {
            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
