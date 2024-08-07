using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IFoodPackagesRepository : IAsyncRepository<FoodPackage, Guid>, IRepository<FoodPackage, Guid>
{



}

