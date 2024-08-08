using Application.Services.Repositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FoodPackages.Commands.Create
{
    public class CreateFoodPackagesCommand : IRequest<CreatedFoodPackagesResponse>
    {

        public string Name { get; set; }


        public class CreateFoodPackagesCommandHandler : IRequestHandler<CreateFoodPackagesCommand, CreatedFoodPackagesResponse>
        {

            private readonly IFoodPackageRepository _foodPackageRepository;
            public CreateFoodPackagesCommandHandler(IFoodPackageRepository foodPackageRepository)
            {
                _foodPackageRepository = foodPackageRepository;
            }

            public async Task<CreatedFoodPackagesResponse>? Handle(CreateFoodPackagesCommand request, CancellationToken cancellationToken)
            {
                FoodPackage foodPackages = new();
                foodPackages.Id = Guid.NewGuid();
                foodPackages.Name = request.Name;

                var result = await _foodPackageRepository.AddAsync(foodPackages);

                CreateFoodPackagesCommand createFoodPackagesCommand = new();

                CreatedFoodPackagesResponse createdFoodPackagesResponse = new CreatedFoodPackagesResponse 
                { Id = result.Id, Name = result.Name };

                return createdFoodPackagesResponse;
            }

        }


    }

}
