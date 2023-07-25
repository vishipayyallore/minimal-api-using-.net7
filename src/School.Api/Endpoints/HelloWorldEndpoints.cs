using School.Data.Dtos;
using static School.ApplicationCore.Common.Constants;

namespace School.API.Endpoints;

public static class HelloWorldEndpoints
{

    public static void MapHelloWorldEndpoints(this IEndpointRouteBuilder routes)
    {
        _ = routes
            .MapGet(HelloWorldRoutes.Root, () => "Minimal API. Please visit /swagger for full documentation")
            .WithTags("Hello World")
            .WithName("Get HelloWorldString");

        _ = routes.MapGet(HelloWorldRoutes.HelloWorld, () =>
        {
            return ApiResponseDto<string>.Create("Hello Minimal API World from /hw !!");
        }).WithTags("Hello World")
          .WithName("Get ApiResponseDto String");

        _ = routes.MapGet(HelloWorldRoutes.Api, DefaultResponseBusiness.SendDefaultApiEndpointOutput)
            .WithTags("Hello World")
            .WithName("Get Api");

        _ = routes.MapGet(HelloWorldRoutes.ApiV1, () => DefaultResponseBusiness.SendDefaultApiEndpointV1Output())
            .WithTags("Hello World")
            .WithName("Get Api V1");
    }

}
