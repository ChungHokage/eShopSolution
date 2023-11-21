﻿using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Price).IsRequired();
            builder.Property(x=>x.Stock).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);
            builder.Property(x=>x.OriginalPrice).IsRequired().HasDefaultValue(0);
        }
    }
}
