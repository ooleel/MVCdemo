using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCdemo.Data;
using MVCdemo.Models;

namespace MVCdemo.Controllers
{
    public class HomeController : Controller
    {
        /*private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            //ViewBag.Title = "Home Page";
            var students = _context.Students.ToList();
            return View(students);
        }

        public ActionResult About()
        {
            ViewBag.Title = "About Page";
            return View();
        }
    }
}
