using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.MasterData;

public class PublicationReferral : Entity<Guid>
{
    public Publication Publication { get; set; }
    public string? Referral { get; set; }
}