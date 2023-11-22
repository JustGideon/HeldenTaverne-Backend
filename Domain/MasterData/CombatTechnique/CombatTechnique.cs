using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.MasterData;

/// <summary>
///     German: 'Kampftechnik'
///     https://dsa.ulisses-regelwiki.de/kampftechnikauswahl.html
///     https://tde.ulisses-regelwiki.de/combat-techniques.html
/// </summary>
public class CombatTechnique : Entity<Guid>
{
    /// <summary>
    ///     German: 'Kampftechnikkategorie'
    /// </summary>
    public CombatTechniqueCategory CombatTechniqueCategory { get; set; }

    /// <summary>
    ///     German: 'Name'
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     German: 'Besonderheiten'
    /// </summary>
    public string Special { get; set; }

    /// <summary>
    ///     German: 'Leiteigenschaft'
    /// </summary>
    public string PrimaryAttribute { get; set; }

    /// <summary>
    ///     German: 'Steigerungsfaktor'
    /// </summary>
    public ImprovementFactor ImprovementCost { get; set; }
}