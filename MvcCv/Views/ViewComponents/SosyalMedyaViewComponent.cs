using Microsoft.AspNetCore.Mvc;
using MvcCv.Models;
using Microsoft.EntityFrameworkCore;

namespace MvcCv.Views.ViewComponents
{
    public class SosyalMedyaViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;

        public SosyalMedyaViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var liste = await _db.TblSosyalMedya.Where(x => x.Durum == true).OrderBy(x => x.Id)
                                 .ToListAsync();
            return View(liste);
        }
    }
}
