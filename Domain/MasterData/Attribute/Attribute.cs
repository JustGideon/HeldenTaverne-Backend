using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.MasterData.Attribute;

/// <summary>
/// </summary>
public class Attribute : ExtendedEntity<Guid>
{
    /// <summary>
    /// </summary>
    /// <param name="identifier"></param>
    /// <param name="name"></param>
    /// <param name="systemLanguage"></param>
    public Attribute(string identifier, string name, SystemLanguage systemLanguage)
    {
        Identifier = identifier;
        Name = name;

        SystemLanguage = systemLanguage;
    }

    /// <summary>
    /// </summary>
    public string Identifier { get; }

    /// <summary>
    /// </summary>
    public string Name { get; }
}