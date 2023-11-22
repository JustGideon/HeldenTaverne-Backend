using JSFC.HeldenTaverne.Application.User;
using JSFC.HeldenTaverne.Domain.Common.Persistence;
using JSFC.HeldenTaverne.Domain.UserData.Users;
using JSFC.HeldenTaverne.Shared.Dto;

namespace JSFC.HeldenTaverne.Application.UserService;

public class UserCommand : IUserCommand
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserRepository _userRepository;

    public UserCommand(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<int> CreateAsync(UserCommandDto dto)
    {
        var newUser = new Domain.UserData.Users.User(dto.Username, dto.Password);

        _userRepository.Add(newUser);

        var task = await _unitOfWork.SaveChangesAsync();

        return task;
    }
}