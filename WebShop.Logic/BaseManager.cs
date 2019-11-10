using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    //generic types
    public abstract class BaseManager<T>
        where T : BaseData    //to guarantee that T is not ex.Date/Time but always a class
    {
        protected WebShopDb _db;
        protected abstract DbSet<T> Table { get; }

        public BaseManager (WebShopDb db)
            {
            _db = db;

            }
        public T Get(int id)
        {
            return Table.FirstOrDefault(i=>i.Id ==id);
        }

        public List<T> GetAll()
        {
            return Table.ToList();
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
