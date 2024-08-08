using Application.Features.FoodPackages.Commands.Create;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodPackagesController : BaseController
    {


        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateFoodPackagesCommand createFoodPackagesCommand) 
        {
           CreatedFoodPackagesResponse response = await Mediator.Send(createFoodPackagesCommand);
            return Ok(response);
        }

    }
}
