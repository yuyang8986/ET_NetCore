using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;
using ET.Domain.Entities.Aggregate.LodgementAggregate;
using ET.Domain.Entities.Aggregate.TaxationAggregate;
using ET.Domain.Entities.Types;
using ET.Infrastructure.DataAccess;
using ET.Infrastructure.DataAccess.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ET.Application.CQRS.IITR.MainFormCommandQuery.MainFormAdd
{
    class MainFormAddCommandHandler : IRequestHandler<MainFormAddCommand, MainFormAddModel>
    {
        private readonly IIndividualRepository _individualRepository;
        private readonly IMainformRepository _mainformRepository;
        private readonly IIITRLodgementRepository _iitrLodgementRepository;
        private readonly ETContext _context;

        public MainFormAddCommandHandler(IIndividualRepository individualRepository, IMainformRepository mainformRepository, IIITRLodgementRepository iitrLodgementRepository, ETContext context)
        {
            _individualRepository = individualRepository;
            _mainformRepository = mainformRepository;
            _iitrLodgementRepository = iitrLodgementRepository;
            _context = context;
        }

        public async Task<MainFormAddModel> Handle(MainFormAddCommand command, CancellationToken cancellationToken)
        {
            ET.Domain.Entities.Aggregate.CustomerAggregate.Individual individual =
                await _individualRepository.GetIndividualById(command.IndividualId);

            if (individual.Lodgements.Any(s => s.FinancialYear.Year == command.FinancialYear))
                throw new Exception("Customer has existing Main Form for this year!");

            FinancialYear year = await _context.FinancialYears.FirstOrDefaultAsync(s => s.Year == command.FinancialYear, cancellationToken: cancellationToken);
            if (year == null) throw new Exception("Financial Year Wrong");

            using (var dbtransaction = _context.Database.BeginTransaction())
            {
                MainForm mainForm = new MainForm();
                _mainformRepository.Add(mainForm);
                if (await _mainformRepository.SaveAll() == false) throw new Exception ("Failed on Creating Main Form");

                IITRLodgement lodgement = new IITRLodgement
                {
                    FinancialYearId = year.FinancialYearId,
                    IndividualId = command.IndividualId,
                    MainFormId = mainForm.Id,
                    LodgementStatus = LodgementStatus.Incomplete
                };
                _iitrLodgementRepository.Add(lodgement);
                if (await _iitrLodgementRepository.SaveAll() == false) throw new Exception("Failed on Creating IITRLodgement");

                mainForm.LodgementId = lodgement.IITRLodgementId;
                if (await _mainformRepository.SaveAll() == false) throw new Exception("Failed on Saving Main Form with Lodgement Id");

                try
                {
                    dbtransaction.Commit();
                    MainFormAddModel dto = new MainFormAddModel
                    {
                        LodgementId = mainForm.LodgementId.Value,
                        MainFormId = mainForm.Id
                    };
                    return dto;
                }
                catch (Exception e)
                {
                    dbtransaction.Rollback();
                    throw new Exception(e.Message);
                }

            }
        }
    }
}
