using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortalLogic
{
    public class NewsPortalDb: DbContext
    {
        public NewsPortalDb(DbContextOptions options)
            : base(options)
        { 
        }
        public DbSet<News> News { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}
