namespace JSFC.HeldenTaverne.Domain.Common.Persistence;

/// <summary>
/// </summary>
public interface IUnitOfWork
{
    /// <summary>
    /// </summary>
    /// <returns></returns>
    Task<int> SaveChangesAsync();
}