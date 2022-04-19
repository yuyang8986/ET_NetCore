using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ET.Domain;
using ET.Domain.Entities.Aggregate.CustomerAggregate;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;
using ET.Domain.Entities.Aggregate.LodgementAggregate;
using ET.Domain.Entities.Aggregate.TaxationAggregate;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using ET.Domain.Entities.Auth;
using ET.Domain.Entities.Types;
using ET.Infrastructure.DataAccess.Repository.Interfaces;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace ET.Infrastructure.DataAccess
{
    public class Seed
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IIndividualRepository _individualRepository;
        private readonly ETContext _context;
        private readonly IIITRLodgementRepository _lodgementRepository;
        private string dirLocation;


        public Seed(UserManager<User> userManager, RoleManager<Role> roleManager, IIndividualRepository individualRepository, ETContext context, IIITRLodgementRepository lodgementRepository)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _individualRepository = individualRepository;
            _context = context;
            _lodgementRepository = lodgementRepository;
            dirLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        }

        public void SeedData()
        {
            //must in this order
            SeedUsers();
            SeedIncomeTypes();
            SeedDeductionTypes();
            SeedOtherItemTypes();
            _context.SaveChanges();

            SeedOccupationCategories();
            _context.SaveChanges();

            SeedOccupationCategoriesRecommendedIncomeAndDeductionTypes();
            _context.SaveChanges();

            SeedOccupations();
            _context.SaveChanges();

            SeedIndividuals();
            _context.SaveChanges();

            SeedFinancialYears();
            _context.SaveChanges();
         
            SeedMainforms();
            _context.SaveChanges();

            SeedLodgements();
            _context.SaveChanges();
        }

        private void SeedLodgements()
        {
            if (!_lodgementRepository.GetLodgements().Result.Any())
            {
                _lodgementRepository.Add(
                    new IITRLodgement
                    {
                        IndividualId = _context.Individuals.FirstOrDefault().IndividualId,
                        FinancialYearId = _context.FinancialYears.FirstOrDefault().FinancialYearId,
                        MainFormId = _context.MainForms.FirstOrDefault().Id,
                        LodgementStatus = LodgementStatus.Incomplete
                    });
            }
        }

        private void SeedMainforms()
        {
            if (!_context.MainForms.Any())
            {
                var mainForm = new MainForm
                {
                    LodgementId = 1
                };

                _context.Add(mainForm);
            }
        }

        private void SeedFinancialYears()
        {
            if (!_context.FinancialYears.Any())
            {
                int currentFinancialYear = DateTime.Now.Month >= 7 ? DateTime.Now.Year : DateTime.Now.Year - 1;

                var financialYear1 = new FinancialYear(currentFinancialYear);
                _context.Add(financialYear1);

                var financialYear2 = new FinancialYear(currentFinancialYear - 1);
                _context.Add(financialYear2);

                var financialYear3 = new FinancialYear(currentFinancialYear - 2);
                _context.Add(financialYear3);

                var financialYear4 = new FinancialYear(currentFinancialYear - 3);
                _context.Add(financialYear4);

                var financialYear5 = new FinancialYear(currentFinancialYear - 4);
                _context.Add(financialYear5);

                var financialYear6 = new FinancialYear(currentFinancialYear - 5);
                _context.Add(financialYear6);

                var financialYear7 = new FinancialYear(currentFinancialYear - 6);
                _context.Add(financialYear7);

                var financialYear8 = new FinancialYear(currentFinancialYear - 7);
                _context.Add(financialYear8);
              
            }
        }

        private void SeedIndividuals()
        {
            if (!_individualRepository.GetIndividuals().Result.Any())
            {
                _individualRepository.Add(
                    new Individual
                    {
                        FirstName = "Larry",
                        LastName = "Yu",
                        Email = "yuyang8986@gmail.com",
                        DateTimeCreated = DateTime.Now,
                        Gender = "Male",
                        TFN = "12345678",
                        AccountUserId = 1,
                        HomeAddressStreet = "12 Carlotta St",
                        HomeAddressCity = "Artarmon",
                        HomeAddressState = "NSW",
                        HomeAddressCountry = "Australia",
                        HomeAddressPostCode = "2064",
                        DateOfBirth = DateTime.Parse("01/01/2018"),
                        OccupationId = _context.Occupations.FirstOrDefault().OccupationId,
                        HomePhone = "0299990000",
                        Mobile = "0430444012"
                    });
            }
        }

        private void SeedUsers()
        {
            
            if (!_userManager.Users.Any())
            {
                var userData = System.IO.File.ReadAllText(dirLocation + "/ET_NetCore/ET.Infrastructure/DataAccess/SeedData/UserSeedData.json");
                var users = JsonConvert.DeserializeObject<List<User>>(userData);
                var roles = new List<Role>
                {
                    new Role {Name = AccountTypes.Member.ToString()},
                    new Role {Name = AccountTypes.Individual.ToString()},
                    new Role {Name = AccountTypes.BusinessMainAccount.ToString()},
                    new Role {Name = AccountTypes.BusinessSubAccount.ToString()},
                    new Role {Name = AccountTypes.PremiumAccount.ToString()},
                    new Role {Name = AccountTypes.SuperAdmin.ToString()}
                };

                foreach (var role in roles)
                {
                    _roleManager.CreateAsync(role).Wait();
                }

                foreach (var user in users)
                {
                    _userManager.CreateAsync(user, "password").Wait();
                    _userManager.AddToRoleAsync(user, AccountTypes.Individual.ToString()).Wait();
                }

                //var superAdmin = new User { UserName = "Admin" };

                //IdentityResult result = _userManager.CreateAsync(superAdmin, "etno1").Result;

                //if (result.Succeeded)
                //{
                //    var adminAdded = _userManager.FindByNameAsync("Admin").Result;
                //    _userManager.AddToRolesAsync(adminAdded, new[] { "SuperAdmin", "Member", "PremiumAccount" }).Wait();
                //}
            }
        }

        private void SeedIncomeTypes()
        {
            if (!_context.IncomeTypes.Any())
            {
                var incomeTypeData = System.IO.File.ReadAllText(dirLocation + "/ET_NetCore/ET.Infrastructure/DataAccess/SeedData/IncomeTypes.json");
                var incomeTypes = JsonConvert.DeserializeObject<List<IncomeType>>(incomeTypeData);

                foreach (var type in incomeTypes)
                {
                    _context.Add(type);
                }
            }
        }

        private void SeedOtherItemTypes()
        {
            if (!_context.OtherItemTypes.Any())
            {
                var typeData = System.IO.File.ReadAllText(dirLocation + "/ET_NetCore/ET.Infrastructure/DataAccess/SeedData/OtherItemTypes.json");
                var types = JsonConvert.DeserializeObject<List<OtherItemType>>(typeData);

                foreach (var type in types)
                {
                    _context.Add(type);
                }
            }
        }

        private void SeedOccupations()
        {
            if (!_context.Occupations.Any())
            {
                var data = System.IO.File.ReadAllText(dirLocation + "/ET_NetCore/ET.Infrastructure/DataAccess/SeedData/OccupationTypes.json");
                var types = JsonConvert.DeserializeObject<List<Occupation>>(data);

                List<OccupationCategory> occupationCategories = _context.OccupationCategories.ToList();
                foreach (var type in types)
                {
                    if (occupationCategories.Any(s => type.Name.ToUpper() == s.Name.ToUpper()))
                    {
                        OccupationCategory occupationCategory =
                            occupationCategories.FirstOrDefault(s => type.Name.ToUpper() == s.Name.ToUpper());

                        if(occupationCategory!=null)
                        type.OccupationCategoryId = occupationCategory.OccupationCategoryId;
                    }

                    _context.Add(type);
                }
            }
        }

        private void SeedOccupationCategories()
        {
            if (!_context.OccupationCategories.Any())
            {
                var data = System.IO.File.ReadAllText(dirLocation + "/ET_NetCore/ET.Infrastructure/DataAccess/SeedData/OccupationCategories.json");
                var types = JsonConvert.DeserializeObject<List<OccupationCategory>>(data);

                foreach (var type in types)
                {
                    _context.Add(type);
                }
            }
        }

        private void SeedOccupationCategoriesRecommendedIncomeAndDeductionTypes()
        {
            if (!_context.OccupationCategoryIncomeTypes.Any())
            {
                SeedOccupationCategoryRecommendedIncomeTypes();
            }

            if (!_context.OccupationCategoryDeductionTypes.Any())
            {
                SeedOccupationCategoryRecommendedDeductionTypes();
            }
        }

        private void SeedOccupationCategoryRecommendedIncomeTypes()
        {
            //add income types recommended for each occupation category
            foreach (var category in _context.OccupationCategories)
            {
              _context.AddRange(OccupationCategoryIncomeTypes.GenerateOccupationCategoryIncomeTypes(category.OccupationCategoryId,category.Name));
            };
        }

        private void SeedOccupationCategoryRecommendedDeductionTypes()
        {
            //add deduction types recommended for each occupation category
            foreach (var category in _context.OccupationCategories)
            {
                _context.AddRange(OccupationCategoryDeductionTypes.GenerateOccupationCategoryDeductionTypes(category.OccupationCategoryId, category.Name));
            }
        }

        private void SeedDeductionTypes()
        {
            if (!_context.DeductionTypes.Any())
            {
                var deductionTypeData = System.IO.File.ReadAllText(dirLocation + "/ET_NetCore/ET.Infrastructure/DataAccess/SeedData/DeductionTypes.json");
                var deductionTypes = JsonConvert.DeserializeObject<List<DeductionType>>(deductionTypeData);

                foreach (var type in deductionTypes)
                {
                    _context.Add(type);
                }
            }
        }
    }
}
