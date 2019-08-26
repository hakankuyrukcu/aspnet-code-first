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

        /// <summary>
        /// In the constructor method, we specify the connection string to be based on.
        /// This connection string created on web.config file.
        /// </summary>
        public CodeFirstContext() : base("Name=CodeFirstConnection")
        {
        }

        // All tables declared for Seed Method in Migrations/Configuration.cs
        public DbSet<Products> Products { get; set; }

        /// <summary>
        /// All tables properties set for model creating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductsTable());
        }
    }
}