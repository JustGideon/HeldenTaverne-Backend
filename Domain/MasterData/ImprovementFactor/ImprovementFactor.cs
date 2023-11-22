using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.MasterData.ImprovementFactor;

/// <summary>
///     German: 'Steigerungsfaktor'
///     'Kostentabelle'     : https://dsa.ulisses-regelwiki.de/Heldenerschaffung.html
///     'Improvement Chart' : https://tde.ulisses-regelwiki.de/hero-creation.html
/// </summary>
public class ImprovementFactor : Entity<char>
{
    public int CostTo0 { get; init; }
    public int CostTo12 { get; init; }
    public int CostTo13 { get; init; }
    public int CostTo14 { get; init; }
    public int CostTo15 { get; init; }
    public int CostTo16 { get; init; }
    public int CostTo17 { get; init; }
    public int CostTo18 { get; init; }
    public int CostTo19 { get; init; }
    public int CostTo20 { get; init; }
    public int CostTo21 { get; init; }
    public int CostTo22 { get; init; }
    public int CostTo23 { get; init; }
    public int CostTo24 { get; init; }
    public int CostTo25 { get; init; }
}