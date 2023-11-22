namespace JSFC.HeldenTaverne.Domain.Common;

public class SystemLanguage : Entity<Guid>
{
    public SystemLanguage(string identifier, string description)
    {
        Identifier = identifier;
        Description = description;
    }

    public string Identifier { get; set; }
    public string Description { get; set; }
}