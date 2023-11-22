using JSFC.HeldenTaverne.Domain.MasterData.SpecialAbility;
using JSFC.HeldenTaverne.Domain.UserData.Sheet.Hero;

namespace JSFC.HeldenTaverne.Domain.MasterData.Prerequisite;

/// <summary>
///     German: 'Voraussetzung'
/// </summary>
public class Prerequisite
{
    public List<Attribute> ShouldHaveAttributesEqualOrHigher { get; set; }
    public List<BaseSpecialAbility> ShouldHaveSpecialAbilities { get; set; }

    public List<Attribute> ShouldNotHaveAttributes { get; set; }
    public List<BaseSpecialAbility> ShouldNotHaveSpecialAbilities { get; set; }

    public void Validate(Hero hero)
    {
        hero.Attributes.Should().Contain(ShouldHaveAttributes);
        hero.SpecialAbilities.Should().Contain(ShouldHaveSpecialAbilities);
        hero.Attributes.Should().NotContain(ShouldNotHaveAttributes);
        hero.SpecialAbilities.Should().NotContain(ShouldNotHaveSpecialAbilities);
    }
}