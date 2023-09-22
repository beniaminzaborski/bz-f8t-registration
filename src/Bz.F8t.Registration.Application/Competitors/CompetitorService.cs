using AutoMapper;
using Bz.F8t.Registration.Domain.CompetitionIntegration;
using Bz.F8t.Registration.Domain.Competitors;

namespace Bz.F8t.Registration.Application.Competitors;

internal class CompetitorService : ICompetitorService
{
    private readonly ICompetitorRepository _competitorRepository;
    private readonly IMapper _mapper;

    public CompetitorService(
        ICompetitorRepository competitorRepository,
        IMapper mapper)
    {
        _competitorRepository = competitorRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CompetitorDto>> GetCompetitorsAsync(Guid competitionId)
    {
        var competitors = await _competitorRepository.GetAllByCompetitionIdAsync(CompetitionId.From(competitionId));
        return _mapper.Map<IEnumerable<Competitor>, IEnumerable<CompetitorDto>>(competitors);
    }
}
