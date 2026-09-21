using Microsoft.AspNetCore.Mvc;
using MvcCv.Repositories;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    public class HakkimdaController : Controller
    {
        private readonly HakkimdaRepository _repo;

        public HakkimdaController(HakkimdaRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var hakkimda = _repo.List();
            return View(hakkimda);
        }

        [HttpPost]
        public IActionResult Index(TblHakkimda p)
        {
            var t = _repo.Find(x => x.Id == p.Id);
            if (t == null)
            {
                return RedirectToAction("Index");
            }

            t.Ad = p.Ad;
            t.Soyad = p.Soyad;
            t.Adres = p.Adres;
            t.Telefon = p.Telefon;
            t.Mail = p.Mail;
            t.Açıklama = p.Açıklama;
            t.Resim = p.Resim;

            _repo.Update(t);
            return RedirectToAction("Index");
        }
    }
}
