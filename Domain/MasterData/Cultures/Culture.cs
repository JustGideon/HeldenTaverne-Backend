using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.MasterData;

/// <summary>
///     https://tde.ulisses-regelwiki.de/cultures.html
/// </summary>
public class Culture : MdEntity<Guid>
{
    /// <summary>
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// </summary>
    public SpokenLanguage SpokenLanguage { get; set; }

    /// <summary>
    /// </summary>
    public ScriptLanguage ScriptLanguage { get; set; }

    /// <summary>
    /// </summary>
    public string AreaKnowledge { get; set; }

    /// <summary>
    /// </summary>
    public string SocialStatus { get; set; }

    /// <summary>
    /// </summary>
    public List<Profession> CommonProfessions { get; set; }

    /// <summary>
    ///     German: 'Typische Vorteile'
    /// </summary>
    public List<Advantage> CommonAdvantages { get; set; }

    /// <summary>
    ///     German: 'Typische Nachteile'
    /// </summary>
    public List<Disadvantage> CommonDisadvantages { get; set; }

    /// <summary>
    ///     German: 'Untypische Vorteile'
    /// </summary>
    public List<Advantage> UncommonAdvantages { get; set; }

    /// <summary>
    ///     German: 'Untypische Nachteile'
    /// </summary>
    public List<Disadvantage> UncommonDisadvantages { get; set; }

    /// <summary>
    /// </summary>
    public List<Skill> CommonSkills { get; set; }

    /// <summary>
    /// </summary>
    public List<Skill> UncommonSkills { get; set; }

    /// <summary>
    /// </summary>
    public string CommonNames { get; set; }

    /// <summary>
    /// </summary>
    public CulturePack CulturePack { get; set; }
}