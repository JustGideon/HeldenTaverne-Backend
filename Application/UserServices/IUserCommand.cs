using JSFC.HeldenTaverne.Shared.Dto;

namespace JSFC.HeldenTaverne.Application.UserService;

public interface IUserCommand
{
    Task<int> CreateAsync(UserCommandDto dto);
}