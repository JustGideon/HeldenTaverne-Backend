using JSFC.HeldenTaverne.Domain.MasterData.Culture;
using JSFC.HeldenTaverne.Domain.MasterData.Profession;
using JSFC.HeldenTaverne.Domain.MasterData.Race;
using JSFC.HeldenTaverne.Domain.MasterData.Vantages;
using JSFC.HeldenTaverne.Domain.UserData.Sheet.Hero.DerivedCharacteristics;
using JSFC.HeldenTaverne.Domain.UserData.Sheet.Hero.NestedObjects;

namespace JSFC.HeldenTaverne.Domain.UserData.Sheet.Hero;

/// <summary>
/// </summary>
public class Hero
{
    /// <summary>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="sex"></param>
    public Hero(string name, Sex sex)
    {
        Name = name;
        Sex = sex;
    }

    public LifePoints Type { get; set; } = new();

    /// <summary>
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// </summary>
    public Sex Sex { get; set; }

    /// <summary>
    /// </summary>
    public Race? Species { get; set; }

    /// <summary>
    /// </summary>
    public Culture? Culture { get; set; }

    /// <summary>
    /// </summary>
    public Profession? Profession { get; set; }

    /// <summary>
    /// </summary>
    public int Birthday { get; set; }

    /// <summary>
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// </summary>
    public int Weight { get; set; }

    /// <summary>
    /// </summary>
    public EyeColor EyeColor { get; set; }

    /// <summary>
    /// </summary>
    public string Family { get; set; }

    /// <summary>
    /// </summary>
    public Socialstatus Socialstatus { get; set; }

    /// <summary>
    /// </summary>
    public Homeplace Homeplace { get; set; }

    /// <summary>
    /// </summary>
    public string HairColor { get; set; }

    /// <summary>
    /// </summary>
    public string SkinColor { get; set; }

    public List<HeroAttribute> Attribute { get; set; }

    /// <summary>
    /// </summary>
    public List<Advantage> Advantages { get; set; } = new();

    /// <summary>
    /// </summary>
    public List<Disadvantage> Disadvantages { get; set; } = new();

    /// <summary>
    /// </summary>
    public HeroAttributes Attributes { get; set; } = new();

    /// <summary>
    /// </summary>
    /// <returns></returns>
    public int Age?{
        get;
        set;
    }
}