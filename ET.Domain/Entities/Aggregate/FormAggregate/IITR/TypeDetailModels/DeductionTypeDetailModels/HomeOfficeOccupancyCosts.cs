using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class HomeOfficeOccupancyCosts //ONLY work from a home office and your employer does not provide any office for you.
    {
        public int HomeOfficeOccupancyCostsId { get; set; }
        public bool HasEmployeeProvideOffice { get; set; }
        public bool HasDedicatedHomeOffice { get; set; }
        public string DetailsOfExpensesForHomeOffice { get; set; }
        public int TotalAreaOfInsideHome { get; set; } // square meters
        public int TotalAreaOfHomeOffice { get; set; }// square meters
        public bool DidEmployerPaidReimbursementForAnyItems { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }
    }
}
