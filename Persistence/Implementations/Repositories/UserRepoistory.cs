using JSFC.HeldenTaverne.Domain.UserData.Users;

namespace JSFC.HeldenTaverne.Persistence.Implementations.Repositories;

internal class UserRepoistory : GenericRepository<User, Guid>, IUserRepository
{
    public UserRepoistory(ApplicationDbContext dbContext)
        : base(dbContext)
    {
    }
}