using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductEnum.Models
{
    public class DataContext: System.Data.Entity.DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ProductEnum.Models.Product> Products { get; set; }
    }
}