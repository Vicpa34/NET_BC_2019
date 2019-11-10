using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdsPortal.Logic
{
    public class AdsPortalDb : DbContext
    {
        public AdsPortalDb(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Ad> Ads { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
