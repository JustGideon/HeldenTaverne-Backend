namespace JSFC.HeldenTaverne.Domain.MasterData;

/// <summary>
///     https://tde.ulisses-regelwiki.de/professions.html
/// </summary>
public class Profession
{
    /// <summary>
    /// </summary>
    public int ApValue { get; set; }

    /// <summary>
    /// </summary>
    public string Prerequisites { get; set; }

    /// <summary>
    /// </summary>
    public SpecialAbility SpecialAbilities { get; set; }

    /// <summary>
    /// </summary>
    public CombatTechnique CombatTechniques { get; set; }

    /// <summary>
    /// </summary>
    public Skill Skill { get; set; }

    /// <summary>
    /// </summary>
    public Magic Magic { get; set; }

    /// <summary>
    ///     German: 'Typische Vorteile'
    /// </summary>
    public List<Advantage> SuggestedAdvantages { get; set; }

    /// <summary>
    ///     German: 'Typische Nachteile'
    /// </summary>
    public List<Disadvantage> SuggestedDisadvantages { get; set; }

    /// <summary>
    ///     German: 'Untypische Vorteile'
    /// </summary>
    public List<Advantage> UnsuitableAdvantages { get; set; }

    /// <summary>
    ///     German: 'Untypische Nachteile'
    /// </summary>
    public List<Disadvantage> UnsuitableDisadvantages { get; set; }
}