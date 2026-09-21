using Microsoft.AspNetCore.Mvc;
using MvcCv.Models;
using Microsoft.EntityFrameworkCore;

namespace MvcCv.Views.ViewComponents
{
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public class IletisimViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;

        public IletisimViewComponent(AppDbContext db)
        {
            _db = db;
        }

        
        
        
        
        
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var liste = await _db.Tbliletisim.OrderBy(x => x.Id)
                                 .ToListAsync();
            return View(liste);
        }
    }
}
