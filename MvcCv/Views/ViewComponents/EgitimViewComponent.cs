using Microsoft.AspNetCore.Mvc;
using MvcCv.Models;
using Microsoft.EntityFrameworkCore;

namespace MvcCv.Views.ViewComponents
{
    public class EgitimViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;

        public EgitimViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var liste = await _db.TblEgitimlerim.OrderBy(x => x.Id)
                                 .ToListAsync();
            return View(liste);
        }
    }
}
