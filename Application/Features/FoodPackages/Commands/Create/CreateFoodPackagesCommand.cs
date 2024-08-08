using Application.Services.Repositories;
using AutoMapper;
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
            private readonly IMapper _mapper;

            public CreateFoodPackagesCommandHandler(IFoodPackageRepository foodPackageRepository, IMapper mapper)
            {
                _foodPackageRepository = foodPackageRepository;
                _mapper = mapper;
            }

            public async Task<CreatedFoodPackagesResponse>? Handle(CreateFoodPackagesCommand request, CancellationToken cancellationToken)
            {
                FoodPackage foodPackages = _mapper.Map<FoodPackage>(request);
                foodPackages.Id = Guid.NewGuid();
                
                var result = await _foodPackageRepository.AddAsync(foodPackages);

                CreatedFoodPackagesResponse createdFoodPackagesResponse = _mapper.Map<CreatedFoodPackagesResponse>(result);

                return createdFoodPackagesResponse;
            }

        }


    }

}
