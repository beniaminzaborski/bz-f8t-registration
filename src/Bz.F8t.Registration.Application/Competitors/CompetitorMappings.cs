using AutoMapper;
using Bz.F8t.Registration.Domain.Competitors;

namespace Bz.F8t.Registration.Application.Competitors;

internal class CompetitorMappings : Profile
{
    public CompetitorMappings()
    {
        CreateMap<Competitor, CompetitorDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value))
            .ForMember(dest => dest.CompetitionId, opt => opt.MapFrom(src => src.CompetitionId.Value))
            .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.Number));
    }
}
