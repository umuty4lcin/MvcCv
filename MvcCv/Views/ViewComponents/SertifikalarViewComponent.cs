using Microsoft.AspNetCore.Mvc;
using MvcCv.Models;
using Microsoft.EntityFrameworkCore;

namespace MvcCv.Views.ViewComponents
{
    public class SertifikalarViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        public SertifikalarViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var liste = await _db.TblSertifikalarim.OrderBy(x => x.Id)
                                 .ToListAsync();
            return View(liste);
        }
    }
}
