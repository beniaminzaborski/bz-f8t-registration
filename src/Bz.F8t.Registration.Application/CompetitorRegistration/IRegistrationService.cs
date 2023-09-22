using Bz.F8t.Registration.Application.Common;

namespace Bz.F8t.Registration.Application.CompetitorRegistration;

public interface IRegistrationService : IApplicationService
{
    Task<Guid> RegisterAsync(RegistrationRequestDto dto);
}
