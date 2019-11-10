using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace NewsPortalLogic
{
    public class NewsManager : BaseManager<News>
    {
        public NewsManager(NewsPortalDb db)
         : base(db)
        {

        }
        protected override DbSet<News> Table
        {
            get
            {
                return _db.News;
            }
        }

        News = new List<News>();
        public List<News> GetAll()
        {
                      
             return (News);
           
        }



    }
}
