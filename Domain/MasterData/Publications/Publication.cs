using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.MasterData;

public class Publication : Entity<Guid>
{
    public string Name { get; set; }
}