using JSFC.HeldenTaverne.Domain.Common.Persistence;

namespace JSFC.HeldenTaverne.Domain.MasterData.CombatTechnique.CombatTechnique;

public interface ICombatTechniqueRepository : IQueryRepository<CombatTechnique, Guid>
{
}