using Microsoft.AspNetCore.Mvc;
using MVCdemo.Data;

namespace MVCdemo.Areas.Students.Controllers
{
    [Area("Students")]
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CourseController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
