using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.MasterData;

/// <summary>
///     German: 'Probe'
/// </summary>
public class Check : ValueObject
{
    /// <summary>
    /// </summary>
    /// <param name="attribute1"></param>
    /// <param name="attribute2"></param>
    /// <param name="attribute3"></param>
    /// <param name="ruleExtensionDescription"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public Check(Attribute attribute1, Attribute attribute2, Attribute attribute3,
        string? ruleExtensionDescription = null)
    {
        Attribute1 = attribute1 ?? throw new ArgumentNullException(nameof(attribute1));
        Attribute2 = attribute2 ?? throw new ArgumentNullException(nameof(attribute2));
        Attribute3 = attribute3 ?? throw new ArgumentNullException(nameof(attribute3));
        RuleExtensionDescription = ruleExtensionDescription;
    }

    /// <summary>
    /// </summary>
    public Attribute Attribute1 { get; }

    /// <summary>
    /// </summary>
    public Attribute Attribute2 { get; }

    /// <summary>
    /// </summary>
    public Attribute Attribute3 { get; }

    /// <summary>
    /// </summary>
    public string? RuleExtensionDescription { get; }

    /// <summary>
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        var result = $"{Attribute1.Identifier}/{Attribute2.Identifier}/{Attribute3.Identifier}";
        if (RuleExtensionDescription != null)
            result += $" \n{RuleExtensionDescription}";
        return result;
    }

    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Attribute1;
        yield return Attribute2;
        yield return Attribute3;
        yield return RuleExtensionDescription;
    }
}