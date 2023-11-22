using JSFC.HeldenTaverne.Domain.Common.Persistence;

namespace JSFC.HeldenTaverne.Domain.MasterData.Attribute;

/// <summary>
/// </summary>
public interface IAttributeRepository : IQueryRepository<Attribute, Guid>
{
    /// <summary>
    /// </summary>
    /// <param name="identifier"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    Attribute GetAttributeByIdentifierAndLanguage(string identifier, string language);
}