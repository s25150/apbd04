using Cwiczenia04.btos;
using Cwiczenia04.Controllers;
namespace Cwiczenia04.Configurations;


public static class Configuration
{
    public static IEndpointRouteBuilder RegisterAnimalsUserEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapPost("/WarehouseProduct",
            (WarehouseProductBto whproduct) => 
                TypedResults.Created("", whc.addWarehouse(whproduct)));
        return endpoints;
    }
}