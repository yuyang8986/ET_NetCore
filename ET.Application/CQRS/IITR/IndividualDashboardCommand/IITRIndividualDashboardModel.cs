using System.Collections.Generic;
using ET.Domain.Entities.Aggregate.LodgementAggregate;

namespace ET.Application.CQRS.IITR.IndividualDashboardCommand
{
    public class IITRIndividualDashboardModel
    {
        public IITRIndividualDashboardModel(IEnumerable<IITRLodgement> iitrLodgements, int individualId, string lastName, string firstName)
        {
            IitrLodgements = iitrLodgements;
            IndividualId = individualId;
            LastName = lastName;
            FirstName = firstName;
        }

        public string FirstName { get;}
        public string LastName { get;}
        public int IndividualId { get;}

        public IEnumerable<IITRLodgement> IitrLodgements { get; }
    }
}
