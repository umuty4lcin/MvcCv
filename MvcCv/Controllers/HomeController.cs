using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MvcCv.Models;
using MvcCv.Models.Entity;
using System.Diagnostics;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
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
        }

        public ActionResult Test()
        {
            return View();
        }
        public ActionResult Test2()
        {
            return View();
        }
    }
}
