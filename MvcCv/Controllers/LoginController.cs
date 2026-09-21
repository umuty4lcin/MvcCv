using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly GenericRepository<TblAdmin> _repo;

        public LoginController(GenericRepository<TblAdmin> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(TblAdmin p, bool beniHatirla, string? returnUrl)
        {
            var bilgi = _repo.Find(x => x.KullaniciAdi == p.KullaniciAdi && x.Sifre == p.Sifre);
            if (bilgi == null)
            {
                ViewBag.Hata = "Kullanıcı adı veya şifre hatalı.";
                return View();
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, bilgi.KullaniciAdi!)
            };
            var kimlik = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var ayarlar = new AuthenticationProperties { IsPersistent = beniHatirla };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(kimlik),
                ayarlar);

            if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Deneyim");
        }

        public async Task<IActionResult> Cikis()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
    }
}
