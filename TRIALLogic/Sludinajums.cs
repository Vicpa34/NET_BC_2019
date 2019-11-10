using System;
using System.Collections.Generic;
using System.Text;

namespace TRIALLogic
{
    public class Sludinajums
    {
        public int Id { get; set; }
        public int CategoryId { get; set;}
        public int Price { get; set;}
        public string Place { get; set;}
        public string Phone { get; set;}
        public string Title { get; set; }
        public string Email { get; set;}
        public string Description { get; set;}
        public string Photo { get; set; }

        public Sludinajums()
        {
        }
    }
}
