using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    { 

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

            builder.Property(p => p.Title).IsRequired().HasMaxLength(250);
            builder.Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(p => p.Description).IsRequired().HasMaxLength(1000);
            builder.Property(p => p.Category).HasMaxLength(100);
            builder.Property(p => p.Image).HasMaxLength(500);

            builder.ComplexProperty(p => p.Rating, rating =>
            {
                rating.Property(r => r.Rate).HasColumnName("RatingRate").HasColumnType("decimal(18,2)");
                rating.Property(r => r.Count).HasColumnName("RatingCount").HasColumnType("int");
            });

        }

    }
}
