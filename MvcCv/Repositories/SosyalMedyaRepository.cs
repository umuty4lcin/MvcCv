using MvcCv.Models;
using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class SosyalMedyaRepository : GenericRepository<TblSosyalMedya>
    {
        public SosyalMedyaRepository(AppDbContext db) : base(db)
        {
        }
    }
}
