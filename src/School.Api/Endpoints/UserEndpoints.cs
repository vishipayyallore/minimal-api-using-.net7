﻿using Microsoft.AspNetCore.Mvc;
using School.Data.Dtos;
using static School.ApplicationCore.Common.Constants;

namespace School.API.Endpoints;

public static class UserEndpoints
{

    public static void MapUserEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup(UsersRoutes.Prefix).WithTags(nameof(PersonDto));

        _ = group.MapGet(UsersRoutes.ActionById, ([FromRoute] string id, [FromQuery] string name) =>
        {
            return ApiResponseDto<dynamic>.Create(new
            {
                UserId = id,
                Message = $"Hello {name}, Welcome to Minimal API World !!"
            });
        }).AllowAnonymous()
          .WithName("GetUserById")
          .Produces<ApiResponseDto<dynamic>>(StatusCodes.Status200OK)
          .ProducesProblem(StatusCodes.Status500InternalServerError)
          .WithOpenApi();

        _ = group.MapPost(UsersRoutes.Root, ([FromBody] PersonDto person) =>
        {
            return ApiResponseDto<dynamic>.Create(new
            {
                UserId = person.Id,
                UserName = person.Name,
            });
        }).WithName("AddNewUser")
          .Produces<ApiResponseDto<dynamic>>(StatusCodes.Status200OK)
          .ProducesProblem(StatusCodes.Status500InternalServerError)
          .WithOpenApi();

    }


}
