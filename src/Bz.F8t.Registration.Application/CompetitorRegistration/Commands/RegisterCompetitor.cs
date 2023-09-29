﻿namespace Bz.F8t.Registration.Application.CompetitorRegistration;

public sealed record RegisterCompetitor(
    Guid RequestId,
    Guid CompetitionId,
    string FirstName,
    string LastName,
    DateTime BirthDate,
    string City,
    string PhoneNumber,
    string ContactPersonNumber)
{
}
