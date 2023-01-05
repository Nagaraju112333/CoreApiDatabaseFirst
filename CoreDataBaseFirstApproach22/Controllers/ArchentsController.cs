using CoreDataBaseFirstApproach22.ArchenstModels;
using Microsoft.AspNetCore.Mvc;

namespace CoreDataBaseFirstApproach22.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArchentsController : Controller
    {
        private readonly ArchentsContext _context;
        public ArchentsController(ArchentsContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("GetallProducts")]
        public IActionResult getallproducts()
        {
            var result=_context.Products1s.ToList();
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
        [Route("saveroles")]
        public IActionResult Addrules(Role rol)
        {
            if (rol != null)
            {
                return Ok(rol);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
