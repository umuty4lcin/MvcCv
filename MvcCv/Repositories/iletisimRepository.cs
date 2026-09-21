using MvcCv.Models;
using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class iletisimRepository : GenericRepository<Tbliletisim>
    {
        public iletisimRepository(AppDbContext db) : base(db)
        {
        }
    }
}
