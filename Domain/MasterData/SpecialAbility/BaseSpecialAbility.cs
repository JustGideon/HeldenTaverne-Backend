using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.MasterData.SpecialAbility;

/// <summary>
///     German: 'Basis-Sonderfertigkeit'
///     Base class for all special abilities.
/// </summary>
public abstract class BaseSpecialAbility : ExtendedEntity<Guid>
{
    /// <summary>
    ///     German: 'Regeltext'
    /// </summary>
    public string Rule { get; set; }

    /// <summary>
    ///     German: 'Voraussetzung'
    /// </summary>
    public Prerequisite Prerequisite { get; set; }

    /// <summary>
    ///     German: 'AP-Wert'
    /// </summary>
    public int ApValue { get; set; }
}