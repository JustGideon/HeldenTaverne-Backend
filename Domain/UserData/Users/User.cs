using JSFC.HeldenTaverne.Domain.Common;

namespace JSFC.HeldenTaverne.Domain.UserData.Users;

//TODO
public class User : Entity<Guid>
{
    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public string Username { get; set; }
    public string Password { get; set; }
}