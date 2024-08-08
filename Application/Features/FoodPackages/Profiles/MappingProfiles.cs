using Application.Features.FoodPackages.Commands.Create;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.FoodPackages.Profiles
{
    public class MappingProfiles : Profile
    {
    
        public MappingProfiles()
        {
            CreateMap<FoodPackage, CreateFoodPackagesCommand>().ReverseMap();
        
            CreateMap<FoodPackage, CreatedFoodPackagesResponse>().ReverseMap();
        

        }
      

    }
}
