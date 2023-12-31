﻿using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Data.Entities;
using eShopSolution.Data.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(c => c.Id);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}
