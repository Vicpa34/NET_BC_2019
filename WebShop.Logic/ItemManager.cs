using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class ItemManager: BaseManager<Item>
    {
        //private int CurrentId;
        //private List<Item> Items;
       
        public ItemManager(WebShopDb db)
            :base (db)
        {
            
            //CurrentId = 100;
            //Items = new List<Item>();
        }
        protected override DbSet<Item> Table
        {
            get
            {
                return _db.Items;
            }
        }

        public List<Item> GetByCategory(int categoryId)
        {
            var items = _db.Items.Where(i => i.CategoryId == categoryId).ToList();

            return items;
        }

        //public Item Create(Item item)
        //{
        //    _db.Items.Add(item);
        //    //item.Id = CurrentId;
        //    //Items.Add(item);
        //    //CurrentId++;
        //    _db.SaveChanges();
        //    return item;
        //}

        //public void Update(Item item)
        //{
        //    var currentItem = _db.Items.FirstOrDefault(i => i.Id == item.Id);
        //    currentItem.Photo = item.Photo;
        //    currentItem.CategoryId = item.CategoryId;
        //    currentItem.Description = item.Description;
        //    currentItem.Price = item.Price;
        //    currentItem.Title = item.Title;

        //    _db.saveChanges();
        //}

        //public void Delete(int id)
        //{
        //    var item = _db.Items.FirstOrDefault(i => i.Id == id);
        //    _db.Remove(item);
        //    _db.saveChanges();
        //}

        //public Item Get(int id)
        //{
        //    var item = _db.Items.FirstOrDefault.Find(i => i.Id == id);
        //    return item;
        //}

        public void Seed()
        {
            //Items.Add(new Item()
            //{
            //    Id = 1,
            //    CategoryId = 2,
            //    Title = "Samsung Galaxy S8",
            //    Description = "Samsung Galaxy S8 phone.",
            //    Price = 400,

            //    Photo = "https://lmt.mstatic.lv/devices/images/700x980/Samsung_Galaxy_S10_128GB_Dual_SIM_G975.png"
            //});

            //Items.Add(new Item()
            //{
            //    Id = 2,
            //    CategoryId = 2,
            //    Title = "Samsung Galaxy S9",
            //    Description = "Samsung Galaxy S9 phone.",
            //    Price = 600,
            //    Photo = "https://www.bite.lv/sites/default/files/products/2019-05/Samsung%20Galaxy%20A70_White_1.png"
            //});

            //Items.Add(new Item()
            //{
            //    Id = 3,
            //    CategoryId = 2,
            //    Title = "Samsung Galaxy S8",
            //    Description = "Samsung Galaxy S8 phone.",
            //    Price = 400,
            //    Photo = "lcmpzLmNvbQooYykgMjAxMi0yMDE1IEl2YW4gTWFsb3BpbnNreSAtIGh0dHA6Ly9pbXNreS5jbwotLT48ZGVmcz48c3R5bGUgdHlwZT0idGV4dC9jc3MiPjwhW0NEQVRBWyNob2xkZXJfMTY2OTUzZGI1ZWMgdGV4dCB7IGZpbGw6I0FBQUFBQTtmb250LXdlaWdodDpib2xkO2ZvbnQtZmFtaWx5OkFyaWFsLCBIZWx2ZXRpY2EsIE9wZW4gU2Fucywgc2Fucy1zZXJpZiwgbW9ub3NwYWNlO2ZvbnQtc2l6ZToxMnB0IH0gXV0+PC9zdHlsZT48L2RlZnM+PGcgaWQ9ImhvbGRlcl8xNjY5NTNkYjVlYyI+PHJlY3Qgd2lkdGg9IjI0MiIgaGVpZ2h0PSIyMDAiIGZpbGw9IiNFRUVFRUUiLz48Zz48dGV4dCB4PSI4OS44NTkzNzUiIHk9IjEwNS40Ij4yNDJ4MjAwPC90ZXh0PjwvZz48L2c+PC9zdmc+"
            //});

            //Items.Add(new Item()
            //{
            //    Id = 4,
            //    CategoryId = 2,
            //    Title = "Samsung Galaxy S8",
            //    Description = "Samsung Galaxy S8 phone.",
            //    Price = 400,
            //    Photo = "data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/PjxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iMjQyIiBoZWlnaHQ9IjIwMCIgdmlld0JveD0iMCAwIDI0MiAyMDAiIHByZXNlcnZlQXNwZWN0UmF0aW89Im5vbmUiPjwhLS0KU291cmNlIFVSTDogaG9sZGVyLmpzLzEwMCV4MjAwCkNyZWF0ZWQgd2l0aCBIb2xkZXIuanMgMi42LjAuCkxlYXJuIG1vcmUgYXQgaHR0cDovL2hvbGRlcmpzLmNvbQooYykgMjAxMi0yMDE1IEl2YW4gTWFsb3BpbnNreSAtIGh0dHA6Ly9pbXNreS5jbwotLT48ZGVmcz48c3R5bGUgdHlwZT0idGV4dC9jc3MiPjwhW0NEQVRBWyNob2xkZXJfMTY2OTUzZGI1ZWMgdGV4dCB7IGZpbGw6I0FBQUFBQTtmb250LXdlaWdodDpib2xkO2ZvbnQtZmFtaWx5OkFyaWFsLCBIZWx2ZXRpY2EsIE9wZW4gU2Fucywgc2Fucy1zZXJpZiwgbW9ub3NwYWNlO2ZvbnQtc2l6ZToxMnB0IH0gXV0+PC9zdHlsZT48L2RlZnM+PGcgaWQ9ImhvbGRlcl8xNjY5NTNkYjVlYyI+PHJlY3Qgd2lkdGg9IjI0MiIgaGVpZ2h0PSIyMDAiIGZpbGw9IiNFRUVFRUUiLz48Zz48dGV4dCB4PSI4OS44NTkzNzUiIHk9IjEwNS40Ij4yNDJ4MjAwPC90ZXh0PjwvZz48L2c+PC9zdmc+"
            //});
        }
    }
}