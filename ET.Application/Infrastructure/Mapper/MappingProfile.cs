using AutoMapper;
using ET.Application.CQRS.IITR.BasicDetailsFormCommand.Add;
using ET.Application.CQRS.IITR.BasicDetailsFormCommand.Update;
using ET.Application.CQRS.IITR.DeductionTypeDetailsFormCommand.Update;
using ET.Application.CQRS.IITR.IncomeTypeDetailsFormCommand.UpdateCommand;
using ET.Application.CQRS.IITR.MainFormCommandQuery.MainFormGet;
using ET.Application.CQRS.IITR.OtherTypeDetailsFormCommand.Update;
using ET.Application.CQRS.Individual.IndividualCommand;
using ET.Application.CQRS.Individual.IndividualQuery;
using ET.Domain.Entities.Aggregate.CustomerAggregate;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using ET.Domain.Entities.Auth;
using ET.Infrastructure.DataAccess.DTO.Auth;

namespace ET.Application.Infrastructure.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<IndividualUpdateCommand, Individual>()
                //.ForMember(x => x., opt => opt.Ignore())
                //.ForMember(x => x.Occupation, opt => opt.Ignore())
                //.ForMember(x => x.Occupation, opt => opt.Ignore())
                //.ForMember(x => x.Occupation, opt => opt.Ignore())
                .ForMember(x => x.Occupation, opt =>opt.Ignore());
            CreateMap<Individual, IndividualUpdatedModel>().ReverseMap();
            CreateMap<User, UserForReturnDto>();
            CreateMap<MainForm, MainFormGetModel>().ReverseMap().IncludeAllDerived();
            CreateMap<BasicDetailsFormAddCommand, BasicDetailsForm>();
            CreateMap<BasicDetailsFormUpdateCommand, BasicDetailsForm>();
            CreateMap<Individual, IndividualGetModel>().ReverseMap();
            CreateMap<IncomeTypeDetailsFormUpdateCommand, IncomeDetailsForm>().ReverseMap();
            CreateMap<IncomeTypeDetailsFormUpdateDto, IncomeTypeDetail>().ReverseMap();
            CreateMap<DeductionTypeDetailsFormUpdateCommand, DeductionDetailsForm>().ReverseMap();
            CreateMap<DeductionTypeDetailsFormUpdateDto, DeductionTypeDetail>().ReverseMap();
            CreateMap<OtherTypeDetailsFormUpdateCommand, OtherItemDetailsForm>().ReverseMap();
            CreateMap<OtherItemTypeDetailsFormUpdateDto, OtherItemTypeDetail>().ReverseMap();

        }
    }
}
