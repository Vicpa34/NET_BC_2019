using NewsPortalLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortal.Models
{
    public class IndexViewModel
    {
        public IEnumerable<News> news { get; set; }

        public bool ShowCategories { get; set; } = false;

        public IEnumerable<Topic> topics { get; set; }

    }

   
}
