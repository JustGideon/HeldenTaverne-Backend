using JSFC.HeldenTaverne.Domain.Common.Persistence;

namespace JSFC.HeldenTaverne.Domain.MasterData;

public interface IScriptLanguageRepository : IQueryRepository<ScriptLanguage, Guid>
{
}