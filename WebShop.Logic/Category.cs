using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class Category:BaseData
    {

        //public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? CategoryId { get; set; }

        [NotMapped]
        public int ItemCount { get; set; }
        /// <summary>
        /// 
        /// </summary>

    }
}
