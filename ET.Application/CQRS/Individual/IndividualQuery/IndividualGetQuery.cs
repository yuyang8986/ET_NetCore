using MediatR;

namespace ET.Application.CQRS.Individual.IndividualQuery
{
    public class IndividualGetQuery:IRequest<IndividualGetModel>
    {
        public int Id { get; set; }
    }
}
