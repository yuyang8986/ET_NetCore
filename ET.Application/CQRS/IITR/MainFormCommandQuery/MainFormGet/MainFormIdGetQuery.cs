using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace ET.Application.CQRS.IITR.MainFormCommandQuery.MainFormGet
{
    public class MainFormIdGetQuery:IRequest<MainFormIdGetModel>
    {
        public int Year { get; set; }
    }
}
