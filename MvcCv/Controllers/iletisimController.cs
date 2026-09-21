using Microsoft.AspNetCore.Mvc;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class iletisimController : Controller
    {
        private readonly iletisimRepository _repo;

        public iletisimController(iletisimRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var mesajlar = _repo.List();

            return View(mesajlar);
        }
    }
}
