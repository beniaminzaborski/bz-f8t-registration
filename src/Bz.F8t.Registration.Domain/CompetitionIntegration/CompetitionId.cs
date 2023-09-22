using Bz.F8t.Registration.Domain.Common;

namespace Bz.F8t.Registration.Domain.CompetitionIntegration;

public record CompetitionId : EntityId<Guid>
{
    public CompetitionId(Guid value) : base(value) { }

    public static CompetitionId From(Guid value)
    { 
        return new CompetitionId(value);
    }
}
