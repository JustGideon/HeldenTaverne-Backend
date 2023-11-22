using JSFC.HeldenTaverne.Domain.Common;
using JSFC.HeldenTaverne.Domain.MasterData.Vantages;

namespace JSFC.HeldenTaverne.Domain.MasterData.Race;

/// <summary>
///     German: 'Spezies'
///     https://dsa.ulisses-regelwiki.de/spezies.html
///     https://tde.ulisses-regelwiki.de/races.html
/// </summary>
public class Race : ExtendedEntity<Guid>
{
    /// <summary>
    ///     German: 'AP-Wert'
    /// </summary>
    public int ApValue { get; set; }

    /// <summary>
    ///     German: 'Lebenspunkte-Grundwert'
    /// </summary>
    public int LifePointBaseValue { get; set; }

    /// <summary>
    ///     German: 'Seelenkraft-Grundwert'
    /// </summary>
    public int SpiritBaseValue { get; set; }

    /// <summary>
    ///     German: 'Zähigkeit-Grundwert'
    /// </summary>
    public int ToughnessBaseValue { get; set; }

    /// <summary>
    ///     German: 'Geschwindigkeit-Grundwert'
    /// </summary>
    public int MovementBaseValue { get; set; }

    /// <summary>
    ///     German: 'Eigenschaftsänderungen'
    /// </summary>
    public List<System.Attribute> AttributeAdjustments { get; set; }

    /// <summary>
    ///     German: 'Übliche Kulturen'
    /// </summary>
    public List<Culture> CommonCultures { get; set; }

    /// <summary>
    ///     German: 'Automatische Vorteile'
    /// </summary>
    public List<Advantage> AutomaticAdvantages { get; set; }

    /// <summary>
    ///     German: 'Automatischee Nachteile'
    /// </summary>
    public List<Disadvantage> AutomaticDisadvantages { get; set; }

    /// <summary>
    ///     German: 'Dringend empfohlene Vorteile'
    /// </summary>
    public List<Advantage> StronglyRecommendedAdvantages { get; set; }

    /// <summary>
    ///     German: 'Dringend empfohlene Nachteile'
    /// </summary>
    public List<Disadvantage> StronglyRecommendedDisadvantages { get; set; }

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
    ///     German: 'Anmerkung'
    /// </summary>
    public string Note { get; set; }

    /// <summary>
    ///     German: 'Publikation'
    /// </summary>
    public Dictionary<Publication, string> Publication { get; set; }
}