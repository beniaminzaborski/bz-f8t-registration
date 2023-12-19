using Bz.F8t.Registration.Domain.Common;
using Bz.F8t.Registration.Domain.CompetitionIntegration;
using Bz.F8t.Registration.Domain.Competitors;
using Bz.F8t.Registration.Infrastructure.Persistence.Common;
using Microsoft.EntityFrameworkCore;

namespace Bz.F8t.Registration.Infrastructure.Persistence.Repositories;

internal class CompetitorRepository(ApplicationDbContext dbContext) : Repository<Competitor, CompetitorId, ApplicationDbContext>(dbContext), ICompetitorRepository
{
    public async Task<IEnumerable<Competitor>> GetAllByCompetitionIdAsync(CompetitionId competitionId)
    {
        return await _dbContext.Set<Competitor>()
            .Where(c => c.CompetitionId.Equals(competitionId))
            .ToListAsync();
    }

    public async Task<int> GetNumberOfRegisteredCompetitorsAsync(CompetitionId competitionId)
    {
        return await _dbContext.Set<Competitor>()
            .Where(c => c.CompetitionId.Equals(competitionId))
            .CountAsync();
    }
}
