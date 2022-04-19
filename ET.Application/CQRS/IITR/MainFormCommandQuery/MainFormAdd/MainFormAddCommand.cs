using MediatR;

namespace ET.Application.CQRS.IITR.MainFormCommandQuery.MainFormAdd
{
    public class MainFormAddCommand:IRequest<MainFormAddModel>
    {
        public int IndividualId { get; set; }
        public int FinancialYear { get; set; }
    }
}
