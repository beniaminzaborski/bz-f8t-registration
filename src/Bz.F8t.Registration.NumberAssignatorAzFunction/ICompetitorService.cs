
using Bz.F8t.Registration.Application.CompetitorRegistration;
using System;
using System.Threading.Tasks;

namespace Bz.F8t.Registration.NumberAssignatorAzFunction;

public interface ICompetitorService
{
    Task<(Guid id, string number)> RegisterCompetitorAndReturnNumber(RegisterCompetitor competitor);
}
