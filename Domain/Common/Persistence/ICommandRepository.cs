namespace JSFC.HeldenTaverne.Domain.Common.Persistence;

/// <summary>
/// </summary>
/// <typeparam name="TEntity"></typeparam>
/// <typeparam name="TEntityId"></typeparam>
public interface ICommandRepository<in TEntity, in TEntityId>
    where TEntity : Entity<TEntityId>
{
    /// <summary>
    /// </summary>
    /// <param name="entity"></param>
    public void Add(TEntity entity);

    /// <summary>
    /// </summary>
    /// <param name="entities"></param>
    public void AddRange(IEnumerable<TEntity> entities);

    /// <summary>
    /// </summary>
    /// <param name="entity"></param>
    public void Update(TEntity entity);

    /// <summary>
    /// </summary>
    /// <param name="entities"></param>
    public void UpdateRange(IEnumerable<TEntity> entities);

    /// <summary>
    /// </summary>
    /// <param name="entity"></param>
    public void Remove(TEntity entity);

    /// <summary>
    /// </summary>
    /// <param name="entities"></param>
    public void RemoveRange(IEnumerable<TEntity> entities);
}