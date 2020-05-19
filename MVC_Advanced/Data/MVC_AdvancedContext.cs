using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //By default MVC has cascade delete enabled, which allows me to delete a field related to any other field, and that in turn will also delete all other field related to the one deleted; This code removes this convention to not allow me to delete fields that are linked to other fields
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public System.Data.Entity.DbSet<MVC_Advanced.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<MVC_Advanced.Models.DocumentType> DocumentTypes { get; set; }

        public System.Data.Entity.DbSet<MVC_Advanced.Models.Employee> Employees { get; set; }
    }
}
