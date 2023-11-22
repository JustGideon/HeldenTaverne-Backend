using System.Linq.Expressions;

namespace JSFC.HeldenTaverne.Domain.Common.Persistence;

/// <summary>
/// </summary>
/// <typeparam name="TEntity"></typeparam>
/// <typeparam name="TEntityId"></typeparam>
public interface IQueryRepository<TEntity, in TEntityId>
    where TEntity : Entity<TEntityId>
{
    /// <summary>
    /// </summary>
    /// <param name="entityId"></param>
    /// <returns></returns>
    public Task<TEntity?> GetByIdAsync(TEntityId entityId);

    /// <summary>
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    public Task<TEntity?> FindAsync(Expression<Func<TEntity, bool>> predicate);

    /// <summary>
    /// </summary>
    /// <returns></returns>
    public Task<IEnumerable<TEntity>> GetAllAsync();

    /// <summary>
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    public Task<IEnumerable<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate);

    /// <summary>
    /// </summary>
    /// <returns></returns>
    public IQueryable<TEntity> AsQueryable();
}