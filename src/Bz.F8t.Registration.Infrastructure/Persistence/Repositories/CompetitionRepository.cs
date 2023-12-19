using Bz.F8t.Registration.Domain.CompetitionIntegration;
using Bz.F8t.Registration.Infrastructure.Persistence.Common;

namespace Bz.F8t.Registration.Infrastructure.Persistence.Repositories;

internal class CompetitionRepository(ApplicationDbContext dbContext) : Repository<Competition, CompetitionId, ApplicationDbContext>(dbContext), ICompetitionRepository
{
}
