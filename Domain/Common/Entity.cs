namespace JSFC.HeldenTaverne.Domain.Common;

/// <summary>
/// </summary>
/// <typeparam name="TEntityId"></typeparam>
public abstract class Entity<TEntityId>
{
    /// <summary>
    /// </summary>
    public TEntityId Id { get; init; }
}