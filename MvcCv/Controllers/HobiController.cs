using Microsoft.AspNetCore.Mvc;
using MvcCv.Repositories;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    public class HobiController : Controller
    {
        private readonly HobiRepository _repo;

        public HobiController(HobiRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var hobiler = _repo.List();
            return View(hobiler);
        }

        [HttpPost]
        public IActionResult Index(TblHobilerim p)
        {
            var t = _repo.Find(x => x.Id == p.Id);
            if (t == null)
            {
                return RedirectToAction("Index");
            }
            t.Aciklama1 = p.Aciklama1;
            t.Aciklama2 = p.Aciklama2;
            _repo.Update(t);
            return RedirectToAction("Index");
        }
    }
}
