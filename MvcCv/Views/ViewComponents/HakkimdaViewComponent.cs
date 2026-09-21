using Microsoft.AspNetCore.Mvc;
using MvcCv.Models;
using Microsoft.EntityFrameworkCore;

namespace MvcCv.Views.ViewComponents
{
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public class HakkimdaViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;

        public HakkimdaViewComponent(AppDbContext db)
        {
            _db = db;
        }
        
        
        
        
        
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var liste = await _db.TblHakkimda.OrderBy(x => x.Id)
                                 .ToListAsync();
            return View(liste);
        }
    }
}
