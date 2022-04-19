using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using ET.Infrastructure.DataAccess;
using ET.Infrastructure.DataAccess.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ET.Application.CQRS.DeductionTypesQuery.GetAll
{
    public class DeductionTypesGetAllQueryHandler : IRequestHandler<DeductionTypesGetAllQuery, DeductionTypesGetAllModel>
    {
        private readonly ETContext _context;
        private readonly IMainformRepository _mainformRepository;

        public DeductionTypesGetAllQueryHandler(ETContext context, IMainformRepository mainformRepository)
        {
            _context = context;
            _mainformRepository = mainformRepository;
        }
        public async Task<DeductionTypesGetAllModel> Handle(DeductionTypesGetAllQuery request, CancellationToken cancellationToken)
        {
            var deductionTypes = await _context.DeductionTypes.ToListAsync(cancellationToken);

            //query with Occupation Selected for current individual to find other people choices
            if (!String.IsNullOrEmpty(request.Occupation))
            {
                List<DeductionType> deductionTypesSelectedByOtherPeople = new List<DeductionType>();
                var individualsWithSameOccupation =
                    _context.Individuals.Where(s => s.Occupation.Name == request.Occupation);

                var individualDeductionTypeForms = individualsWithSameOccupation
                    .Join(_context.IITRLodgements, i => i.IndividualId, m => m.IndividualId, (i, m) => new { i, m })
                    .Join(_context.MainForms, im => im.m.IITRLodgementId, m => m.LodgementId, (im, m) => new { im, m });

                var deductionTypeDeductionTypeForms = await
                    individualDeductionTypeForms.Select(x => x.m.DeductionTypeForm.DeductionTypeDeductionTypeForms).ToListAsync(cancellationToken);


                foreach (var deductions in deductionTypeDeductionTypeForms)
                {
                    deductionTypesSelectedByOtherPeople.AddRange(deductions.Select(x => x.DeductionType));
                }

                deductionTypesSelectedByOtherPeople = deductionTypesSelectedByOtherPeople.GroupBy(x => x)
                    .OrderByDescending(g => g.Count()).Take(8).Select(x => x.Key).ToList();

                return new DeductionTypesGetAllModel(deductionTypesSelectedByOtherPeople);  
                   
                
            }

            return new DeductionTypesGetAllModel(deductionTypes);


        }
    }
}
