using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class SosyalMedyaController : Controller
    {
        private readonly SosyalMedyaRepository _repo;

        public SosyalMedyaController(SosyalMedyaRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var veriler = _repo.List();
            return View(veriler);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(TblSosyalMedya p)
        {
            if (!string.IsNullOrWhiteSpace(p.Link) && !p.Link.StartsWith("http"))
            {
                p.Link = "https://" + p.Link;
            }

            _repo.Add(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            var sosyalMedya = _repo.Find(x => x.Id == id);
            if (sosyalMedya == null)
            {
                return NotFound();
            }
            return View(sosyalMedya);
        }

        [HttpPost]
        public IActionResult Guncelle(TblSosyalMedya p)
        {
            if (!string.IsNullOrWhiteSpace(p.Link) && !p.Link.StartsWith("http"))
            {
                p.Link = "https://" + p.Link;
            }

            var sosyalMedya = _repo.Find(x => x.Id == p.Id);
            if (sosyalMedya == null)
            {
                return NotFound();
            }

            sosyalMedya.Ad = p.Ad;
            sosyalMedya.Link = p.Link;

            sosyalMedya.Durum = true;

            _repo.Update(sosyalMedya);
            return RedirectToAction("Index");
        }

        public IActionResult Sil(int id)
        {
            var t = _repo.Find(x => x.Id == id);
            if(t != null)
            {
                t.Durum = false;
                _repo.Update(t);
            }
            return RedirectToAction("Index");
        }
    }
}
