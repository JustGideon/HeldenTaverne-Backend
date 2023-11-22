using JSFC.HeldenTaverne.Domain.Common.Persistence;

namespace JSFC.HeldenTaverne.Domain.MasterData;

public interface ISkillRepository : IQueryRepository<Skill, Guid>
{
}