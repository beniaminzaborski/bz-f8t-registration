using Bz.F8t.Registration.Domain.Common;

namespace Bz.F8t.Registration.Domain.CompetitorRegistration;

public interface IRegistrationService : IDomainService
{
    Task RegisterAsync();
}
