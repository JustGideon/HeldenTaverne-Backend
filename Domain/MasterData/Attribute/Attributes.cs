using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.MasterData;

public class Atrributes : ValueObject
{
    public Atrributes()
    {
        MuAttribute = new Attribute("MU", "Mut");
        KlAttribute = new Attribute("KL", "Klugheit");
        InAttribute = new Attribute("IN", "Intuition");
        ChAttribute = new Attribute("CH", "Charisma");
        FfAttribute = new Attribute("FF", "Fingerfertigkeit");
        GeAttribute = new Attribute("GE", "Gewandtheit");
        KoAttribute = new Attribute("KO", "Konstitution");
        KkAttribute = new Attribute("KK", "Körperkraft");
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