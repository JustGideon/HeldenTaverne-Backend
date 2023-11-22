using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.MasterData;

public class Publication : ExtendedEntity<Guid>
{
    public string Name { get; set; }
}