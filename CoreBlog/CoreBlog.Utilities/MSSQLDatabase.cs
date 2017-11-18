using Microsoft.EntityFrameworkCore;
using System;

namespace CoreBlog.Utilities
{
    public class MSSQLDatabase<T> : IPersistenceBehavior<T> where T : class
    {
        DbContext _db;

        public MSSQLDatabase(DbContext db)
        {
            this._db = db;
        }

        public void Add(T obj)
        {
            _db.Set<T>().Add(obj);
            _db.SaveChanges();
        }

        public void Update(T obj)
        {
            var entry = _db.Entry(obj);
            if (entry.State == EntityState.Detached)
            {
                _db.Set<T>().Attach(obj);
                entry.State = EntityState.Modified;
                _db.SaveChanges();
            }
        }
    }
}
