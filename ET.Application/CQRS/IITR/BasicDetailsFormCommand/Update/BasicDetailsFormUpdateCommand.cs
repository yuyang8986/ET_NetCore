using MediatR;

namespace ET.Application.CQRS.IITR.BasicDetailsFormCommand.Update
{
    public class BasicDetailsFormUpdateCommand:IRequest<Unit>
    {

        public int Id { get; set; }
        public int MainFormId { get; set; }

        //Basic form data
        public bool IsLastITRInAu { get; set; }
        public bool IsAustralianCitizenship { get; set; }
        public bool IsLiveFullYearInAu { get; set; }
        public int BSB { get; set; }
        public int AccountNo { get; set; }
        public string AccountName { get; set; }
        public bool HasHELPOrTSL { get; set; }
        public bool HasSFSS { get; set; }
        public bool HasOtherTaxDebt { get; set; }
    }
}
