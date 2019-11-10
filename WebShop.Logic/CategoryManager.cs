using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebShop.Logic
{
    public class CategoryManager: BaseManager<Category>
    {
        public CategoryManager(WebShopDb db)
            :base(db)
        {
            
        }
        protected override DbSet<Category> Table
        {
            get 
            {
                return _db.Categories;
            }
        }
        //public List<Category> GetAll()
        //{
        //    return _db.Categories.ToList();
        //}

        //public Category Get(int id)
        //{
        //    var category = _db.Categories.FirstOrDefault(c => c.Id == id);

        //    return category;
        //}

        public void Seed()
        {
            //Categories.Add(new Category()
            //{
            //    Id = 1,
            //    Title = "Electronics"
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 4,
            //    Title = "Clothing"
            //});

            //Categories.Add(new Category()
            //{
            //    Id = 2,
            //    Title = "Phones",
            //    CategoryId = 1
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 3,
            //    Title = "TV",
            //    CategoryId = 1
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 5,
            //    Title = "Men",
            //    CategoryId = 4
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 6,
            //    Title = "Women",
            //    CategoryId = 4
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 7,
            //    Title = "Kid",
            //    CategoryId = 4
            //});
        }
    }
}