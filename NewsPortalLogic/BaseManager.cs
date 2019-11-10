using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortalLogic
{
    public abstract class BaseManager<T>
        where T : BaseData
    {
        protected NewsPortalDb _db;
        protected abstract DbSet<T> Table { get; }
        public BaseManager(NewsPortalDb db)
        {
            _db = db;
        }

    }
}

   
