using MediatR;

namespace ET.Application.CQRS.DeductionTypesQuery.GetAll
{
    public class DeductionTypesGetAllQuery:IRequest<DeductionTypesGetAllModel>
    {
        public DeductionTypesGetAllQuery()
        {
            
        }


        public DeductionTypesGetAllQuery(string occupation)
        {
            Occupation = occupation;
        }


        public string Occupation { get; set; }
    }
}
