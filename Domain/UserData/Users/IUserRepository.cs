using JSFC.HeldenTaverne.Domain.Common.Persistence;

namespace JSFC.HeldenTaverne.Domain.UserData.Users;

public interface IUserRepository : ICommandRepository<User, Guid>, IQueryRepository<User, Guid>
{
}