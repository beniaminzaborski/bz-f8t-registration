using MassTransit;
using Microsoft.Extensions.Logging;

namespace Bz.F8t.Registration.Application.CompetitorRegistration;

public class RegisterCompetitorConsumer : IConsumer<RegisterCompetitor>
{
    private readonly ILogger<RegisterCompetitorConsumer> _logger;

    public RegisterCompetitorConsumer(ILogger<RegisterCompetitorConsumer> logger)
    {
        _logger = logger;
    }

    public async Task Consume(ConsumeContext<RegisterCompetitor> context)
    {
        var registerCompetitor = context.Message;

        _logger.LogDebug("Request competitor registration {FirstName} {LastName} on competition {CompetitionId}",
           registerCompetitor.FirstName,
           registerCompetitor.LastName,
           registerCompetitor.CompetitionId);

        //(var id, var number) = await _competitorService.RegisterCompetitorAndReturnNumber(registerCompetitor);

        //if (id != System.Guid.Empty && !string.IsNullOrEmpty(number))
        //{
        //    await context.Publish(new CompetitorRegisteredIntegrationEvent(
        //        id,
        //        registerCompetitor.CompetitionId,
        //        registerCompetitor.FirstName,
        //        registerCompetitor.LastName,
        //        registerCompetitor.BirthDate,
        //        registerCompetitor.City,
        //        registerCompetitor.PhoneNumber,
        //        registerCompetitor.ContactPersonNumber,
        //        number.ToString()
        //    ));
        //}
    }
}
