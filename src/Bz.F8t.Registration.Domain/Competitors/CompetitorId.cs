using Bz.F8t.Registration.Domain.Common;

namespace Bz.F8t.Registration.Domain.Competitors;

public record CompetitorId : EntityId<Guid>
{
    public CompetitorId(Guid value) : base(value) { }

    public static CompetitorId From(Guid value)
    {
        return new CompetitorId(value);
    }
}
