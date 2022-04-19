using System.Threading;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using ET.Infrastructure.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ET.Application.CQRS.DeductionTypeDetailQuery.Get
{
    public class DeductionTypeDetailGetQueryHandler:IRequestHandler<DeductionTypeDetailGetQuery, DeductionTypeDetail>
    {
    private readonly ETContext _context;

    public DeductionTypeDetailGetQueryHandler(ETContext context)
    {
        _context = context;
    }

    public async Task<DeductionTypeDetail> Handle(DeductionTypeDetailGetQuery request,
        CancellationToken cancellationToken)
    {
        var deductionTypeDetail = await _context.DeductionTypeDetails
            .Include(x=>x.ComputerLaptopForWork)
            .Include(x => x.D10CostOfTaxAffairs)
            .Include(x => x.D11DeductibleAmountOfUndeductedPurchasePriceOfForeignPensionOrAnnuity)
            .Include(x => x.D12PersonalSuperannuationContributions)
            .Include(x => x.D13DeductionForProjectPool)
            .Include(x => x.D14ForestryManagedInvestmentSchemeDeduction)
            .Include(x => x.D15OtherDeductions)
            .Include(x => x.D1WorkRelatedCarExpenses)
            .Include(x => x.D2WorkRelatedTravelExpenses)
            .Include(x => x.D3WorkRelatedUniformClothingLaundryDryCleaning)
            .Include(x => x.D4WorkRelatedSelfEducationExpenses)
            .Include(x => x.D9GiftsOrDonations)
            .Include(x => x.DividendDeduction)
            .Include(x => x.HomeOfficeExpense)
            .Include(x => x.HomeOfficeOccupancyCosts)
            .Include(x => x.InterestDeduction)
            .Include(x => x.InternetAccessExpense)
            .Include(x => x.LowValuePoolDeduction)
            .Include(x => x.MobilePhoneExpense)
            .Include(x => x.OtherWorkRelatedExpenses)
            .Include(x => x.ParkAndTolls)
            .Include(x => x.SunProtection)
            .Include(x => x.ToolAndEquipment)
            .Include(x => x.UnionFees)
            .FirstOrDefaultAsync(x => x.DeductionTypeDetailId == request.DeductionTypeDetailId, cancellationToken);
            return deductionTypeDetail;
    }
    }
}
