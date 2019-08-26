using AspNetMvcCodeFirst.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetMvcCodeFirst.Models
{
    public class CodeFirstContext : DbContext
    {
        static CodeFirstContext()
        {
            Database.SetInitializer<CodeFirstContext>(null);
        }

        public CodeFirstContext() : base("Name=CodeFirstConnection")
        {
        }

        public DbSet<Products> Products { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductsTable());
        }
    }
}