using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortalLogic
{
    public class News: BaseData

    {
      
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Photo { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
