using JSFC.HeldenTaverne.Domain.Common;
using JSFC.HeldenTaverne.Domain.MasterData;

namespace JSFC.HeldenTaverne.Domain.UserData.Sheet.Hero;

public class HeroCombatTechniques : Entity<Guid>
{
    public Hero Hero { get; set; }
    public CombatTechnique CombatTechnique { get; set; }
    public int Combat { get; set; }
}