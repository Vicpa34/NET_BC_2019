using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPortalLogic
{
    public abstract class BaseManager<T>
        where T : BaseData
    {
        protected NewsPortalDb _db;
        protected abstract DbSet<T> Table { get; }
        public BaseManager(NewsPortalDb db)
        {
            _db = db;
        }

        public T Get(int id)
        {
            return Table.FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return Table;
        }

        public T Create(T data)
        {
            Table.Add(data);
            _db.SaveChanges();

            return data;
        }
        public void Update(T data)
        {
            Table.Update(data);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            var item = Table.FirstOrDefault(i => i.Id == id);
            Table.Remove(item);
            _db.SaveChanges();
        }

    }
}

   
