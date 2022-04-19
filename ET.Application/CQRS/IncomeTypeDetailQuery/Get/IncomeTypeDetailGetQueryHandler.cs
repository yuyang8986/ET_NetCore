using System.Threading;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using ET.Infrastructure.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ET.Application.CQRS.IncomeTypeDetailQuery.Get
{
    public class IncomeTypeDetailGetQueryHandler:IRequestHandler<IncomeTypeDetailGetQuery, IncomeTypeDetail>
    {
    private readonly ETContext _context;

    public IncomeTypeDetailGetQueryHandler(ETContext context)
    {
        _context = context;
    }

    public async Task<IncomeTypeDetail> Handle(IncomeTypeDetailGetQuery request,
        CancellationToken cancellationToken)
    {
        var incomeTypeDetail = await _context.IncomeTypeDetails
            .Include(x=>x.Aaasis)
            .Include(x => x.Aga)
            .Include(x => x.Agp)
            .Include(x => x.Allowances)
            .Include(x => x.Apsi)
            .Include(x => x.Aslsps)
            .Include(x => x.BankInterest)
            .Include(x => x.Bflicafs)
            .Include(x => x.CapitalGainOrLosses)
            .Include(x => x.DeferredNonCommercialBusinessLosses)
            .Include(x => x.Dividends)
            .Include(x => x.Elsps)
            .Include(x => x.EmployeeShareSchemes)
            .Include(x => x.Etps)
            .Include(x => x.Fmisi)
            .Include(x => x.ForeignEntities)
            .Include(x => x.ForeignSourceIncome)
            .Include(x => x.NetFarmManagementDepositOrRepayments)
            .Include(x => x.NetIncomeOrLossFromBusiness)
            .Include(x => x.OtherIncome)
            .Include(x => x.P8BusinessIncomeAndExpensesNonFarming)
            .Include(x => x.P8BusinessIncomeAndExpensesFarming)
            .Include(x => x.P9BusinessLossActivity)
            .Include(x => x.P10SmallBusinessEntityDepreciatingAssets)
            .Include(x => x.P1PersonalServicesIncome)
            .Include(x => x.P2DescriptionOfMainBusinessOrProfessionalActivity)
            .Include(x => x.P4StatusOfBusiness)
            .Include(x => x.P5BusinessNameOfMainBusinessAndAbn)
            .Include(x => x.P11TradeDebtors)
            .Include(x => x.P12TradeCreditors)
            .Include(x => x.P13TotalSalaryAndWageExpenses)
            .Include(x => x.P14PaymentsToAssociatedPersons)
            .Include(x => x.P15IntangibleDepreciatingAssetsFirstDeducted)
            .Include(x => x.P16OtherDepreciatingAssetsFirstDeducted)
            .Include(x => x.P17TerminationValueOfIntangibleDepreciatingAsset)
            .Include(x => x.P18TerminationValueOfOtherDepreciatingAssets)
            .Include(x => x.P19TradingStockElection)
            .Include(x => x.PartnershipsAndTrusts)
            .Include(x => x.PersonalServiceIncome)
            .Include(x => x.P7GstByInternet)
            .Include(x => x.PaygSummaries)
            .Include(x => x.Rent)
            .FirstOrDefaultAsync(x=>x.IncomeTypeDetailId == request.IncomeTypeDetailId,cancellationToken);

        return incomeTypeDetail;
    }
    }
}
