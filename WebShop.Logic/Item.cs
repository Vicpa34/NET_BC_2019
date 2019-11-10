using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class Item:BaseData
    {
        public int Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public int CategoryId { get; set; }

        public Item(int id, int categoryId)
        {
            Id = id;
            CategoryId = categoryId;
        }

        public Item()
        {
        }
    }

}
