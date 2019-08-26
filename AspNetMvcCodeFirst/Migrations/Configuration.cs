namespace AspNetMvcCodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AspNetMvcCodeFirst.Models.CodeFirstContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AspNetMvcCodeFirst.Models.CodeFirstContext context)
        {
            // Specific data is added to the table each time the database is updated
            // Because the product id is the primary key, it will not add if the data exists in the table.

            context.Products.AddOrUpdate(
                new Models.Products { ProductID = 1, ProductName = "Book" },
                new Models.Products { ProductID = 2, ProductName = "Car" }
                );
        }
    }
}
