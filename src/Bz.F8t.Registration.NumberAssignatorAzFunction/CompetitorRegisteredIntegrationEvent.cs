﻿using MassTransit;
using System;

namespace Bz.F8t.Registration;

[EntityName("registration-completed")]
public sealed record CompetitorRegisteredIntegrationEvent(
        Guid CompetitorId,
        Guid CompetitionId,
        string FirstName,
        string LastName,
        DateTime BirthDate,
        string City,
        string PhoneNumber,
        string ContactPersonNumber,
        string Number)
{ }
