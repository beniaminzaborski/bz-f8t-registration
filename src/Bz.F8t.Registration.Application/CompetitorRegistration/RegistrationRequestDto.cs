﻿namespace Bz.F8t.Registration.Application.CompetitorRegistration;

public record RegistrationRequestDto(
    Guid CompetitionId,
    string FirstName,
    string LastName,
    DateTime BirthDate,
    string City,
    string PhoneNumber,
    string ContactPersonNumber)
{
}
