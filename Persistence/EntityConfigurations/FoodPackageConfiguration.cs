using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class FoodPackageConfiguration : IEntityTypeConfiguration<FoodPackage>
    {
        
        public void Configure(EntityTypeBuilder<FoodPackage> builder)
        {
            builder.ToTable("FoodPackage");

        }


    }
}
