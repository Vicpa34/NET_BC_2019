using System;
using System.Collections.Generic;
using System.Text;

namespace TRIALLogic
{
    public class CategoryManager
    {
        private List<Category> Categories;

        public CategoryManager()
        {
            Categories = new List<Category>();
        }

        public List<Category> GetAll()
        {
            return Categories;
        }

        public Category Get(int id)
        {
            var category = Categories.Find(c => c.Id == id);

            return category;
        }

        public void Seed()
        {
            Categories.Add(new Category()
            {
                Id = 1,
                Title = "Electronics"
            });
            Categories.Add(new Category()
            {
                Id = 4,
                Title = "Clothing"
            });

            Categories.Add(new Category()
            {
                Id = 2,
                Title = "Home"                
            });
            Categories.Add(new Category()
            {
                Id = 3,
                Title = "Job"                
            });
            Categories.Add(new Category()
            {
                Id = 5,
                Title = "Car"               
            });
            Categories.Add(new Category()
            {
                Id = 6,
                Title = "Hobby"                
            });
            Categories.Add(new Category()
            {
                Id = 7,
                Title = "Kid"                
            });
            Categories.Add(new Category()
            {
                Id = 8,
                Title = "Pet"               
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "aaaaaa",
                CategoryId = 1
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "bbbbbbb",
                CategoryId = 1
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "aaaaaa",
                CategoryId = 2
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "bbbbbb",
                CategoryId = 2
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "aaaaaa",
                CategoryId = 3
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "bbbbb",
                CategoryId = 3
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "aaaaaaa",
                CategoryId = 4
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "bbbbbbbb",
                CategoryId = 4
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "aaaaaaa",
                CategoryId = 5
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "bbbbbbb",
                CategoryId = 5
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "aaaaa",
                CategoryId = 6
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "bbbbbbb",
                CategoryId = 6
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "aaaaaaa",
                CategoryId = 7
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "bbbbb",
                CategoryId = 7
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "aaaaa",
                CategoryId = 8
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "bbbbb",
                CategoryId = 8
            });
        }
    }
}
