using JSFC.HeldenTaverne.Domain.Common;
using JSFC.HeldenTaverne.Domain.MasterData.Attribute;
using Attribute = JSFC.HeldenTaverne.Domain.MasterData.Attribute.Attribute;

namespace JSFC.HeldenTaverne.Domain.UserData.Sheet.Hero.NestedObjects;

public class HeroAtrributes : ValueObject
{
    public HeroAtrributes(IAttributeRepository attributeRepository)
    {
        MuAttribute = attributeRepository.GetAttributeByIdentifierAndLanguage("MU", "DE");
        KlAttribute = attributeRepository.GetAttributeByIdentifierAndLanguage("KL", "DE");
        InAttribute = attributeRepository.GetAttributeByIdentifierAndLanguage("IN", "DE");
        ChAttribute = attributeRepository.GetAttributeByIdentifierAndLanguage("CH", "DE");
        FfAttribute = attributeRepository.GetAttributeByIdentifierAndLanguage("FF", "DE");
        GeAttribute = attributeRepository.GetAttributeByIdentifierAndLanguage("GE", "DE");
        KoAttribute = attributeRepository.GetAttributeByIdentifierAndLanguage("KO", "DE");
        KkAttribute = attributeRepository.GetAttributeByIdentifierAndLanguage("KK", "DE");
    }

    public Attribute MuAttribute { get; set; }
    public Attribute KlAttribute { get; set; }
    public Attribute InAttribute { get; set; }
    public Attribute ChAttribute { get; set; }
    public Attribute FfAttribute { get; set; }
    public Attribute GeAttribute { get; set; }
    public Attribute KoAttribute { get; set; }
    public Attribute KkAttribute { get; set; }

    protected override IEnumerable<object?> GetEqualityComponents()
    {
        throw new NotImplementedException();
    }
}