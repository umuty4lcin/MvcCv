using Microsoft.AspNetCore.Mvc;
using MvcCv.Models;
using Microsoft.EntityFrameworkCore;

namespace MvcCv.Views.ViewComponents
{
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public class HobilerimViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        public HobilerimViewComponent(AppDbContext db)
        {
            _db = db;
        }
        
        
        
        
        
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var liste = await _db.TblHobilerim.OrderBy(x => x.Id)
                                 .ToListAsync();
            return View(liste);
        }
    }
}
