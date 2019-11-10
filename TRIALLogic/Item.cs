using System;

namespace TRIALLogic
{
    public class Item
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
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

