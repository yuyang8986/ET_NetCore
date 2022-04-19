using System.Security.Authentication;
using ET.Domain.Entities.Auth;
using ET.Infrastructure.DataAccess.Repository.Interfaces;

namespace ET.Application.Services.Individual
{
    public static class IndividualSecurity
    {
        public static void CheckIndividualAccessibleByCurrentUser(int individualId, User usr, IIndividualRepository individualRepository)
        {
            if (individualId != individualRepository.GetIndividualByIndividualAccountUser(usr).Result.IndividualId)
                throw new AuthenticationException("Not Authorized");
        }
    }
}
