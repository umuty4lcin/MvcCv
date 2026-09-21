using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class DeneyimController : Controller
    {
        private readonly DeneyimRepository _repo;

        public DeneyimController(DeneyimRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var deneyimler = _repo.List();
            return View(deneyimler);
        }

        [HttpGet]
        public IActionResult DeneyimEkle()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeneyimEkle(TblDeneyimlerim p)
        {
            if (string.IsNullOrWhiteSpace(p.Baslik))
            {
                ViewBag.Hata = "Başlık boş olamaz";
                return View(p);
            }

            _repo.Add(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeneyimSil(int id)
        {
            TblDeneyimlerim t = _repo.Find(x => x.Id == id);
            if (t != null)
            {
                _repo.Delete(t);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeneyimGetir(int id)
        {
            TblDeneyimlerim t = _repo.Find(x => x.Id == id);

            return View(t);
        }

        [HttpPost]
        public IActionResult DeneyimGetir(TblDeneyimlerim p)
        {
            TblDeneyimlerim t = _repo.Find(x => x.Id == p.Id);

            t.Baslik = p.Baslik;
            t.AltBaslik = p.AltBaslik;
            t.Tarih = p.Tarih;
            t.Aciklama = p.Aciklama;

            _repo.Update(t);
            return RedirectToAction("Index");
        }
    }
}
