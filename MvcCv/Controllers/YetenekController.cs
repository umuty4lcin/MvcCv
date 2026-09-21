using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class YetenekController : Controller
    {
        private readonly YetenekRepository _repo;

        public YetenekController(YetenekRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var yetenekler = _repo.List();
            return View(yetenekler);
        }

        [HttpGet]
        public IActionResult YeniYetenek()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniYetenek(TblYeteneklerim p)
        {
            _repo.Add(p);
            return RedirectToAction("Index");
        }

        public IActionResult YetenekSil(int id)
        {
            var yetenek = _repo.Find(x => x.Id == id);

            _repo.Delete(yetenek);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult YetenekDuzenle(int id)
        {
            var yetenek = _repo.Find(x => x.Id == id);

            return View(yetenek);
        }

        [HttpPost]
        public IActionResult YetenekDuzenle(TblYeteneklerim p)
        {
            var yetenek = _repo.Find(x => x.Id == p.Id);

            yetenek.Yetenek = p.Yetenek;
            yetenek.Oran = p.Oran;

            _repo.Update(yetenek);
            return RedirectToAction("Index");
        }
    }
}
