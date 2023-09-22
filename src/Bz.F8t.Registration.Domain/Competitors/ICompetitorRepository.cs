using Bz.F8t.Registration.Domain.Common;
using Bz.F8t.Registration.Domain.CompetitionIntegration;

namespace Bz.F8t.Registration.Domain.Competitors;

public interface ICompetitorRepository : IRepository<Competitor, CompetitorId>
{
    Task<IEnumerable<Competitor>> GetAllByCompetitionIdAsync(CompetitionId competitionId);

    Task<int> GetNumberOfRegisteredCompetitorsAsync(CompetitionId competitionId);
}
