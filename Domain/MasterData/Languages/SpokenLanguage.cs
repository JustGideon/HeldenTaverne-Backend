using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.MasterData;

public class SpokenLanguage : MdEntity<Guid>
{
    public string Name { get; set; }
    public string Note { get; set; }
}