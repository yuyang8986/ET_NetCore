using System;
using System.Collections.Generic;
using System.Text;
using ET.Domain.Entities.Aggregate.CustomerAggregate;
using ET.Domain.Entities.Types;

namespace ET.Domain
{
    public static class OccupationCategoryDeductionTypes
    {
        public static List<OccupationCategoryDeductionType> GenerateOccupationCategoryDeductionTypes(int categoryId,
         string categoryName)
        {
            switch (categoryName)
            {
                case "Labors":
                    return new List<OccupationCategoryDeductionType>
                    {
                        new OccupationCategoryDeductionType
                        {
                            DeductionTypeId = (int) DeductionTypes.WorkrelatedCarExpenses,
                            OccupationCategoryId = categoryId
                        },
                        new OccupationCategoryDeductionType
                        {
                            DeductionTypeId = (int) DeductionTypes.CostofManagingTaxAffairs,
                            OccupationCategoryId = categoryId
                        },

                        new OccupationCategoryDeductionType
                        {
                            DeductionTypeId = (int) DeductionTypes.WorkrelateduniformOccupationSpecificOrProtectiveClothingLaundryAndDryCleaningExpenses,
                            OccupationCategoryId = categoryId
                        },
                        new OccupationCategoryDeductionType
                        {
                        OccupationCategoryId = categoryId,
                        DeductionTypeId = (int) DeductionTypes.SunProtection
                    },
                        new OccupationCategoryDeductionType
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.ToolsandEquipment
                        }
                    };
                case "Managers":
                    return new List<OccupationCategoryDeductionType>
                    {
                        new OccupationCategoryDeductionType
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.WorkrelatedCarExpenses,
                        },
                        new OccupationCategoryDeductionType()
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.CostofManagingTaxAffairs
                        },
                        new OccupationCategoryDeductionType
                        {
                            DeductionTypeId = (int) DeductionTypes.WorkrelateduniformOccupationSpecificOrProtectiveClothingLaundryAndDryCleaningExpenses,
                            OccupationCategoryId = categoryId
                        },
                        new OccupationCategoryDeductionType
                        {
                        DeductionTypeId = (int) DeductionTypes.UnionFees,
                        OccupationCategoryId = categoryId
                        },
                        new OccupationCategoryDeductionType
                        {
                            DeductionTypeId = (int) DeductionTypes.WorkrelatedSelfeducationExpenses,
                            OccupationCategoryId = categoryId
                        }
                    };
                case "Business professionals":
                    return new List<OccupationCategoryDeductionType>
                    {
                        new OccupationCategoryDeductionType
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int)DeductionTypes.WorkrelatedSelfeducationExpenses
                        },
                        new OccupationCategoryDeductionType()
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.CostofManagingTaxAffairs
                        },
                        new OccupationCategoryDeductionType()
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.UnionFees
                        }
                    };
                case "Doctor, specialist or other medical professional":
                    return new List<OccupationCategoryDeductionType>
                    {
                        new OccupationCategoryDeductionType
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.CostofManagingTaxAffairs
                        },
                        new OccupationCategoryDeductionType()
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.WorkrelateduniformOccupationSpecificOrProtectiveClothingLaundryAndDryCleaningExpenses
                        },
                        new OccupationCategoryDeductionType
                        {
                            DeductionTypeId = (int) DeductionTypes.UnionFees,
                            OccupationCategoryId = categoryId
                        },
                        new OccupationCategoryDeductionType
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.ToolsandEquipment
                        }
                    };
                case "Engineers":
                    return new List<OccupationCategoryDeductionType>
                    {
                        new OccupationCategoryDeductionType
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.CostofManagingTaxAffairs
                        },
                        new OccupationCategoryDeductionType()
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.WorkrelatedSelfeducationExpenses
                        },
                        new OccupationCategoryDeductionType
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.ToolsandEquipment
                        },
                        new OccupationCategoryDeductionType()
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.WorkrelatedCarExpenses
                        }
                    };
                case "IT professionals":
                    return new List<OccupationCategoryDeductionType>
                    {
                        new OccupationCategoryDeductionType
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.CostofManagingTaxAffairs
                        },
                        new OccupationCategoryDeductionType()
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.ComputerLaptopUsedforWorkPurposes
                        },
                        new OccupationCategoryDeductionType()
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.HomeOfficeExpenses
                        },
                        new OccupationCategoryDeductionType()
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.HomeOfficeOccupancyCosts
                        }
                    };
                case "Nurses midwives and direct carers":
                    return new List<OccupationCategoryDeductionType>
                    {
                        new OccupationCategoryDeductionType
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.CostofManagingTaxAffairs
                        },
                        new OccupationCategoryDeductionType()
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int)DeductionTypes.WorkrelateduniformOccupationSpecificOrProtectiveClothingLaundryAndDryCleaningExpenses
                        }
                    };
                case "Artists":
                    return new List<OccupationCategoryDeductionType>
                    {
                        new OccupationCategoryDeductionType
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.CostofManagingTaxAffairs
                        },
                        new OccupationCategoryDeductionType()
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int)DeductionTypes.ToolsandEquipment
                        },
                        new OccupationCategoryDeductionType
                        {
                            DeductionTypeId = (int) DeductionTypes.UnionFees,
                            OccupationCategoryId = categoryId
                        }
                    };
                case "Public servant":
                    return new List<OccupationCategoryDeductionType>
                    {
                        new OccupationCategoryDeductionType
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.CostofManagingTaxAffairs
                        },
                        new OccupationCategoryDeductionType()
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.WorkrelateduniformOccupationSpecificOrProtectiveClothingLaundryAndDryCleaningExpenses
                        }
                    };
                case "Real estate":
                    return new List<OccupationCategoryDeductionType>
                    {
                        new OccupationCategoryDeductionType
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.WorkrelatedCarExpenses
                        },
                        new OccupationCategoryDeductionType()
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.CostofManagingTaxAffairs
                        },
                        new OccupationCategoryDeductionType
                        {
                            DeductionTypeId = (int) DeductionTypes.UnionFees,
                            OccupationCategoryId = categoryId
                        },
                    };
                case "Shop assistants":
                    return new List<OccupationCategoryDeductionType>
                    {
                        new OccupationCategoryDeductionType
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.CostofManagingTaxAffairs
                        },
                        new OccupationCategoryDeductionType()
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.WorkrelateduniformOccupationSpecificOrProtectiveClothingLaundryAndDryCleaningExpenses
                        }
                    };
                case "Teachers and education professionals":
                    return new List<OccupationCategoryDeductionType>
                    {
                        new OccupationCategoryDeductionType
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int)DeductionTypes.CostofManagingTaxAffairs
                        },
                        new OccupationCategoryDeductionType()
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.WorkrelatedSelfeducationExpenses
                        },
                        new OccupationCategoryDeductionType
                        {
                            DeductionTypeId = (int) DeductionTypes.UnionFees,
                            OccupationCategoryId = categoryId
                        }
                    };
                case "Office":
                    return new List<OccupationCategoryDeductionType>
                    {
                        new OccupationCategoryDeductionType
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.CostofManagingTaxAffairs
                        },
                        new OccupationCategoryDeductionType()
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int) DeductionTypes.WorkrelatedSelfeducationExpenses
                        }
                    };



                case "Uncategorized":
                    return new List<OccupationCategoryDeductionType>
                    {
                        new OccupationCategoryDeductionType
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int)DeductionTypes.CostofManagingTaxAffairs
                        }
                    };

                default:
                    return new List<OccupationCategoryDeductionType>
                    {
                        new OccupationCategoryDeductionType
                        {
                            OccupationCategoryId = categoryId,
                            DeductionTypeId = (int)DeductionTypes.CostofManagingTaxAffairs
                        }
                    };
            }
        }
    }
}
