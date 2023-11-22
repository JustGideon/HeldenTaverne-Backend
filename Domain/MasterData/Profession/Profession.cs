using JSFC.HeldenTaverne.Domain.MasterData.Vantages;

namespace JSFC.HeldenTaverne.Domain.MasterData.Profession;

/// <summary>
///     https://tde.ulisses-regelwiki.de/professions.html
/// </summary>
public class Profession
{
    public int ApValue { get; set; }
    public Prerequisite Prerequisites { get; set; }
    public SpecialAbility SpecialAbilities { get; set; }
    public CombatTechnique CombatTechniques { get; set; }
    public Skills Type { get; set; }
    public Spells Type1 { get; set; }

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