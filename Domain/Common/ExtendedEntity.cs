using JSFC.HeldenTaverne.Domain.MasterData;

namespace JSFC.HeldenTaverne.Domain.Common;

public abstract class ExtendedEntity<TEntityId> : Entity<TEntityId>
{
    /// <summary>
    /// </summary>
    public SystemLanguage? SystemLanguage { get; set; }

    /// <summary>
    /// </summary>
    public Publication? Publication { get; set; }

    /// <summary>
    /// </summary>
    public string? PublicationReferral { get; set; }
}