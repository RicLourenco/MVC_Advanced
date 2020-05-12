using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Advanced.Data
{
    public class MVC_AdvancedContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MVC_AdvancedContext() : base("name=MVC_AdvancedContext")
        {
        }

        public System.Data.Entity.DbSet<MVC_Advanced.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<MVC_Advanced.Models.DocumentType> DocumentTypes { get; set; }

        public System.Data.Entity.DbSet<MVC_Advanced.Models.Employee> Employees { get; set; }
    }
}
