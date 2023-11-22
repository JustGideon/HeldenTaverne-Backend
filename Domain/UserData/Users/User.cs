using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.UserData.Users;

//TODO
public class User : Entity<Guid>
{
    public string Username { get; set; }
    public string Password { get; set; }
}