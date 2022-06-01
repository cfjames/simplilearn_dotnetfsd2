using Microsoft.EntityFrameworkCore;

namespace Phase2Section2._24.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private DbContext _db = null;
        private DbSet<T> _table = null;
        public GenericRepository() { }

        public GenericRepository(DbContext db)
        {
            this._db = db;
            _table = _db.Set<T>();
        }

        public IEnumerable<T> SelectAll()
        {
            return _table.ToList();
        }
        public T SelectByID(object id)
        {
            return _table.Find(id);
        }
        public void Insert(T entity)
        {
            _table.Add(entity);
        }
        public void Update(T entity)
        { 
            _table.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(object id)
        { 
            T existing = _table.Find(id);
            _table.Remove(existing);
        }
        public void Save()
        { 
            _db.SaveChanges();
        }
    }
}
