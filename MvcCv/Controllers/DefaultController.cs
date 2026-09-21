using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MvcCv.Models;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly AppDbContext _db;
        private readonly HakkimdaRepository _hakkimdaRepository;

        public DefaultController(AppDbContext db, HakkimdaRepository hakkimdaRepository)
        {
            _db = db;
            _hakkimdaRepository = hakkimdaRepository;
        }

        public IActionResult Index()
        {
            var hakkimda = _hakkimdaRepository.List();
            return View(hakkimda);
        }

        [HttpPost]
        public IActionResult MesajGonder(Tbliletisim t)
        {
            t.Tarih = DateOnly.FromDateTime(DateTime.Now);

            _db.Tbliletisim.Add(t);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
