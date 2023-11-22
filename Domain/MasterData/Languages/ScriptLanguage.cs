using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.MasterData;

public class ScriptLanguage : MdEntity<Guid>
{
    public string Name { get; set; }
    public string Note { get; set; }
}