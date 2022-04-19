using System.Threading;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using ET.Infrastructure.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ET.Application.CQRS.OtherItemTypeDetailQuery.Get
{
    public class OtherItemTypeDetailGetQueryHandler:IRequestHandler<OtherItemTypeDetailGetQuery, OtherItemTypeDetail>
    {
    private readonly ETContext _context;

    public OtherItemTypeDetailGetQueryHandler(ETContext context)
    {
        _context = context;
    }

    public async Task<OtherItemTypeDetail> Handle(OtherItemTypeDetailGetQuery request,
        CancellationToken cancellationToken)
    {
        var otherItemTypeDetail = await _context.OtherItemTypeDetails
            .Include(x=>x.A3SuperCoContribution)
            .Include(x => x.A1Under18)
            .Include(x => x.A2PartYearTaxFreeThreshold)
            .Include(x => x.A4WorkingHolidayMakerNetIncome)
            .Include(x => x.DependencyChildren)
            .Include(x => x.IncomeTests)
            .Include(x => x.L1TaxLossesOfEarlierIncomeYearsClaimedThisIncomeYear)
            .Include(x => x.M1MedicareLevyReductionOrExemption)
            .Include(x => x.M2MedicareLevSurcharge)
            .Include(x => x.PrivateHealthInsurancePolicyDetails)
            .Include(x => x.SpouseDetails)
            .Include(x => x.T6Dependent)
            .Include(x => x.T10OtherNonRefundableTaxOffsets)
            .Include(x => x.T11OtherRefundableTaxOffsets)
            .Include(x => x.T1SeniorsAndPensioners)
            .Include(x => x.T2AustralianSuperannuationIncomeStream)
            .Include(x => x.T3SuperannuationContributionsOnBehalfOfYourSpouse)
            .Include(x => x.T4ZoneOrOverseasForces)
            .FirstOrDefaultAsync(x => x.OtherItemTypeDetailId == request.OtherItemTypeDetailId, cancellationToken);
            return otherItemTypeDetail;
    }
    }
}
