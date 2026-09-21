using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcCv.Models;

namespace MvcCv.Views.ViewComponents
{
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public class DeneyimViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;

        public DeneyimViewComponent(AppDbContext db)
        {
            _db = db;
        }
        
        
        
        
        
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var liste = await _db.TblDeneyimlerim.OrderBy(x => x.Id)
                                 .ToListAsync();
            return View(liste);
        }
    }
}
