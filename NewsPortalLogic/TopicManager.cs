using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortalLogic
{
    public class TopicManager : BaseManager<Topic>
    {
        public TopicManager(NewsPortalDb db)
          : base(db)
        {

        }
        protected override DbSet<Topic> Table
        {
            get
            {
                return _db.Topics;
            }
        }
    }
}
