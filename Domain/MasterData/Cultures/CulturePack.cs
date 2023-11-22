using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.MasterData;

public class CulturePack : MdEntity<Guid>
{
    public Dictionary<Profession, int> Professions { get; set; }
    //TODO
}