using MvcCv.Models;
using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class HakkimdaRepository : GenericRepository<TblHakkimda>
    {
        public HakkimdaRepository(Models.AppDbContext db) : base(db)
        {
        }
    }
}
