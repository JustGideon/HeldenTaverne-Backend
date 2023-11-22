using JSFC.HeldenTaverne.Domain.Common.Persistence;

namespace JSFC.HeldenTaverne.Persistence.Implementations;

internal class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext;

    public UnitOfWork(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<int> SaveChangesAsync()
    {
        return _dbContext.SaveChangesAsync();
    }
}