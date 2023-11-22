using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.MasterData;

/// <summary>
///     German: 'Merkmale'
///     2023-10-25: https://dsa.ulisses-regelwiki.de/Merk.html
///     2023-10-25: https://tde.ulisses-regelwiki.de/properties.html
/// </summary>
public class Property : Entity<Guid>
{
    /// <summary>
    ///     German: 'Name'
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     German: 'Probe'
    /// </summary>
    public Check Check { get; set; }
}