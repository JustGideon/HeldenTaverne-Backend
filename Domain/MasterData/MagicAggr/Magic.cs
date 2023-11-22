using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.MasterData;

/// <summary>
/// </summary>
public class Magic : MdEntity<Guid>
{
    /// <summary>
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// </summary>
    public string CastType { get; set; }

    /// <summary>
    ///     German: 'Probe'
    /// </summary>
    public Check Check { get; set; }

    /// <summary>
    ///     German: 'Wirkung'
    ///     Identifier/Short Description for use in the character sheet
    /// </summary>
    public string EffectIdentifier { get; set; }

    /// <summary>
    ///     German: 'Wirkung'
    /// </summary>
    public string? EffectDescription { get; set; }

    /// <summary>
    ///     German: 'Zauberdauer'
    ///     Alternativ RitualTime (Ritualdauer)
    /// </summary>
    public string CastTime { get; set; }

    /// <summary>
    ///     German: 'AsP-Kosten'
    /// </summary>
    public string AECost { get; set; }

    /// <summary>
    ///     German: 'Reichweite'
    /// </summary>
    public string Range { get; set; }

    /// <summary>
    ///     German: 'Wirkungsdauer'
    /// </summary>
    public string Duration { get; set; }

    /// <summary>
    ///     German: 'Zielkategorie'
    /// </summary>
    public string TargetCategory { get; set; }

    /// <summary>
    ///     German: 'Merkmal'
    /// </summary>
    public Property Property { get; set; }

    /// <summary>
    ///     German: 'Verbreitung'
    /// </summary>
    public Tradition Tradition { get; set; }

    /// <summary>
    ///     German: 'Steigerungsfaktor'
    /// </summary>
    public ImprovementFactor ImprovementFactor { get; set; }
}