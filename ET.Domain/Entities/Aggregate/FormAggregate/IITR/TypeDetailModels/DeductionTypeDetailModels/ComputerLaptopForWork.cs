using System;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class ComputerLaptopForWork
    {
        public int ComputerLaptopForWorkId { get; set; }
        public string DescriptionOfComputer { get; set; }//Macbook Air
        public string ReasonForUseForWork { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public int PercentageForWorkUse { get; set; }
        public string TypeOfEvidence { get; set; }
        public int Cost { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }

    }
}
