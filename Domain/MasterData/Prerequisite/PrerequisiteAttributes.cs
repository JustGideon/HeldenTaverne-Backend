using JSFC.HeldenTaverne.Domain.Common;
using JSFC.HeldenTaverne.Domain.MasterData.Attribute;

namespace JSFC.HeldenTaverne.Domain.MasterData.Prerequisite.Prerequisite;

public class PrerequisiteAtrributes : ValueObject
{
    public PrerequisiteAtrributes(IAttributeRepository attributeRepository)
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
    public int MuAttributeValue { get; set; }
    public Attribute KlAttribute { get; set; }
    public int KlAttributeValue { get; set; }
    public Attribute InAttribute { get; set; }
    public int InAttributeValue { get; set; }
    public Attribute ChAttribute { get; set; }
    public int ChAttributeValue { get; set; }
    public Attribute FfAttribute { get; set; }
    public int FfAttributeValue { get; set; }
    public Attribute GeAttribute { get; set; }
    public int GeAttributeValue { get; set; }
    public Attribute KoAttribute { get; set; }
    public int KoAttributeValue { get; set; }
    public Attribute KkAttribute { get; set; }
    public int KkAttributeValue { get; set; }

    protected override IEnumerable<object?> GetEqualityComponents()
    {
        throw new NotImplementedException();
    }
}