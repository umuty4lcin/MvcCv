using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class AdminController : Controller
    {
        private readonly GenericRepository<TblAdmin> _repo;

        public AdminController(GenericRepository<TblAdmin> repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            var adminler = _repo.List();
            return View(adminler);
        }
        [HttpGet]
        public IActionResult AdminEkle()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AdminEkle(TblAdmin p)
        {
            if (string.IsNullOrWhiteSpace(p.KullaniciAdi) || string.IsNullOrWhiteSpace(p.Sifre))
            {
                ViewBag.Hata = "Kullanıcı adı ve şifre boş olamaz";
                return View(p);
            }
            _repo.Add(p);
            return RedirectToAction("Index");
        }

        public IActionResult AdminSil(int id)
        {
            TblAdmin t = _repo.Find(x => x.Id == id);
            if (t != null)
            {
                _repo.Delete(t);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AdminGetir(int id)
        {
            TblAdmin t = _repo.Find(x => x.Id == id);

            return View(t);
        }

        [HttpPost]
        public IActionResult AdminGetir(TblAdmin p)
        {
            TblAdmin t = _repo.Find(x => x.Id == p.Id);

            t.KullaniciAdi = p.KullaniciAdi;
            t.Sifre = p.Sifre;
            _repo.Update(t);
            return RedirectToAction("Index");
        }
    }
}
