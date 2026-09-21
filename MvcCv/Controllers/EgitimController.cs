using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class EgitimController : Controller
    {
        private readonly EgitimRepository _repo;

        public EgitimController(EgitimRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var egitimler = _repo.List();
            return View(egitimler);
        }

        [HttpGet]
        public IActionResult EgitimEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EgitimEkle(TblEgitimlerim p)
        {
            if (!ModelState.IsValid)
            {
                return View(p);
            }
            _repo.Add(p);
            return RedirectToAction("Index");
        }

        public IActionResult EgitimSil(int id)
        {
            var egitim = _repo.Find(x => x.Id == id);
            if (egitim != null)
            {
                _repo.Delete(egitim);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EgitimGuncelle(int id)
        {
            var egitim = _repo.Find(x => x.Id == id);

            return View(egitim);
        }

        [HttpPost]
        public IActionResult EgitimGuncelle(TblEgitimlerim p)
        {
            if (!ModelState.IsValid)
            {
                return View(p);
            }

            var egitim = _repo.Find(x => x.Id == p.Id);
            if (egitim != null)
            {
                egitim.Baslik = p.Baslik;
                egitim.Altaslik1 = p.Altaslik1;
                egitim.AltBaslik2 = p.AltBaslik2;
                egitim.Gno = p.Gno;
                egitim.Tarih = p.Tarih;
                _repo.Update(egitim);
            }
            return RedirectToAction("Index");
        }
    }
}
