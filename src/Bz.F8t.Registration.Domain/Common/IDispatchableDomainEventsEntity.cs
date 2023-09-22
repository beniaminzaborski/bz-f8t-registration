namespace Bz.F8t.Registration.Domain.Common;

public interface IDispatchableDomainEventsEntity
{
    IReadOnlyCollection<IDomainEvent> GetDomainEvents();

    public void ClearDomainEvents();
}
