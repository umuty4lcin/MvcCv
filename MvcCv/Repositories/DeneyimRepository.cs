using MvcCv.Models;
using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class DeneyimRepository : GenericRepository<TblDeneyimlerim>
    {
        public DeneyimRepository(AppDbContext db) : base(db)
        {
        }
    }
}
