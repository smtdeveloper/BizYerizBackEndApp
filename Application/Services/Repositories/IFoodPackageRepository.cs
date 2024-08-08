using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IFoodPackageRepository : IAsyncRepository<FoodPackage, Guid>, IRepository<FoodPackage, Guid>
{



}

