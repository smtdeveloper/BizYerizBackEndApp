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
            public Task<CreatedFoodPackagesResponse>? Handle(CreateFoodPackagesCommand request, CancellationToken cancellationToken)
            {
                CreatedFoodPackagesResponse createdFoodPackagesResponse = new CreatedFoodPackagesResponse { Id = new Guid(), Name = request.Name };
                return null;
            }

        }


    }

}
