using Bz.F8t.Registration.Application.Common;

namespace Bz.F8t.Registration.Application.Competitors;

public interface ICompetitorService : IApplicationService
{
    Task<IEnumerable<CompetitorDto>> GetCompetitorsAsync(Guid competitionId);
}
