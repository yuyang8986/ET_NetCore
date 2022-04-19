using System;
using System.Collections.Generic;
using System.Text;
using ET.Domain.Entities.Aggregate.CustomerAggregate;
using ET.Domain.Entities.Types;

namespace ET.Domain
{
    public static class OccupationCategoryIncomeTypes
    {
        public static List<OccupationCategoryIncomeType> GenerateOccupationCategoryIncomeTypes(int categoryId,
            string categoryName)
        {
            switch (categoryName)
            {
                case "Labors":
                    return new List<OccupationCategoryIncomeType>
                    {
                        new OccupationCategoryIncomeType
                        {
                            IncomeTypeId = (int) IncomeTypes.SalaryWages,
                            OccupationCategoryId = categoryId
                        }
                       
                    };
                case "Managers":
                    return new List<OccupationCategoryIncomeType>
                    {
                        new OccupationCategoryIncomeType
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.SalaryWages
                        },
                        new OccupationCategoryIncomeType()
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.AllowanceEarnings
                        }
                    };
                case "Business professionals":
                    return new List<OccupationCategoryIncomeType>
                    {
                        new OccupationCategoryIncomeType
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.SalaryWages
                        }
                    };
                case "Doctor, specialist or other medical professional":
                    return new List<OccupationCategoryIncomeType>
                    {
                        new OccupationCategoryIncomeType
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.SalaryWages
                        }
                    };
                case "Engineers":
                    return new List<OccupationCategoryIncomeType>
                    {
                        new OccupationCategoryIncomeType
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.SalaryWages
                        }
                    };
                case "IT professionals":
                    return new List<OccupationCategoryIncomeType>
                    {
                        new OccupationCategoryIncomeType
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.SalaryWages
                        }
                    };
                case "Nurses midwives and direct carers":
                    return new List<OccupationCategoryIncomeType>
                    {
                        new OccupationCategoryIncomeType
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.SalaryWages
                        },
                        new OccupationCategoryIncomeType()
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.AustralianGovernmentAllowances
                        }
                    };
                case "Artists":
                    return new List<OccupationCategoryIncomeType>
                    {
                        new OccupationCategoryIncomeType
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.SalaryWages
                        }
                    };
                case "Public servant":
                    return new List<OccupationCategoryIncomeType>
                    {
                        new OccupationCategoryIncomeType
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.SalaryWages
                        },
                        new OccupationCategoryIncomeType()
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.AustralianGovernmentAllowances
                        }
                    };
                case "Real estate":
                    return new List<OccupationCategoryIncomeType>
                    {
                        new OccupationCategoryIncomeType
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.SalaryWages
                        }
                    };
                case "Shop assistants":
                    return new List<OccupationCategoryIncomeType>
                    {
                        new OccupationCategoryIncomeType
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.SalaryWages
                        },
                        new OccupationCategoryIncomeType()
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.AustralianGovernmentAllowances
                        }
                    };
                case "Teachers and education professionals":
                    return new List<OccupationCategoryIncomeType>
                    {
                        new OccupationCategoryIncomeType
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.SalaryWages
                        },
                        new OccupationCategoryIncomeType()
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.AustralianGovernmentAllowances
                        }
                    };
                case "Office":
                    return new List<OccupationCategoryIncomeType>
                    {
                        new OccupationCategoryIncomeType
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.SalaryWages
                        }
                    };

                case "Uncategorized":
                    return new List<OccupationCategoryIncomeType>
                    {
                        new OccupationCategoryIncomeType
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.SalaryWages
                        }
                    };

                default:
                    return new List<OccupationCategoryIncomeType>
                    {
                        new OccupationCategoryIncomeType
                        {
                            OccupationCategoryId = categoryId,
                            IncomeTypeId = (int) IncomeTypes.SalaryWages
                        }
                    };
            }
            
        }

       
    }
}
