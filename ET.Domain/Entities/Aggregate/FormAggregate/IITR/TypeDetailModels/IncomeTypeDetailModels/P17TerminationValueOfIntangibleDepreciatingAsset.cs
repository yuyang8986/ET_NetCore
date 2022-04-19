﻿using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class P17TerminationValueOfIntangibleDepreciatingAsset
    {
        public int P17TerminationValueOfIntangibleDepreciatingAssetId { get; set; }
        public int Amount { get; set; }
        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}
