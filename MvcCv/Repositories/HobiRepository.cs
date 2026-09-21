using MvcCv.Models;
using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class HobiRepository : GenericRepository<TblHobilerim>
    {
        public HobiRepository(AppDbContext db) : base(db)
        {
        }
    }
}
