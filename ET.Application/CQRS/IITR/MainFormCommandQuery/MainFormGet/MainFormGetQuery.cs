using MediatR;

namespace ET.Application.CQRS.IITR.MainFormCommandQuery.MainFormGet
{
    public class MainFormGetQuery:IRequest<MainFormGetModel>
    {
        public int Id { get; set; }
    }
}
