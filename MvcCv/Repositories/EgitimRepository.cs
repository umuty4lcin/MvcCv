using MvcCv.Models;
using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class EgitimRepository : GenericRepository<TblEgitimlerim>
    {
        public EgitimRepository(AppDbContext db) : base(db)
        {
        }
    }
}
