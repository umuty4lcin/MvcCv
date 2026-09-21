using MvcCv.Models;
using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class YetenekRepository : GenericRepository<TblYeteneklerim>
    {
        public YetenekRepository(AppDbContext db) : base(db)
        {
        }
    }
}
