using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class FoodPackageRepository : EfRepositoryBase<FoodPackage, Guid, BaseDbContext>, IFoodPackageRepository
    {
        public FoodPackageRepository(BaseDbContext context) : base(context)
        {
        }


    }
}
