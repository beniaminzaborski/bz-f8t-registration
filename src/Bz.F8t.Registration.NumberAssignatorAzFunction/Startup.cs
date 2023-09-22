using Bz.F8t.Registration.Application.CompetitorRegistration;
using Bz.F8t.Registration.NumberAssignatorAzFunction;
using Bz.F8t.Registration.NumberAssignatorAzFunction.Consumers;
using MassTransit;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;

[assembly: FunctionsStartup(typeof(Startup))]

namespace Bz.F8t.Registration.NumberAssignatorAzFunction;

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder.Services
            .AddScoped<ICompetitorService, CompetitorService>()
            .AddScoped<NumberAssignatorFunction>()
            .AddScoped<CompetitorNotificationFunction>()
            .AddMassTransitForAzureFunctions(cfg =>
            {
                cfg.AddConsumersFromNamespaceContaining<ConsumerNamespace>();
                cfg.AddRequestClient<RegisterCompetitor>(new Uri($"queue:{NumberAssignatorFunction.QueueName}"));
            },
            "ServiceBusConnectionString");
    }
}
