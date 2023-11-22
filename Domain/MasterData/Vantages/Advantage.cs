using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.MasterData;

/// <summary>
///     https://dsa.ulisses-regelwiki.de/vor-und-nachteile.html
///     https://tde.ulisses-regelwiki.de/advantages-and-disadvantages.html
/// </summary>
public class Advantage : Entity<Guid>
{
    /// <summary>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="rule"></param>
    /// <param name="prerequisities"></param>
    /// <param name="apValue"></param>
    public Advantage(string name, string rule, string prerequisities, int apValue)
    {
        Name = name;
        Rule = rule;
        Prerequisities = prerequisities;
        ApValue = apValue;
    }

    /// <summary>
    ///     German: 'Name'
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     German: 'Regel'
    /// </summary>
    public string Rule { get; set; }

    /// <summary>
    ///     German: 'Reichweite'
    /// </summary>
    public string Range { get; set; }

    /// <summary>
    ///     German: 'Aktionen'
    /// </summary>
    public string Actions { get; set; }

    /// <summary>
    ///     German: 'Voraussetzungen'
    /// </summary>
    public string Prerequisities { get; set; }

    /// <summary>
    ///     German: 'AP-Wert'
    /// </summary>
    public int ApValue { get; set; }

    /// <summary>
    /// </summary>
    /// <returns></returns>
    public Advantage[] HasData()
    {
        return new[]
        {
            // https://dsa.ulisses-regelwiki.de/vorteil.html?vorteil=Adel+I-III
            new Advantage(
                "Adel I-III",
                "Der Held ist angesehen, genießt die Privilegien des Adels und kann vom Meister Erleichterungen zugesprochen bekommen, wenn er gegenüber Rangniedrigeren agiert.",
                "Kultur muss über einen passenden Adel verfügen.",
                5
            ),
            // https://dsa.ulisses-regelwiki.de/vorteil.html?vorteil=Affinit%C3%A4t+zu+D%C3%A4monen
            new Advantage(
                "Affinität zu Dämonen",
                "Der Held kann Dämonen leichter zu einem Dienst überreden, wenn er sie selbst beschworen hat. Der Dämon erfüllt ihm einen zusätzlichen Dienst auch über das Maximum von 6 Diensten hinaus.",
                "Vorteil Zauberer, Kein Vorteil Affinität zu Elementaren",
                10
            )
        };
    }
}