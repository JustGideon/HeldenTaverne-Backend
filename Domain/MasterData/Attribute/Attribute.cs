using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.MasterData;

/// <summary>
/// </summary>
public class Attribute : ValueObject
{
    /// <summary>
    /// </summary>
    /// <param name="identifier"></param>
    /// <param name="name"></param>
    /// <param name="systemLanguage"></param>
    public Attribute(string identifier, string name)
    {
        Identifier = identifier;
        Name = name;
    }

    /// <summary>
    /// </summary>
    public string Identifier { get; }

    /// <summary>
    /// </summary>
    public string Name { get; }

    public int Value { get; set; } = 8;

    protected override IEnumerable<object?> GetEqualityComponents()
    {
        throw new NotImplementedException();
    }
}