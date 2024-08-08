﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class FoodPackageConfiguration : IEntityTypeConfiguration<FoodPackage>
    {
        
        public void Configure(EntityTypeBuilder<FoodPackage> builder)
        {
            builder.ToTable("FoodPackage").HasKey(f => f.Id);
            builder.Property(f => f.Id).HasColumnName("Id").IsRequired();
            builder.Property(f => f.Name).HasColumnName("Name").IsRequired();
            builder.Property(f => f.CreatedDate).HasColumnName("CreatedDate").IsRequired();
            builder.Property(f => f.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(f => f.DeletedDate).HasColumnName("DeletedDate");

            builder.HasQueryFilter(f => !f.DeletedDate.HasValue);
        }



    }
}
