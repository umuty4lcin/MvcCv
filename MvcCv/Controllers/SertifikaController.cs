using Microsoft.AspNetCore.Mvc;
using MvcCv.Repositories;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    public class SertifikaController : Controller
    {
        private readonly SertifikaRepository _repo;

        public SertifikaController(SertifikaRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var sertifikalar = _repo.List();
            return View(sertifikalar);
        }

        [HttpGet]
        public IActionResult SertifikaGetir(int id)
        {
            var sertifika = _repo.Find(x => x.Id == id);

            return View(sertifika);
        }

        [HttpPost]
        public IActionResult SertifikaGetir(TblSertifikalarim p)
        {
            var sertifika = _repo.Find(x => x.Id == p.Id);

            sertifika.Aciklama = p.Aciklama;
            sertifika.Tarih = p.Tarih;
            _repo.Update(sertifika);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult SertifikaEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SertifikaEkle(TblSertifikalarim p)
        {
            _repo.Add(p);
            return RedirectToAction("Index");
        }

        public IActionResult SertifikaSil (int id)
        {
            var sertifika = _repo.Find(x => x.Id == id);
            _repo.Delete(sertifika);
            return RedirectToAction("Index");
        }
    }
}
