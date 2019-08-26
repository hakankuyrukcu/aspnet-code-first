using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;

namespace AspNetMvcCodeFirst.Models.Tables
{
    public class ProductsTable : EntityTypeConfiguration<Products>
    {
        public ProductsTable()
        {
            // Primary Key
            this.HasKey(t => t.ProductID);

            // Column Property
            // Set auto increment value on selected column
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            // Set required and max length property on selected column
            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            // Table And Table Columns
            this.ToTable("Products");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
        }
    }
}