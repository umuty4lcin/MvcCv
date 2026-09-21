using MvcCv.Models;
using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class SertifikaRepository : GenericRepository<TblSertifikalarim>
    {
        public SertifikaRepository(AppDbContext db) : base(db)
        {
        }
    }
}
