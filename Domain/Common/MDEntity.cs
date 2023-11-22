using JSFC.HeldenTaverne.Domain.MasterData;

namespace JSFC.HeldenTaverne.Domain.Common;

public abstract class MdEntity<TEntityId> : Entity<TEntityId>
{
    /// <summary>
    /// </summary>
    public List<PublicationReferral> Publications { get; set; } = new();
}