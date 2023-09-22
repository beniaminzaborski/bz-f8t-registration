using System;

namespace Bz.F8t.Telemetry.IntegrationEvents;

public sealed record CompetitorTimeCalculatedIntegrationEvent(
    Guid CompetitorId,
    TimeSpan NetTime)
{ }
