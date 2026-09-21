using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using MvcCv.Models;

namespace MvcCv.Views.ViewComponents

{
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public class YeteneklerimViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        public YeteneklerimViewComponent(AppDbContext db)
        {
            _db = db;
        }
        
        
        
        
        
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var liste = await _db.TblYeteneklerim.OrderBy(x => x.Id)
                                 .ToListAsync();
            return View(liste);
        }
    }
}
