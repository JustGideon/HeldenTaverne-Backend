using JSFC.HeldenTaverne.Application.UserService;
using JSFC.HeldenTaverne.Shared.Dto;
using JustGideon.DSA5CharacterManager.WebAPI.Interfaces;

namespace JustGideon.DSA5CharacterManager.WebAPI.Endpoints;

public class UserEndpoints : IEndpointModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/auth/");

        group.MapPost("",
            async Task<IResult> (UserCommandDto dto, IUserCommand userCommand)
                => await Task.FromResult<IResult>(TypedResults.Ok(userCommand.CreateAsync(dto))));
    }
}