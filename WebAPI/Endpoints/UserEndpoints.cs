using JSFC.HeldenTaverne.Application.UserService;
using JSFC.HeldenTaverne.Shared.Dto;
using JustGideon.DSA5CharacterManager.WebAPI.Interfaces;

namespace JustGideon.DSA5CharacterManager.WebAPI.Endpoints;

public class UserEndpoints : IEndpointModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/users/");

        group.MapPost("",
            async Task<IResult> (UserCommandCreateDto dto, IUserCommand userCommand)
                => await Task.FromResult<IResult>(TypedResults.Ok(userCommand.CreateAsync(dto))));

        group.MapPost("",
            async Task<IResult> (UserCommandCreateDto dto, IUserCommand userCommand)
                => await Task.FromResult<IResult>(TypedResults.Ok(userCommand.CreateAsync(dto))));
    }
}