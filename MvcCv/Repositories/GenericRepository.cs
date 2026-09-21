using System.Collections.Generic;
using MvcCv.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MvcCv.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        private readonly AppDbContext _db;

        private readonly DbSet<T> _table;

        public GenericRepository(AppDbContext db)
        {
            _db = db;
            _table = _db.Set<T>();
        }

        public List<T> List()
        {
            return _table.ToList();
        }

        public void Add(T item)
        {
            _table.Add(item);
            _db.SaveChanges();
        }

        public void Delete(T item)
        {
            _table.Remove(item);
            _db.SaveChanges();
        }

        public T? Get(int id)
        {
            return _table.Find(id);
        }

        public void Update(T item)
        {
            _table.Update(item);
            _db.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _table.FirstOrDefault(where);
        }
    }
}
