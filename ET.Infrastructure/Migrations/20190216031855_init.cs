using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ET.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeductionTypes",
                columns: table => new
                {
                    DeductionTypeId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeductionTypes", x => x.DeductionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "FinancialYears",
                columns: table => new
                {
                    FinancialYearId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialYears", x => x.FinancialYearId);
                });

            migrationBuilder.CreateTable(
                name: "IncomeTypes",
                columns: table => new
                {
                    IncomeTypeId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeTypes", x => x.IncomeTypeId);
                });

            migrationBuilder.CreateTable(
                name: "MainForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LodgementId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainForms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OccupationCategories",
                columns: table => new
                {
                    OccupationCategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupationCategories", x => x.OccupationCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "OtherItemTypes",
                columns: table => new
                {
                    OtherItemTypeId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherItemTypes", x => x.OtherItemTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Business",
                columns: table => new
                {
                    BusinessId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    AddressCity = table.Column<string>(nullable: true),
                    AddressPostCode = table.Column<string>(nullable: true),
                    AddressState = table.Column<string>(nullable: true),
                    AddressCountry = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business", x => x.BusinessId);
                    table.ForeignKey(
                        name: "FK_Business_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxCompliances",
                columns: table => new
                {
                    TaxComplianceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    FinancialYearId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxCompliances", x => x.TaxComplianceId);
                    table.ForeignKey(
                        name: "FK_TaxCompliances_FinancialYears_FinancialYearId",
                        column: x => x.FinancialYearId,
                        principalTable: "FinancialYears",
                        principalColumn: "FinancialYearId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxRates",
                columns: table => new
                {
                    TaxRateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Rate = table.Column<double>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    FinancialYearId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxRates", x => x.TaxRateId);
                    table.ForeignKey(
                        name: "FK_TaxRates_FinancialYears_FinancialYearId",
                        column: x => x.FinancialYearId,
                        principalTable: "FinancialYears",
                        principalColumn: "FinancialYearId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BasicDetailsForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsLastITRInAu = table.Column<bool>(nullable: false),
                    IsAustralianCitizenship = table.Column<bool>(nullable: false),
                    IsLiveFullYearInAu = table.Column<bool>(nullable: false),
                    BSB = table.Column<int>(nullable: false),
                    AccountNo = table.Column<int>(nullable: false),
                    AccountName = table.Column<string>(nullable: true),
                    HasHELPOrTSL = table.Column<bool>(nullable: false),
                    HasSFSS = table.Column<bool>(nullable: false),
                    HasOtherTaxDebt = table.Column<bool>(nullable: false),
                    MainFormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicDetailsForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasicDetailsForms_MainForms_MainFormId",
                        column: x => x.MainFormId,
                        principalTable: "MainForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeductionDetailsForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MainFormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeductionDetailsForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeductionDetailsForms_MainForms_MainFormId",
                        column: x => x.MainFormId,
                        principalTable: "MainForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeductionTypeForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MainFormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeductionTypeForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeductionTypeForms_MainForms_MainFormId",
                        column: x => x.MainFormId,
                        principalTable: "MainForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncomeDetailsForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MainFormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeDetailsForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncomeDetailsForms_MainForms_MainFormId",
                        column: x => x.MainFormId,
                        principalTable: "MainForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncomeTypeForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MainFormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeTypeForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncomeTypeForms_MainForms_MainFormId",
                        column: x => x.MainFormId,
                        principalTable: "MainForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherItemDetailsForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MainFormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherItemDetailsForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherItemDetailsForms_MainForms_MainFormId",
                        column: x => x.MainFormId,
                        principalTable: "MainForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherItemTypeForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MainFormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherItemTypeForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherItemTypeForms_MainForms_MainFormId",
                        column: x => x.MainFormId,
                        principalTable: "MainForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OccupationCategoryDeductionTypes",
                columns: table => new
                {
                    OccupationCategoryId = table.Column<int>(nullable: false),
                    DeductionTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupationCategoryDeductionTypes", x => new { x.DeductionTypeId, x.OccupationCategoryId });
                    table.ForeignKey(
                        name: "FK_OccupationCategoryDeductionTypes_DeductionTypes_DeductionTypeId",
                        column: x => x.DeductionTypeId,
                        principalTable: "DeductionTypes",
                        principalColumn: "DeductionTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OccupationCategoryDeductionTypes_OccupationCategories_OccupationCategoryId",
                        column: x => x.OccupationCategoryId,
                        principalTable: "OccupationCategories",
                        principalColumn: "OccupationCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OccupationCategoryIncomeTypes",
                columns: table => new
                {
                    OccupationCategoryId = table.Column<int>(nullable: false),
                    IncomeTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupationCategoryIncomeTypes", x => new { x.IncomeTypeId, x.OccupationCategoryId });
                    table.ForeignKey(
                        name: "FK_OccupationCategoryIncomeTypes_IncomeTypes_IncomeTypeId",
                        column: x => x.IncomeTypeId,
                        principalTable: "IncomeTypes",
                        principalColumn: "IncomeTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OccupationCategoryIncomeTypes_OccupationCategories_OccupationCategoryId",
                        column: x => x.OccupationCategoryId,
                        principalTable: "OccupationCategories",
                        principalColumn: "OccupationCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Occupations",
                columns: table => new
                {
                    OccupationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    OccupationCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupations", x => x.OccupationId);
                    table.ForeignKey(
                        name: "FK_Occupations_OccupationCategories_OccupationCategoryId",
                        column: x => x.OccupationCategoryId,
                        principalTable: "OccupationCategories",
                        principalColumn: "OccupationCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Thresholds",
                columns: table => new
                {
                    ThresholdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Min = table.Column<int>(nullable: false),
                    Max = table.Column<int>(nullable: false),
                    TaxComplianceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thresholds", x => x.ThresholdId);
                    table.ForeignKey(
                        name: "FK_Thresholds_TaxCompliances_TaxComplianceId",
                        column: x => x.TaxComplianceId,
                        principalTable: "TaxCompliances",
                        principalColumn: "TaxComplianceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeductionTypeDetails",
                columns: table => new
                {
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TotalAmount = table.Column<double>(nullable: false),
                    DeductionTypeId = table.Column<int>(nullable: false),
                    DeductionDetailsFormId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeductionTypeDetails", x => x.DeductionTypeDetailId);
                    table.ForeignKey(
                        name: "FK_DeductionTypeDetails_DeductionDetailsForms_DeductionDetailsFormId",
                        column: x => x.DeductionDetailsFormId,
                        principalTable: "DeductionDetailsForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeductionTypeDetails_DeductionTypes_DeductionTypeId",
                        column: x => x.DeductionTypeId,
                        principalTable: "DeductionTypes",
                        principalColumn: "DeductionTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeductionTypeDeductionTypeForms",
                columns: table => new
                {
                    DeductionTypeId = table.Column<int>(nullable: false),
                    DeductionTypeFormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeductionTypeDeductionTypeForms", x => new { x.DeductionTypeFormId, x.DeductionTypeId });
                    table.ForeignKey(
                        name: "FK_DeductionTypeDeductionTypeForms_DeductionTypeForms_DeductionTypeFormId",
                        column: x => x.DeductionTypeFormId,
                        principalTable: "DeductionTypeForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeductionTypeDeductionTypeForms_DeductionTypes_DeductionTypeId",
                        column: x => x.DeductionTypeId,
                        principalTable: "DeductionTypes",
                        principalColumn: "DeductionTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncomeTypeDetails",
                columns: table => new
                {
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IncomeTypeId = table.Column<int>(nullable: false),
                    TotalAmount = table.Column<double>(nullable: false),
                    TotalTaxOffsetAmount = table.Column<double>(nullable: false),
                    IncomeDetailsFormId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeTypeDetails", x => x.IncomeTypeDetailId);
                    table.ForeignKey(
                        name: "FK_IncomeTypeDetails_IncomeDetailsForms_IncomeDetailsFormId",
                        column: x => x.IncomeDetailsFormId,
                        principalTable: "IncomeDetailsForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IncomeTypeDetails_IncomeTypes_IncomeTypeId",
                        column: x => x.IncomeTypeId,
                        principalTable: "IncomeTypes",
                        principalColumn: "IncomeTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncomeTypeIncomeTypeForms",
                columns: table => new
                {
                    IncomeTypeId = table.Column<int>(nullable: false),
                    IncomeTypeFormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeTypeIncomeTypeForms", x => new { x.IncomeTypeFormId, x.IncomeTypeId });
                    table.ForeignKey(
                        name: "FK_IncomeTypeIncomeTypeForms_IncomeTypeForms_IncomeTypeFormId",
                        column: x => x.IncomeTypeFormId,
                        principalTable: "IncomeTypeForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IncomeTypeIncomeTypeForms_IncomeTypes_IncomeTypeId",
                        column: x => x.IncomeTypeId,
                        principalTable: "IncomeTypes",
                        principalColumn: "IncomeTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherItemTypeDetails",
                columns: table => new
                {
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OtherItemTypeId = table.Column<int>(nullable: false),
                    OtherItemDetailsFormId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherItemTypeDetails", x => x.OtherItemTypeDetailId);
                    table.ForeignKey(
                        name: "FK_OtherItemTypeDetails_OtherItemDetailsForms_OtherItemDetailsFormId",
                        column: x => x.OtherItemDetailsFormId,
                        principalTable: "OtherItemDetailsForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OtherItemTypeDetails_OtherItemTypes_OtherItemTypeId",
                        column: x => x.OtherItemTypeId,
                        principalTable: "OtherItemTypes",
                        principalColumn: "OtherItemTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherItemTypeOtherItemTypeForms",
                columns: table => new
                {
                    OtherItemTypeId = table.Column<int>(nullable: false),
                    OtherItemTypeFormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherItemTypeOtherItemTypeForms", x => new { x.OtherItemTypeFormId, x.OtherItemTypeId });
                    table.ForeignKey(
                        name: "FK_OtherItemTypeOtherItemTypeForms_OtherItemTypeForms_OtherItemTypeFormId",
                        column: x => x.OtherItemTypeFormId,
                        principalTable: "OtherItemTypeForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OtherItemTypeOtherItemTypeForms_OtherItemTypes_OtherItemTypeId",
                        column: x => x.OtherItemTypeId,
                        principalTable: "OtherItemTypes",
                        principalColumn: "OtherItemTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Individuals",
                columns: table => new
                {
                    IndividualId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    DateTimeCreated = table.Column<DateTime>(nullable: false),
                    TFN = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    HomeAddressStreet = table.Column<string>(nullable: true),
                    HomeAddressCity = table.Column<string>(nullable: true),
                    HomeAddressPostCode = table.Column<string>(nullable: true),
                    HomeAddressState = table.Column<string>(nullable: true),
                    HomeAddressCountry = table.Column<string>(nullable: true),
                    PostalAddressStreet = table.Column<string>(nullable: true),
                    PostalAddressCity = table.Column<string>(nullable: true),
                    PostalAddressPostCode = table.Column<string>(nullable: true),
                    PostalAddressState = table.Column<string>(nullable: true),
                    PostalAddressCountry = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    AccountUserId = table.Column<int>(nullable: false),
                    OccupationId = table.Column<int>(nullable: true),
                    BusinessId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individuals", x => x.IndividualId);
                    table.ForeignKey(
                        name: "FK_Individuals_AspNetUsers_AccountUserId",
                        column: x => x.AccountUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Individuals_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "BusinessId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Individuals_Occupations_OccupationId",
                        column: x => x.OccupationId,
                        principalTable: "Occupations",
                        principalColumn: "OccupationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComputerLaptopForWorks",
                columns: table => new
                {
                    ComputerLaptopForWorkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescriptionOfComputer = table.Column<string>(nullable: true),
                    ReasonForUseForWork = table.Column<string>(nullable: true),
                    DateOfPurchase = table.Column<DateTime>(nullable: false),
                    PercentageForWorkUse = table.Column<int>(nullable: false),
                    TypeOfEvidence = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerLaptopForWorks", x => x.ComputerLaptopForWorkId);
                    table.ForeignKey(
                        name: "FK_ComputerLaptopForWorks_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D10CostOfTaxAffairses",
                columns: table => new
                {
                    D10CostOfTaxAffairsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CostForManagingTaxLastYear = table.Column<int>(nullable: false),
                    InterestChargedByATO = table.Column<int>(nullable: false),
                    LegalOrLawyerCostForTaxAffairs = table.Column<int>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D10CostOfTaxAffairses", x => x.D10CostOfTaxAffairsId);
                    table.ForeignKey(
                        name: "FK_D10CostOfTaxAffairses_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D11DeductibleAmountOfUndeductedPurchasePriceOfForeignPensionOrAnnuities",
                columns: table => new
                {
                    D11DeductibleAmountOfUndeductedPurchasePriceOfForeignPensionOrAnnuityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D11DeductibleAmountOfUndeductedPurchasePriceOfForeignPensionOrAnnuities", x => x.D11DeductibleAmountOfUndeductedPurchasePriceOfForeignPensionOrAnnuityId);
                    table.ForeignKey(
                        name: "FK_D11DeductibleAmountOfUndeductedPurchasePriceOfForeignPensionOrAnnuities_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D12PersonalSuperannuationContributionses",
                columns: table => new
                {
                    D12PersonalSuperannuationContributionsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsConfirmClaimDeductionAndReceivedConfirmationFromSuperFund = table.Column<bool>(nullable: false),
                    NameOfFund = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<int>(nullable: false),
                    DeductionAmount = table.Column<int>(nullable: false),
                    SuperFundABN = table.Column<string>(nullable: true),
                    SuperFundTFN = table.Column<string>(nullable: true),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D12PersonalSuperannuationContributionses", x => x.D12PersonalSuperannuationContributionsId);
                    table.ForeignKey(
                        name: "FK_D12PersonalSuperannuationContributionses_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D13DeductionForProjectPools",
                columns: table => new
                {
                    D13DeductionForProjectPoolId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IndividualDeductionForProjectPool = table.Column<int>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D13DeductionForProjectPools", x => x.D13DeductionForProjectPoolId);
                    table.ForeignKey(
                        name: "FK_D13DeductionForProjectPools_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D14ForestryManagedInvestmentSchemeDeductions",
                columns: table => new
                {
                    D14ForestryManagedInvestmentSchemeDeductionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D14ForestryManagedInvestmentSchemeDeductions", x => x.D14ForestryManagedInvestmentSchemeDeductionId);
                    table.ForeignKey(
                        name: "FK_D14ForestryManagedInvestmentSchemeDeductions_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D15OtherDeductionses",
                columns: table => new
                {
                    D15OtherDeductionsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    AmountRelatingToFinancialInvestmentsNotIncludedElseWhere = table.Column<int>(nullable: false),
                    AmountRelatingToRentalIncomeNotIncludedElseWhere = table.Column<int>(nullable: false),
                    AmountOtherDeduction = table.Column<int>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D15OtherDeductionses", x => x.D15OtherDeductionsId);
                    table.ForeignKey(
                        name: "FK_D15OtherDeductionses_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D1WorkRelatedCarExpenseses",
                columns: table => new
                {
                    D1WorkRelatedCarExpensesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HasUseCarForWorkRelatedTravel = table.Column<bool>(nullable: false),
                    ReasonForUseCarForWork = table.Column<string>(nullable: true),
                    NumOfKiloMetersTravelledForWork = table.Column<int>(nullable: false),
                    IsCarRegisteredUnderYourName = table.Column<bool>(nullable: false),
                    DidRecordAllTripsInCarBookFor12ContinuousWeeks = table.Column<bool>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D1WorkRelatedCarExpenseses", x => x.D1WorkRelatedCarExpensesId);
                    table.ForeignKey(
                        name: "FK_D1WorkRelatedCarExpenseses_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D2WorkRelatedTravelExpenseses",
                columns: table => new
                {
                    D2WorkRelatedTravelExpensesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypeOfTravelExpense = table.Column<string>(nullable: true),
                    TotalPaid = table.Column<int>(nullable: false),
                    IsAnyTravelAllowanceListInPAYG = table.Column<bool>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D2WorkRelatedTravelExpenseses", x => x.D2WorkRelatedTravelExpensesId);
                    table.ForeignKey(
                        name: "FK_D2WorkRelatedTravelExpenseses_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D3WorkRelatedUniformClothingLaundryDryCleanings",
                columns: table => new
                {
                    D3WorkRelatedUniformClothingLaundryDryCleaningId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TotalPaid = table.Column<int>(nullable: false),
                    TypeOfClothing = table.Column<string>(nullable: true),
                    DescriptionForAllClothing = table.Column<string>(nullable: true),
                    HasReceipt = table.Column<bool>(nullable: false),
                    IsProtectiveClothingRequiredForWork = table.Column<bool>(nullable: false),
                    HasBusinessLogoIfClaimUniform = table.Column<bool>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D3WorkRelatedUniformClothingLaundryDryCleanings", x => x.D3WorkRelatedUniformClothingLaundryDryCleaningId);
                    table.ForeignKey(
                        name: "FK_D3WorkRelatedUniformClothingLaundryDryCleanings_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D4WorkRelatedSelfEducationExpenseses",
                columns: table => new
                {
                    D4WorkRelatedSelfEducationExpensesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypeOfConnectionForWork = table.Column<string>(nullable: true),
                    TotalAmount = table.Column<int>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D4WorkRelatedSelfEducationExpenseses", x => x.D4WorkRelatedSelfEducationExpensesId);
                    table.ForeignKey(
                        name: "FK_D4WorkRelatedSelfEducationExpenseses_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D9GiftsOrDonationses",
                columns: table => new
                {
                    D9GiftsOrDonationsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    NameOfCharities = table.Column<string>(nullable: true),
                    HasReceipt = table.Column<bool>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D9GiftsOrDonationses", x => x.D9GiftsOrDonationsId);
                    table.ForeignKey(
                        name: "FK_D9GiftsOrDonationses_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DividendDeductions",
                columns: table => new
                {
                    DividendDeductionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DividendDeductions", x => x.DividendDeductionId);
                    table.ForeignKey(
                        name: "FK_DividendDeductions_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeOfficeExpenses",
                columns: table => new
                {
                    HomeOfficeExpenseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true),
                    WeeksWorkedForYear = table.Column<int>(nullable: false),
                    AverageNumberOfHoursWorkedPerWeekAtHome = table.Column<int>(nullable: false),
                    PercentageOfTelephoneBillsToWork = table.Column<int>(nullable: false),
                    TypeOfEvidenceForTelephoneBills = table.Column<string>(nullable: true),
                    TelephoneCostForWorkTotal = table.Column<int>(nullable: false),
                    PercentageOfOtherDepreciationToWork = table.Column<int>(nullable: false),
                    TypeOfEvidenceForOtherDepreciation = table.Column<string>(nullable: true),
                    OtherDepreciationForWorkTotal = table.Column<int>(nullable: false),
                    PercentageOfOtherPrintingPostageStationery = table.Column<int>(nullable: false),
                    TypeOfEvidenceForPrintingPostageStationery = table.Column<string>(nullable: true),
                    PrintingPostageStationeryForWorkTotal = table.Column<int>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeOfficeExpenses", x => x.HomeOfficeExpenseId);
                    table.ForeignKey(
                        name: "FK_HomeOfficeExpenses_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeOfficeOccupancyCostses",
                columns: table => new
                {
                    HomeOfficeOccupancyCostsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HasEmployeeProvideOffice = table.Column<bool>(nullable: false),
                    HasDedicatedHomeOffice = table.Column<bool>(nullable: false),
                    DetailsOfExpensesForHomeOffice = table.Column<string>(nullable: true),
                    TotalAreaOfInsideHome = table.Column<int>(nullable: false),
                    TotalAreaOfHomeOffice = table.Column<int>(nullable: false),
                    DidEmployerPaidReimbursementForAnyItems = table.Column<bool>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeOfficeOccupancyCostses", x => x.HomeOfficeOccupancyCostsId);
                    table.ForeignKey(
                        name: "FK_HomeOfficeOccupancyCostses_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterestDeductions",
                columns: table => new
                {
                    InterestDeductionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestDeductions", x => x.InterestDeductionId);
                    table.ForeignKey(
                        name: "FK_InterestDeductions_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InternetAccessExpenses",
                columns: table => new
                {
                    InternetAccessExpenseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReasonForUsingInternetForWork = table.Column<string>(nullable: true),
                    PercentageForWork = table.Column<int>(nullable: false),
                    TotalCharge = table.Column<int>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternetAccessExpenses", x => x.InternetAccessExpenseId);
                    table.ForeignKey(
                        name: "FK_InternetAccessExpenses_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LowValuePoolDeductions",
                columns: table => new
                {
                    LowValuePoolDeductionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AmountRelatedToFinancialInvestments = table.Column<int>(nullable: false),
                    AmountRelatedToRentalProperties = table.Column<int>(nullable: false),
                    OtherAmount = table.Column<int>(nullable: false),
                    Total = table.Column<int>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LowValuePoolDeductions", x => x.LowValuePoolDeductionId);
                    table.ForeignKey(
                        name: "FK_LowValuePoolDeductions_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MobilePhoneExpenses",
                columns: table => new
                {
                    MobilePhoneExpenseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsUsingPhoneForWork = table.Column<bool>(nullable: false),
                    PercentageOfWorkUse = table.Column<int>(nullable: false),
                    TotalBilledAmount = table.Column<int>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobilePhoneExpenses", x => x.MobilePhoneExpenseId);
                    table.ForeignKey(
                        name: "FK_MobilePhoneExpenses_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherWorkRelatedExpenseses",
                columns: table => new
                {
                    OtherWorkRelatedExpensesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true),
                    Desciption = table.Column<string>(nullable: true),
                    TypeOfEvidence = table.Column<string>(nullable: true),
                    TotalAmount = table.Column<int>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherWorkRelatedExpenseses", x => x.OtherWorkRelatedExpensesId);
                    table.ForeignKey(
                        name: "FK_OtherWorkRelatedExpenseses_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParkAndTollses",
                columns: table => new
                {
                    ParkAndTollsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TotalCostOfParking = table.Column<int>(nullable: false),
                    TotalCostOfTolls = table.Column<int>(nullable: false),
                    HasReceipts = table.Column<bool>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkAndTollses", x => x.ParkAndTollsId);
                    table.ForeignKey(
                        name: "FK_ParkAndTollses_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SunProtections",
                columns: table => new
                {
                    SunProtectionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: false),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SunProtections", x => x.SunProtectionId);
                    table.ForeignKey(
                        name: "FK_SunProtections_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ToolAndEquipments",
                columns: table => new
                {
                    ToolAndEquipmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddUpItemsCost300OrLess = table.Column<int>(nullable: false),
                    DescriptionAboutToolRelatedToWork = table.Column<string>(nullable: true),
                    AddUpItemsCost301OrMore = table.Column<int>(nullable: false),
                    DescriptionForItemsCost301OrMore = table.Column<string>(nullable: true),
                    PercentageOfTimeForWork = table.Column<int>(nullable: false),
                    TypeOfEvidence = table.Column<string>(nullable: true),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToolAndEquipments", x => x.ToolAndEquipmentId);
                    table.ForeignKey(
                        name: "FK_ToolAndEquipments_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnionFeeses",
                columns: table => new
                {
                    UnionFeesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UnionFeePaid = table.Column<int>(nullable: false),
                    TypeOfEvidence = table.Column<string>(nullable: true),
                    DeductionTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnionFeeses", x => x.UnionFeesId);
                    table.ForeignKey(
                        name: "FK_UnionFeeses_DeductionTypeDetails_DeductionTypeDetailId",
                        column: x => x.DeductionTypeDetailId,
                        principalTable: "DeductionTypeDetails",
                        principalColumn: "DeductionTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Aaasiss",
                columns: table => new
                {
                    AAASISId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaxWithHeld = table.Column<int>(nullable: false),
                    TaxableComponentTaxed = table.Column<int>(nullable: false),
                    TaxableComponentUnTaxed = table.Column<int>(nullable: false),
                    AssessableAmountFromCappedDefinedBenefitIncomeStream = table.Column<int>(nullable: false),
                    LumpSumInArrearsTaxed = table.Column<int>(nullable: false),
                    LumpSumInArrearsUnTaxed = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aaasiss", x => x.AAASISId);
                    table.ForeignKey(
                        name: "FK_Aaasiss_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agas",
                columns: table => new
                {
                    AGAId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true),
                    TaxWithHeld = table.Column<int>(nullable: false),
                    TotalAllowance = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agas", x => x.AGAId);
                    table.ForeignKey(
                        name: "FK_Agas_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agps",
                columns: table => new
                {
                    AGPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true),
                    TaxWithHeld = table.Column<int>(nullable: false),
                    TotalAmount = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agps", x => x.AGPId);
                    table.ForeignKey(
                        name: "FK_Agps_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Allowances",
                columns: table => new
                {
                    AllowanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    AllowanceType = table.Column<string>(nullable: true),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allowances", x => x.AllowanceId);
                    table.ForeignKey(
                        name: "FK_Allowances_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Apsis",
                columns: table => new
                {
                    APSIId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaxWithHeld = table.Column<int>(nullable: false),
                    Total = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apsis", x => x.APSIId);
                    table.ForeignKey(
                        name: "FK_Apsis_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Aslsps",
                columns: table => new
                {
                    ASLSPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfPayment = table.Column<DateTime>(nullable: false),
                    PayerABN = table.Column<string>(nullable: true),
                    TaxWithHeld = table.Column<int>(nullable: false),
                    TaxableComponentTaxedElement = table.Column<int>(nullable: false),
                    TaxableComponentUntaxedElement = table.Column<int>(nullable: false),
                    Desciption = table.Column<string>(nullable: true),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aslsps", x => x.ASLSPId);
                    table.ForeignKey(
                        name: "FK_Aslsps_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankInterests",
                columns: table => new
                {
                    BankInterestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tax = table.Column<int>(nullable: false),
                    Total = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankInterests", x => x.BankInterestId);
                    table.ForeignKey(
                        name: "FK_BankInterests_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bflicafss",
                columns: table => new
                {
                    BFLICAFSId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BonusFromLifeInsuranceCompaniesAndFriendlySocieties = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bflicafss", x => x.BFLICAFSId);
                    table.ForeignKey(
                        name: "FK_Bflicafss_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CapitalGainOrLosseses",
                columns: table => new
                {
                    CapitalGainOrLossesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HasCGTEventThisYear = table.Column<bool>(nullable: false),
                    HasAppliedExemptionOrRollover = table.Column<bool>(nullable: false),
                    ExemptionOrRollOverCodeIfAny = table.Column<string>(nullable: true),
                    NetCapitalGain = table.Column<int>(nullable: false),
                    TotalCurrentYearCG = table.Column<int>(nullable: false),
                    NetCapitalLossCarriedForwardToLaterIncomeYears = table.Column<int>(nullable: false),
                    CreditForForeignResidentCapitalGainsWithholding = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapitalGainOrLosseses", x => x.CapitalGainOrLossesId);
                    table.ForeignKey(
                        name: "FK_CapitalGainOrLosseses_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeferredNonCommercialBusinessLosseses",
                columns: table => new
                {
                    DeferredNonCommercialBusinessLossesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ShareOfDeferredLossesFromPartnershipCarryingBusinessOfInvesting = table.Column<int>(nullable: false),
                    ShareOfDeferredLossesFromPartnershipRentalBusiness = table.Column<int>(nullable: false),
                    ShareOfDeferredLossesFromPartnershipOthers = table.Column<int>(nullable: false),
                    ShareOfDeferredLossesFromPartnershipActivities = table.Column<int>(nullable: false),
                    DeferredLossesFromSoleTraderActivities = table.Column<int>(nullable: false),
                    PrimaryProductionDeferredLosses = table.Column<int>(nullable: false),
                    NonPrimaryProductionDeferredLosses = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeferredNonCommercialBusinessLosseses", x => x.DeferredNonCommercialBusinessLossesId);
                    table.ForeignKey(
                        name: "FK_DeferredNonCommercialBusinessLosseses_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dividendses",
                columns: table => new
                {
                    DividendsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TFNWithHeld = table.Column<int>(nullable: false),
                    Unfranked = table.Column<int>(nullable: false),
                    Franked = table.Column<int>(nullable: false),
                    FrankingCredit = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dividendses", x => x.DividendsId);
                    table.ForeignKey(
                        name: "FK_Dividendses_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Elsps",
                columns: table => new
                {
                    ELSPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaxWithHeld = table.Column<int>(nullable: false),
                    AmountA = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    FullAmountB = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elsps", x => x.ELSPId);
                    table.ForeignKey(
                        name: "FK_Elsps_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeShareSchemeses",
                columns: table => new
                {
                    EmployeeShareSchemesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DFTUFSEligibleForReductionAmount = table.Column<int>(nullable: false),
                    DFTUFSNotEligibleForReductionAmount = table.Column<int>(nullable: false),
                    DiscountFromDeferralSchemes = table.Column<int>(nullable: false),
                    DiscountESSIntBef172009 = table.Column<int>(nullable: false),
                    TotalAssesableDiscountAmout = table.Column<int>(nullable: false),
                    ESSTFNAmountsWithHeldFromDiscounts = table.Column<int>(nullable: false),
                    ForeignSourceDiscounts = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeShareSchemeses", x => x.EmployeeShareSchemesId);
                    table.ForeignKey(
                        name: "FK_EmployeeShareSchemeses_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Etps",
                columns: table => new
                {
                    ETPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfPayment = table.Column<DateTime>(nullable: false),
                    ABN = table.Column<string>(nullable: true),
                    TaxWithHeld = table.Column<int>(nullable: false),
                    TaxableComponent = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etps", x => x.ETPId);
                    table.ForeignKey(
                        name: "FK_Etps_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fmisis",
                columns: table => new
                {
                    FMISIId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fmisis", x => x.FMISIId);
                    table.ForeignKey(
                        name: "FK_Fmisis_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ForeignEntitieses",
                columns: table => new
                {
                    ForeignEntitiesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HasDirectOrInDirectInterestInCFC = table.Column<bool>(nullable: false),
                    CFCIncome = table.Column<int>(nullable: false),
                    HasCausedTransferOfPropertyOrServiceToNonResidentTrustEstate = table.Column<bool>(nullable: false),
                    TransferTrustIncome = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForeignEntitieses", x => x.ForeignEntitiesId);
                    table.ForeignKey(
                        name: "FK_ForeignEntitieses_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ForeignSourceIncomes",
                columns: table => new
                {
                    ForeignSourceIncomeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssessableForeignSourceIncome = table.Column<int>(nullable: false),
                    OtherNetForeignEmploymentIncome = table.Column<int>(nullable: false),
                    IsOtherNetForeignEmploymentIncomeProfit = table.Column<bool>(nullable: false),
                    NetForeignPensionWithoutUndeductedPurchasePrice = table.Column<int>(nullable: false),
                    IsNetForeignPensionWithoutUndeductedPurchasePriceProfit = table.Column<bool>(nullable: false),
                    NetForeignPensionWithUndeductedPurchasePrice = table.Column<int>(nullable: false),
                    IsNetForeignPensionWithUndeductedPurchasePriceProfit = table.Column<bool>(nullable: false),
                    NetForeignRent = table.Column<int>(nullable: false),
                    IsNetForeignRentProfit = table.Column<bool>(nullable: false),
                    OtherNetForeignIncome = table.Column<int>(nullable: false),
                    IsOtherNetForeignIncomeProfit = table.Column<bool>(nullable: false),
                    OtherNetForeignSourceIncome = table.Column<int>(nullable: false),
                    IsOtherNetForeignSourceIncomeProfit = table.Column<int>(nullable: false),
                    FrankingCreditsFromNewZealandFrankingCompany = table.Column<int>(nullable: false),
                    NetForeignEmploymenyIncomePaymenySummary = table.Column<int>(nullable: false),
                    IsNetForeignEmploymenyIncomePaymenySummaryProfit = table.Column<bool>(nullable: false),
                    ExemptForeignEmploymentIncome = table.Column<int>(nullable: false),
                    ForeignIncomeTaxOffset = table.Column<int>(nullable: false),
                    HasInterestEarnedInAssestOutsideAUMoreThan5000AUD = table.Column<int>(nullable: false),
                    NonResidentForeignIncome = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForeignSourceIncomes", x => x.ForeignSourceIncomeId);
                    table.ForeignKey(
                        name: "FK_ForeignSourceIncomes_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NetFarmManagementDepositOrRepaymentses",
                columns: table => new
                {
                    NetFarmManagementDepositOrRepaymentsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeductibleDeposits = table.Column<int>(nullable: false),
                    EarlyRepaymentsNaturalDisasterAndDrought = table.Column<int>(nullable: false),
                    OtherRepayment = table.Column<int>(nullable: false),
                    NetFarmManagementDepositsOrRepayments = table.Column<int>(nullable: false),
                    IsNetIncomeEqualisationProfit = table.Column<bool>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetFarmManagementDepositOrRepaymentses", x => x.NetFarmManagementDepositOrRepaymentsId);
                    table.ForeignKey(
                        name: "FK_NetFarmManagementDepositOrRepaymentses_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NetIncomeOrLossFromBusinesses",
                columns: table => new
                {
                    NetIncomeOrLossFromBusinessId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NetIncomeOrLossFromBusinessAmount = table.Column<int>(nullable: false),
                    IsNetIncomeOrLossFromBusinessAmountProfit = table.Column<bool>(nullable: false),
                    NetIncomeOrLossFromRentalPropertyBusiness = table.Column<int>(nullable: false),
                    IsNetIncomeOrLossFromRentalPropertyBusinessProfit = table.Column<bool>(nullable: false),
                    OtherIncomeOrLossToItem15 = table.Column<int>(nullable: false),
                    IsOtherIncomeOrLossToItem15 = table.Column<bool>(nullable: false),
                    NetSmallBusinessIncome = table.Column<int>(nullable: false),
                    NetIncomeLossFromBusinessTaxWithheldVoluntaryAgreement = table.Column<int>(nullable: false),
                    NetIncomeLossFromBusinessTaxWithheldABNNotQuoted = table.Column<int>(nullable: false),
                    NetIncomeLossFromBusinessTaxWithheldForeignResidentWithholdingExcludingCG = table.Column<int>(nullable: false),
                    NetIncomeLossFromBusinessTaxWithheldLabourHireOrOtherSpecifiedPayments = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetIncomeOrLossFromBusinesses", x => x.NetIncomeOrLossFromBusinessId);
                    table.ForeignKey(
                        name: "FK_NetIncomeOrLossFromBusinesses_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherIncomes",
                columns: table => new
                {
                    OtherIncomeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaxWithHeldLumpSumPaymentInArrears = table.Column<int>(nullable: false),
                    TaxableProfessionalIncome = table.Column<int>(nullable: false),
                    OneActionCode = table.Column<string>(nullable: true),
                    AssessableBalancingAdjustmentForLowValuePoolDeductionRelationToRentalProperty = table.Column<int>(nullable: false),
                    AssessableBalancingAdjustmentForLowValuePoolDeductionRelationToFinancialInvestments = table.Column<int>(nullable: false),
                    OtherCategoryOneIncome = table.Column<int>(nullable: false),
                    OtherCategoryTwoIncomeATOInterest = table.Column<int>(nullable: false),
                    OtherCategoryThreeAmount = table.Column<int>(nullable: false),
                    OtherCategoryThreeDescription = table.Column<string>(nullable: true),
                    OtherCategoryThreeCode = table.Column<string>(nullable: true),
                    IncomeFromFinancialInvestmentNotIncludedAtAnotherLabel = table.Column<int>(nullable: false),
                    OtherCategory3Income = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherIncomes", x => x.OtherIncomeId);
                    table.ForeignKey(
                        name: "FK_OtherIncomes_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "P10SmallBusinessEntityDepreciatingAssetses",
                columns: table => new
                {
                    P10SmallBusinessEntityDepreciatingAssetsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SmallBusinessEntitySimplifiedDepreciationDeductionForCertainAssets = table.Column<int>(nullable: false),
                    SmallBusinessEntitySimplifiedDepreciationDeductionForGeneralSmallBusinessPool = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P10SmallBusinessEntityDepreciatingAssetses", x => x.P10SmallBusinessEntityDepreciatingAssetsId);
                    table.ForeignKey(
                        name: "FK_P10SmallBusinessEntityDepreciatingAssetses_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "P11TradeDebtorses",
                columns: table => new
                {
                    P11TradeDebtorsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P11TradeDebtorses", x => x.P11TradeDebtorsId);
                    table.ForeignKey(
                        name: "FK_P11TradeDebtorses_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "P12TradeCreditorses",
                columns: table => new
                {
                    P12TradeCreditorsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P12TradeCreditorses", x => x.P12TradeCreditorsId);
                    table.ForeignKey(
                        name: "FK_P12TradeCreditorses_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "P13TotalSalaryAndWageExpenseses",
                columns: table => new
                {
                    P13TotalSalaryAndWageExpensesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P13TotalSalaryAndWageExpenseses", x => x.P13TotalSalaryAndWageExpensesId);
                    table.ForeignKey(
                        name: "FK_P13TotalSalaryAndWageExpenseses_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "P14PaymentsToAssociatedPersonses",
                columns: table => new
                {
                    P14PaymentsToAssociatedPersonsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P14PaymentsToAssociatedPersonses", x => x.P14PaymentsToAssociatedPersonsId);
                    table.ForeignKey(
                        name: "FK_P14PaymentsToAssociatedPersonses_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "P15IntangibleDepreciatingAssetsFirstDeducteds",
                columns: table => new
                {
                    P15IntangibleDepreciatingAssetsFirstDeductedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P15IntangibleDepreciatingAssetsFirstDeducteds", x => x.P15IntangibleDepreciatingAssetsFirstDeductedId);
                    table.ForeignKey(
                        name: "FK_P15IntangibleDepreciatingAssetsFirstDeducteds_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "P16OtherDepreciatingAssetsFirstDeducteds",
                columns: table => new
                {
                    P16OtherDepreciatingAssetsFirstDeductedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P16OtherDepreciatingAssetsFirstDeducteds", x => x.P16OtherDepreciatingAssetsFirstDeductedId);
                    table.ForeignKey(
                        name: "FK_P16OtherDepreciatingAssetsFirstDeducteds_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "P17TerminationValueOfIntangibleDepreciatingAssets",
                columns: table => new
                {
                    P17TerminationValueOfIntangibleDepreciatingAssetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P17TerminationValueOfIntangibleDepreciatingAssets", x => x.P17TerminationValueOfIntangibleDepreciatingAssetId);
                    table.ForeignKey(
                        name: "FK_P17TerminationValueOfIntangibleDepreciatingAssets_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "P18TerminationValueOfOtherDepreciatingAssetses",
                columns: table => new
                {
                    P18TerminationValueOfOtherDepreciatingAssetsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P18TerminationValueOfOtherDepreciatingAssetses", x => x.P18TerminationValueOfOtherDepreciatingAssetsId);
                    table.ForeignKey(
                        name: "FK_P18TerminationValueOfOtherDepreciatingAssetses_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "P19TradingStockElections",
                columns: table => new
                {
                    P19TradingStockElectionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Election = table.Column<bool>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P19TradingStockElections", x => x.P19TradingStockElectionId);
                    table.ForeignKey(
                        name: "FK_P19TradingStockElections_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "P1PersonalServicesIncomes",
                columns: table => new
                {
                    P1PersonalServicesIncomeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsSatisfyResultTest = table.Column<bool>(nullable: false),
                    HasReceivedPSIDeterminationForceForWholePeriod = table.Column<bool>(nullable: false),
                    IsPSIMoreThanEightyPercentOfAllIncome = table.Column<bool>(nullable: false),
                    IsSatisfyUnRelatedClientsTest = table.Column<bool>(nullable: false),
                    IsSatisfyEmploymentTest = table.Column<bool>(nullable: false),
                    IsSatisfyBusinessPremisesTest = table.Column<bool>(nullable: false),
                    PSIVoluntaryAgreement = table.Column<int>(nullable: false),
                    PSDIABNNotQuoted = table.Column<int>(nullable: false),
                    PSILabourHireOrOtherSpecifiedPayments = table.Column<int>(nullable: false),
                    PSIOther = table.Column<int>(nullable: false),
                    DeductionforPaymentsToAssociatesForPrincipalWork = table.Column<int>(nullable: false),
                    TotalAmountOfOtherDeductionsAgainstPSI = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P1PersonalServicesIncomes", x => x.P1PersonalServicesIncomeId);
                    table.ForeignKey(
                        name: "FK_P1PersonalServicesIncomes_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "P2DescriptionOfMainBusinessOrProfessionalActivities",
                columns: table => new
                {
                    P2DescriptionOfMainBusinessOrProfessionalActivityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    IndustryCode = table.Column<string>(nullable: true),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P2DescriptionOfMainBusinessOrProfessionalActivities", x => x.P2DescriptionOfMainBusinessOrProfessionalActivityId);
                    table.ForeignKey(
                        name: "FK_P2DescriptionOfMainBusinessOrProfessionalActivities_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "P4StatusOfBusinesses",
                columns: table => new
                {
                    P4StatusOfBusinessId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P4StatusOfBusinesses", x => x.P4StatusOfBusinessId);
                    table.ForeignKey(
                        name: "FK_P4StatusOfBusinesses_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "P5BusinessNameOfMainBusinessAndAbns",
                columns: table => new
                {
                    P5BusinessNameOfMainBusinessAndABNId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusinessNameOfMainBusiness = table.Column<string>(nullable: true),
                    ABN = table.Column<string>(nullable: true),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P5BusinessNameOfMainBusinessAndAbns", x => x.P5BusinessNameOfMainBusinessAndABNId);
                    table.ForeignKey(
                        name: "FK_P5BusinessNameOfMainBusinessAndAbns_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "P7GstByInternets",
                columns: table => new
                {
                    P7GSTByInternetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsSellingGoodOrServiceUsingInternet = table.Column<bool>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P7GstByInternets", x => x.P7GSTByInternetId);
                    table.ForeignKey(
                        name: "FK_P7GstByInternets_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "P8BusinessIncomeAndExpensesFarmings",
                columns: table => new
                {
                    P8BusinessIncomeAndExpensesFarmingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GrossABNNotQuoted = table.Column<int>(nullable: false),
                    GrossVoluntaryAgreement = table.Column<int>(nullable: false),
                    GrossLabourHireOrOther = table.Column<int>(nullable: false),
                    AssessableGovernmentIndustryPayment = table.Column<int>(nullable: false),
                    AssessableGovernmentIndustryPaymentActionCode = table.Column<string>(nullable: true),
                    OtherBusinessIncome = table.Column<int>(nullable: false),
                    IsOtherBusinessIncomeProfit = table.Column<bool>(nullable: false),
                    OpeningStock = table.Column<int>(nullable: false),
                    PurchasesAndOtherCosts = table.Column<int>(nullable: false),
                    ClosingStock = table.Column<int>(nullable: false),
                    ClosingStockCode = table.Column<string>(nullable: true),
                    ContractorSubContractorAndCommissionExpenses = table.Column<int>(nullable: false),
                    BadDebts = table.Column<int>(nullable: false),
                    LeaseExpenses = table.Column<int>(nullable: false),
                    RentExpenses = table.Column<int>(nullable: false),
                    InterestExpensesOversea = table.Column<int>(nullable: false),
                    DepreciationExpenses = table.Column<int>(nullable: false),
                    MotorVehicleExpenses = table.Column<int>(nullable: false),
                    MotorVehicleExpenseActionCode = table.Column<string>(nullable: true),
                    RepairsAndMaintenance = table.Column<int>(nullable: false),
                    AllOtherExpenses = table.Column<int>(nullable: false),
                    Section40880Deduction = table.Column<int>(nullable: false),
                    BusinessDeductionForProjectPool = table.Column<int>(nullable: false),
                    LandCareOperationsAndBusinessDeductionForDeclineInValueOfWaterFacility = table.Column<int>(nullable: false),
                    IncomeReconciliationAdjustments = table.Column<int>(nullable: false),
                    IsIncomeReconciliationAdjustmentsProfit = table.Column<bool>(nullable: false),
                    ExpenseReconAdjustment = table.Column<int>(nullable: false),
                    IsExpenseReconAdjustmentProfit = table.Column<bool>(nullable: false),
                    DeferredNonCommercialLossesFromAPriorYear = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P8BusinessIncomeAndExpensesFarmings", x => x.P8BusinessIncomeAndExpensesFarmingId);
                    table.ForeignKey(
                        name: "FK_P8BusinessIncomeAndExpensesFarmings_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "P8BusinessIncomeAndExpensesNonFarmings",
                columns: table => new
                {
                    P8BusinessIncomeAndExpensesNonFarmingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GrossABNNotQuoted = table.Column<int>(nullable: false),
                    GrossSubjectToForeignResidentWithHoldingExcludingCapitalGains = table.Column<int>(nullable: false),
                    GrossVoluntaryAgreement = table.Column<int>(nullable: false),
                    GrossLabourHireOrOther = table.Column<int>(nullable: false),
                    AssessableGovernmentIndustryPayment = table.Column<int>(nullable: false),
                    AssessableGovernmentIndustryPaymentActionCode = table.Column<string>(nullable: true),
                    OtherBusinessIncome = table.Column<int>(nullable: false),
                    IsOtherBusinessIncomeProfit = table.Column<bool>(nullable: false),
                    OpeningStock = table.Column<int>(nullable: false),
                    PurchasesAndOtherCosts = table.Column<int>(nullable: false),
                    ClosingStock = table.Column<int>(nullable: false),
                    ClosingStockCode = table.Column<string>(nullable: true),
                    ContractorSubContractorAndCommissionExpenses = table.Column<int>(nullable: false),
                    BadDebts = table.Column<int>(nullable: false),
                    LeaseExpenses = table.Column<int>(nullable: false),
                    RentExpenses = table.Column<int>(nullable: false),
                    InterestExpensesOversea = table.Column<int>(nullable: false),
                    DepreciationExpenses = table.Column<int>(nullable: false),
                    MotorVehicleExpenses = table.Column<int>(nullable: false),
                    MotorVehicleExpenseActionCode = table.Column<string>(nullable: true),
                    RepairsAndMaintenance = table.Column<int>(nullable: false),
                    AllOtherExpenses = table.Column<int>(nullable: false),
                    Section40880Deduction = table.Column<int>(nullable: false),
                    BusinessDeductionForProjectPool = table.Column<int>(nullable: false),
                    LandCareOperationsAndBusinessDeductionForDeclineInValueOfWaterFacility = table.Column<int>(nullable: false),
                    IncomeReconciliationAdjustments = table.Column<int>(nullable: false),
                    IsIncomeReconciliationAdjustmentsProfit = table.Column<bool>(nullable: false),
                    ExpenseReconAdjustment = table.Column<int>(nullable: false),
                    IsExpenseReconAdjustmentProfit = table.Column<bool>(nullable: false),
                    DeferredNonCommercialLossesFromAPriorYear = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P8BusinessIncomeAndExpensesNonFarmings", x => x.P8BusinessIncomeAndExpensesNonFarmingId);
                    table.ForeignKey(
                        name: "FK_P8BusinessIncomeAndExpensesNonFarmings_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "P9BusinessLossActivities",
                columns: table => new
                {
                    P9BusinessLossActivityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescriptionOfActivity = table.Column<string>(nullable: true),
                    IndustryCode = table.Column<string>(nullable: true),
                    PartnershipOrSoleTraderOrNone = table.Column<string>(nullable: true),
                    TypeOfLoss = table.Column<string>(nullable: true),
                    ReferenceForCodeFive = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    DeferredNonCommercialLossFromAPriorYear = table.Column<int>(nullable: false),
                    NetLossAmount = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P9BusinessLossActivities", x => x.P9BusinessLossActivityId);
                    table.ForeignKey(
                        name: "FK_P9BusinessLossActivities_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartnershipsAndTrustses",
                columns: table => new
                {
                    PartnershipsAndTrustsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DistributionFromPartnerships = table.Column<int>(nullable: false),
                    IsDistributionProfit = table.Column<bool>(nullable: false),
                    DistributionFromTrusts = table.Column<int>(nullable: false),
                    DistributionFromTrustsCode = table.Column<string>(nullable: true),
                    LandCareOperationsAndDeductionForDeclineInValue = table.Column<int>(nullable: false),
                    OtherDeductionsRelatedToDistribution = table.Column<int>(nullable: false),
                    OtherDeductionCode = table.Column<string>(nullable: true),
                    NonPPDistribution = table.Column<int>(nullable: false),
                    IsNonPPDistributionProfit = table.Column<bool>(nullable: false),
                    NonPPShare = table.Column<int>(nullable: false),
                    IsNonPPShareProfit = table.Column<bool>(nullable: false),
                    NonPPOtherDistribution = table.Column<int>(nullable: false),
                    IsNonPPOtherDistributionProfit = table.Column<bool>(nullable: false),
                    NonPPShareOfNetIncomeFromTrustsLessOthers = table.Column<int>(nullable: false),
                    IsNonPPShareOfNetIncomeFromTrustsLessOthersProfit = table.Column<bool>(nullable: false),
                    DistributionFromTrustsLessNetCGAndFI = table.Column<int>(nullable: false),
                    IsDistributionFromTrustsLessNetCGAndFIProfit = table.Column<bool>(nullable: false),
                    DistributionFromTrustsLessNetCGAndFICode = table.Column<string>(nullable: true),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartnershipsAndTrustses", x => x.PartnershipsAndTrustsId);
                    table.ForeignKey(
                        name: "FK_PartnershipsAndTrustses_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaygSummaries",
                columns: table => new
                {
                    PAYGSummaryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ABN = table.Column<string>(nullable: false),
                    PayerName = table.Column<string>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    TotalTaxWithHeld = table.Column<int>(nullable: false),
                    GrossPayment = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaygSummaries", x => x.PAYGSummaryId);
                    table.ForeignKey(
                        name: "FK_PaygSummaries_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalServiceIncomes",
                columns: table => new
                {
                    PersonalServiceIncomeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaxWithHeldVoluntaryAgreement = table.Column<int>(nullable: false),
                    TaxWithHeldABNNotQuoted = table.Column<int>(nullable: false),
                    TaxWithHeldLabourHireOrOtherSpecifiedPayments = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalServiceIncomes", x => x.PersonalServiceIncomeId);
                    table.ForeignKey(
                        name: "FK_PersonalServiceIncomes_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rent",
                columns: table => new
                {
                    RentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GrossRent = table.Column<int>(nullable: false),
                    InterestDeduction = table.Column<int>(nullable: false),
                    CapitalWorksDeduction = table.Column<int>(nullable: false),
                    OtherRentalDeductions = table.Column<int>(nullable: false),
                    IncomeTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rent", x => x.RentId);
                    table.ForeignKey(
                        name: "FK_Rent_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "A1Under18s",
                columns: table => new
                {
                    A1Under18Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A1Under18s", x => x.A1Under18Id);
                    table.ForeignKey(
                        name: "FK_A1Under18s_OtherItemTypeDetails_OtherItemTypeDetailId",
                        column: x => x.OtherItemTypeDetailId,
                        principalTable: "OtherItemTypeDetails",
                        principalColumn: "OtherItemTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "A2PartYearTaxFreeThresholds",
                columns: table => new
                {
                    A2PartYearTaxFreeThresholdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ThresHoldDate = table.Column<DateTime>(nullable: false),
                    NumberOfMonthsEligible = table.Column<int>(nullable: false),
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A2PartYearTaxFreeThresholds", x => x.A2PartYearTaxFreeThresholdId);
                    table.ForeignKey(
                        name: "FK_A2PartYearTaxFreeThresholds_OtherItemTypeDetails_OtherItemTypeDetailId",
                        column: x => x.OtherItemTypeDetailId,
                        principalTable: "OtherItemTypeDetails",
                        principalColumn: "OtherItemTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "A3SuperCoContributions",
                columns: table => new
                {
                    A3SuperCoContributionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IncomeFromInvestmentPartnershipAndOtherSourcesAmount = table.Column<int>(nullable: false),
                    SuperannuationCoContributionsIndicator = table.Column<string>(nullable: true),
                    OtherIncomeFromEmploymentAndBusiness = table.Column<int>(nullable: false),
                    OtherDeductionsFromBusinessIncome = table.Column<int>(nullable: false),
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A3SuperCoContributions", x => x.A3SuperCoContributionId);
                    table.ForeignKey(
                        name: "FK_A3SuperCoContributions_OtherItemTypeDetails_OtherItemTypeDetailId",
                        column: x => x.OtherItemTypeDetailId,
                        principalTable: "OtherItemTypeDetails",
                        principalColumn: "OtherItemTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "A4WorkingHolidayMakerNetIncomes",
                columns: table => new
                {
                    A4WorkingHolidayMakerNetIncomeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A4WorkingHolidayMakerNetIncomes", x => x.A4WorkingHolidayMakerNetIncomeId);
                    table.ForeignKey(
                        name: "FK_A4WorkingHolidayMakerNetIncomes_OtherItemTypeDetails_OtherItemTypeDetailId",
                        column: x => x.OtherItemTypeDetailId,
                        principalTable: "OtherItemTypeDetails",
                        principalColumn: "OtherItemTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DependencyChildrens",
                columns: table => new
                {
                    DependencyChildrenId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumberOfChildren = table.Column<int>(nullable: false),
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DependencyChildrens", x => x.DependencyChildrenId);
                    table.ForeignKey(
                        name: "FK_DependencyChildrens_OtherItemTypeDetails_OtherItemTypeDetailId",
                        column: x => x.OtherItemTypeDetailId,
                        principalTable: "OtherItemTypeDetails",
                        principalColumn: "OtherItemTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncomeTestses",
                columns: table => new
                {
                    IncomeTestsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IT1Amount = table.Column<int>(nullable: false),
                    IT2Amount = table.Column<int>(nullable: false),
                    IT3Amount = table.Column<int>(nullable: false),
                    IT4Amount = table.Column<int>(nullable: false),
                    IT5Amount = table.Column<int>(nullable: false),
                    IT6Amount = table.Column<int>(nullable: false),
                    IT7Amount = table.Column<int>(nullable: false),
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeTestses", x => x.IncomeTestsId);
                    table.ForeignKey(
                        name: "FK_IncomeTestses_OtherItemTypeDetails_OtherItemTypeDetailId",
                        column: x => x.OtherItemTypeDetailId,
                        principalTable: "OtherItemTypeDetails",
                        principalColumn: "OtherItemTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "L1TaxLossesOfEarlierIncomeYearsClaimedThisIncomeYears",
                columns: table => new
                {
                    L1TaxLossesOfEarlierIncomeYearsClaimedThisIncomeYearId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PrimaryProductionLossesCarriedForwardFromEarlierIncomeYears = table.Column<int>(nullable: false),
                    PrimarProductionLossesClaimedThisIncomeYear = table.Column<int>(nullable: false),
                    NonPrimaryProductionLossesCarriedForwardFromEarlierIncomeYears = table.Column<int>(nullable: false),
                    NonPrimaryProductionLossesCarriedThisIncomeYear = table.Column<int>(nullable: false),
                    TaxableIncomeOrLoss = table.Column<int>(nullable: false),
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L1TaxLossesOfEarlierIncomeYearsClaimedThisIncomeYears", x => x.L1TaxLossesOfEarlierIncomeYearsClaimedThisIncomeYearId);
                    table.ForeignKey(
                        name: "FK_L1TaxLossesOfEarlierIncomeYearsClaimedThisIncomeYears_OtherItemTypeDetails_OtherItemTypeDetailId",
                        column: x => x.OtherItemTypeDetailId,
                        principalTable: "OtherItemTypeDetails",
                        principalColumn: "OtherItemTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M1MedicareLevyReductionOrExemptions",
                columns: table => new
                {
                    M1MedicareLevyReductionOrExemptionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumberOfDependentChildrenAndStudents = table.Column<int>(nullable: false),
                    NumberOfDaysFullLevyExemption = table.Column<int>(nullable: false),
                    NumberOfDaysFullLevyExemptionActionCode = table.Column<string>(nullable: true),
                    NumberOfDaysHalfLevyExemption = table.Column<int>(nullable: false),
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M1MedicareLevyReductionOrExemptions", x => x.M1MedicareLevyReductionOrExemptionId);
                    table.ForeignKey(
                        name: "FK_M1MedicareLevyReductionOrExemptions_OtherItemTypeDetails_OtherItemTypeDetailId",
                        column: x => x.OtherItemTypeDetailId,
                        principalTable: "OtherItemTypeDetails",
                        principalColumn: "OtherItemTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M2MedicareLevSurcharges",
                columns: table => new
                {
                    M2MedicareLevSurchargeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HasPrivateHospitalCoverForWholeYear = table.Column<bool>(nullable: false),
                    IsIncomeBelow90000OrFamilyIncomeBelow180000 = table.Column<bool>(nullable: false),
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M2MedicareLevSurcharges", x => x.M2MedicareLevSurchargeId);
                    table.ForeignKey(
                        name: "FK_M2MedicareLevSurcharges_OtherItemTypeDetails_OtherItemTypeDetailId",
                        column: x => x.OtherItemTypeDetailId,
                        principalTable: "OtherItemTypeDetails",
                        principalColumn: "OtherItemTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrivateHealthInsurancePolicyDetailses",
                columns: table => new
                {
                    PrivateHealthInsurancePolicyDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FamilyStatus = table.Column<string>(nullable: true),
                    IsThisForSpouseOrSelf = table.Column<bool>(nullable: false),
                    HealthInsurerCode = table.Column<string>(nullable: true),
                    MembershipNumber = table.Column<int>(nullable: false),
                    PremiumsEligibleForAustralianGovernmentRebate = table.Column<int>(nullable: false),
                    AustralianGovernmentRebate = table.Column<int>(nullable: false),
                    BenefitCode = table.Column<string>(nullable: true),
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateHealthInsurancePolicyDetailses", x => x.PrivateHealthInsurancePolicyDetailsId);
                    table.ForeignKey(
                        name: "FK_PrivateHealthInsurancePolicyDetailses_OtherItemTypeDetails_OtherItemTypeDetailId",
                        column: x => x.OtherItemTypeDetailId,
                        principalTable: "OtherItemTypeDetails",
                        principalColumn: "OtherItemTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpouseDetailses",
                columns: table => new
                {
                    SpouseDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    OtherGivenNames = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    HasSpouseForFullFY = table.Column<bool>(nullable: false),
                    SpouseTaxableIncome = table.Column<int>(nullable: false),
                    TotalReportableFringeBenefitsAmount = table.Column<int>(nullable: false),
                    FBUnder57A = table.Column<int>(nullable: false),
                    FBNotUnder57A = table.Column<int>(nullable: false),
                    GvernmentPensionsAndAllowance = table.Column<int>(nullable: false),
                    ExemptPensionIncome = table.Column<int>(nullable: false),
                    ReportableSuperContribution = table.Column<int>(nullable: false),
                    TaxFreeGovernmentPension = table.Column<int>(nullable: false),
                    NetInvestmentLoss = table.Column<int>(nullable: false),
                    ChildSupportSpousePaid = table.Column<int>(nullable: false),
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpouseDetailses", x => x.SpouseDetailsId);
                    table.ForeignKey(
                        name: "FK_SpouseDetailses_OtherItemTypeDetails_OtherItemTypeDetailId",
                        column: x => x.OtherItemTypeDetailId,
                        principalTable: "OtherItemTypeDetails",
                        principalColumn: "OtherItemTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T10OtherNonRefundableTaxOffsetses",
                columns: table => new
                {
                    T10OtherNonRefundableTaxOffsetsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaxOffset = table.Column<int>(nullable: false),
                    ActionCode = table.Column<string>(nullable: true),
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T10OtherNonRefundableTaxOffsetses", x => x.T10OtherNonRefundableTaxOffsetsId);
                    table.ForeignKey(
                        name: "FK_T10OtherNonRefundableTaxOffsetses_OtherItemTypeDetails_OtherItemTypeDetailId",
                        column: x => x.OtherItemTypeDetailId,
                        principalTable: "OtherItemTypeDetails",
                        principalColumn: "OtherItemTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T11OtherRefundableTaxOffsetses",
                columns: table => new
                {
                    T11OtherRefundableTaxOffsetsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaxOffSet = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T11OtherRefundableTaxOffsetses", x => x.T11OtherRefundableTaxOffsetsId);
                    table.ForeignKey(
                        name: "FK_T11OtherRefundableTaxOffsetses_OtherItemTypeDetails_OtherItemTypeDetailId",
                        column: x => x.OtherItemTypeDetailId,
                        principalTable: "OtherItemTypeDetails",
                        principalColumn: "OtherItemTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T1SeniorsAndPensionerses",
                columns: table => new
                {
                    T1SeniorsAndPensionersId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SeniorTaxOffsetMaritalStatusCode = table.Column<string>(nullable: true),
                    VeteransOrSpouseOfVeterans = table.Column<string>(nullable: true),
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T1SeniorsAndPensionerses", x => x.T1SeniorsAndPensionersId);
                    table.ForeignKey(
                        name: "FK_T1SeniorsAndPensionerses_OtherItemTypeDetails_OtherItemTypeDetailId",
                        column: x => x.OtherItemTypeDetailId,
                        principalTable: "OtherItemTypeDetails",
                        principalColumn: "OtherItemTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T2AustralianSuperannuationIncomeStreams",
                columns: table => new
                {
                    T2AustralianSuperannuationIncomeStreamId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T2AustralianSuperannuationIncomeStreams", x => x.T2AustralianSuperannuationIncomeStreamId);
                    table.ForeignKey(
                        name: "FK_T2AustralianSuperannuationIncomeStreams_OtherItemTypeDetails_OtherItemTypeDetailId",
                        column: x => x.OtherItemTypeDetailId,
                        principalTable: "OtherItemTypeDetails",
                        principalColumn: "OtherItemTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T3SuperannuationContributionsOnBehalfOfYourSpouses",
                columns: table => new
                {
                    T3SuperannuationContributionsOnBehalfOfYourSpouseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContributionPaid = table.Column<int>(nullable: false),
                    ContributionsOnBehalfOfSpouseTaxOffset = table.Column<int>(nullable: false),
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T3SuperannuationContributionsOnBehalfOfYourSpouses", x => x.T3SuperannuationContributionsOnBehalfOfYourSpouseId);
                    table.ForeignKey(
                        name: "FK_T3SuperannuationContributionsOnBehalfOfYourSpouses_OtherItemTypeDetails_OtherItemTypeDetailId",
                        column: x => x.OtherItemTypeDetailId,
                        principalTable: "OtherItemTypeDetails",
                        principalColumn: "OtherItemTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T4ZoneOrOverseasForceses",
                columns: table => new
                {
                    T4ZoneOrOverseasForcesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    HasLivedInThisAreaMoreThan182Days = table.Column<bool>(nullable: false),
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T4ZoneOrOverseasForceses", x => x.T4ZoneOrOverseasForcesId);
                    table.ForeignKey(
                        name: "FK_T4ZoneOrOverseasForceses_OtherItemTypeDetails_OtherItemTypeDetailId",
                        column: x => x.OtherItemTypeDetailId,
                        principalTable: "OtherItemTypeDetails",
                        principalColumn: "OtherItemTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T6Dependents",
                columns: table => new
                {
                    T6DependentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaxOffSet = table.Column<int>(nullable: false),
                    OtherItemTypeDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T6Dependents", x => x.T6DependentId);
                    table.ForeignKey(
                        name: "FK_T6Dependents_OtherItemTypeDetails_OtherItemTypeDetailId",
                        column: x => x.OtherItemTypeDetailId,
                        principalTable: "OtherItemTypeDetails",
                        principalColumn: "OtherItemTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IITRLodgements",
                columns: table => new
                {
                    IITRLodgementId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LodgementStatus = table.Column<string>(nullable: true),
                    IndividualId = table.Column<int>(nullable: false),
                    MainFormId = table.Column<int>(nullable: false),
                    FinancialYearId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IITRLodgements", x => x.IITRLodgementId);
                    table.ForeignKey(
                        name: "FK_IITRLodgements_FinancialYears_FinancialYearId",
                        column: x => x.FinancialYearId,
                        principalTable: "FinancialYears",
                        principalColumn: "FinancialYearId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IITRLodgements_Individuals_IndividualId",
                        column: x => x.IndividualId,
                        principalTable: "Individuals",
                        principalColumn: "IndividualId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IITRLodgements_MainForms_MainFormId",
                        column: x => x.MainFormId,
                        principalTable: "MainForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NonIndividualPaymentSummary",
                columns: table => new
                {
                    NonIndividualPaymentSummaryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NatureOfIncomeType = table.Column<string>(nullable: true),
                    PayerABNOrWithHoldingPayerNumber = table.Column<string>(nullable: true),
                    TaxWithheld = table.Column<int>(nullable: false),
                    GrossPayment = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    PayerName = table.Column<string>(nullable: true),
                    IncomeTypeDetailId = table.Column<int>(nullable: false),
                    P1PersonalServicesIncomeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonIndividualPaymentSummary", x => x.NonIndividualPaymentSummaryId);
                    table.ForeignKey(
                        name: "FK_NonIndividualPaymentSummary_IncomeTypeDetails_IncomeTypeDetailId",
                        column: x => x.IncomeTypeDetailId,
                        principalTable: "IncomeTypeDetails",
                        principalColumn: "IncomeTypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NonIndividualPaymentSummary_P1PersonalServicesIncomes_P1PersonalServicesIncomeId",
                        column: x => x.P1PersonalServicesIncomeId,
                        principalTable: "P1PersonalServicesIncomes",
                        principalColumn: "P1PersonalServicesIncomeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_A1Under18s_OtherItemTypeDetailId",
                table: "A1Under18s",
                column: "OtherItemTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_A2PartYearTaxFreeThresholds_OtherItemTypeDetailId",
                table: "A2PartYearTaxFreeThresholds",
                column: "OtherItemTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_A3SuperCoContributions_OtherItemTypeDetailId",
                table: "A3SuperCoContributions",
                column: "OtherItemTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_A4WorkingHolidayMakerNetIncomes_OtherItemTypeDetailId",
                table: "A4WorkingHolidayMakerNetIncomes",
                column: "OtherItemTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aaasiss_IncomeTypeDetailId",
                table: "Aaasiss",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Agas_IncomeTypeDetailId",
                table: "Agas",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Agps_IncomeTypeDetailId",
                table: "Agps",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Allowances_IncomeTypeDetailId",
                table: "Allowances",
                column: "IncomeTypeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Apsis_IncomeTypeDetailId",
                table: "Apsis",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aslsps_IncomeTypeDetailId",
                table: "Aslsps",
                column: "IncomeTypeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BankInterests_IncomeTypeDetailId",
                table: "BankInterests",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BasicDetailsForms_MainFormId",
                table: "BasicDetailsForms",
                column: "MainFormId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bflicafss_IncomeTypeDetailId",
                table: "Bflicafss",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Business_UserId",
                table: "Business",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CapitalGainOrLosseses_IncomeTypeDetailId",
                table: "CapitalGainOrLosseses",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComputerLaptopForWorks_DeductionTypeDetailId",
                table: "ComputerLaptopForWorks",
                column: "DeductionTypeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_D10CostOfTaxAffairses_DeductionTypeDetailId",
                table: "D10CostOfTaxAffairses",
                column: "DeductionTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_D11DeductibleAmountOfUndeductedPurchasePriceOfForeignPensionOrAnnuities_DeductionTypeDetailId",
                table: "D11DeductibleAmountOfUndeductedPurchasePriceOfForeignPensionOrAnnuities",
                column: "DeductionTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_D12PersonalSuperannuationContributionses_DeductionTypeDetailId",
                table: "D12PersonalSuperannuationContributionses",
                column: "DeductionTypeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_D13DeductionForProjectPools_DeductionTypeDetailId",
                table: "D13DeductionForProjectPools",
                column: "DeductionTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_D14ForestryManagedInvestmentSchemeDeductions_DeductionTypeDetailId",
                table: "D14ForestryManagedInvestmentSchemeDeductions",
                column: "DeductionTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_D15OtherDeductionses_DeductionTypeDetailId",
                table: "D15OtherDeductionses",
                column: "DeductionTypeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_D1WorkRelatedCarExpenseses_DeductionTypeDetailId",
                table: "D1WorkRelatedCarExpenseses",
                column: "DeductionTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_D2WorkRelatedTravelExpenseses_DeductionTypeDetailId",
                table: "D2WorkRelatedTravelExpenseses",
                column: "DeductionTypeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_D3WorkRelatedUniformClothingLaundryDryCleanings_DeductionTypeDetailId",
                table: "D3WorkRelatedUniformClothingLaundryDryCleanings",
                column: "DeductionTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_D4WorkRelatedSelfEducationExpenseses_DeductionTypeDetailId",
                table: "D4WorkRelatedSelfEducationExpenseses",
                column: "DeductionTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_D9GiftsOrDonationses_DeductionTypeDetailId",
                table: "D9GiftsOrDonationses",
                column: "DeductionTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeductionDetailsForms_MainFormId",
                table: "DeductionDetailsForms",
                column: "MainFormId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeductionTypeDeductionTypeForms_DeductionTypeId",
                table: "DeductionTypeDeductionTypeForms",
                column: "DeductionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DeductionTypeDetails_DeductionDetailsFormId",
                table: "DeductionTypeDetails",
                column: "DeductionDetailsFormId");

            migrationBuilder.CreateIndex(
                name: "IX_DeductionTypeDetails_DeductionTypeId",
                table: "DeductionTypeDetails",
                column: "DeductionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DeductionTypeForms_MainFormId",
                table: "DeductionTypeForms",
                column: "MainFormId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeferredNonCommercialBusinessLosseses_IncomeTypeDetailId",
                table: "DeferredNonCommercialBusinessLosseses",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DependencyChildrens_OtherItemTypeDetailId",
                table: "DependencyChildrens",
                column: "OtherItemTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DividendDeductions_DeductionTypeDetailId",
                table: "DividendDeductions",
                column: "DeductionTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dividendses_IncomeTypeDetailId",
                table: "Dividendses",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Elsps_IncomeTypeDetailId",
                table: "Elsps",
                column: "IncomeTypeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeShareSchemeses_IncomeTypeDetailId",
                table: "EmployeeShareSchemeses",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Etps_IncomeTypeDetailId",
                table: "Etps",
                column: "IncomeTypeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Fmisis_IncomeTypeDetailId",
                table: "Fmisis",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ForeignEntitieses_IncomeTypeDetailId",
                table: "ForeignEntitieses",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ForeignSourceIncomes_IncomeTypeDetailId",
                table: "ForeignSourceIncomes",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HomeOfficeExpenses_DeductionTypeDetailId",
                table: "HomeOfficeExpenses",
                column: "DeductionTypeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeOfficeOccupancyCostses_DeductionTypeDetailId",
                table: "HomeOfficeOccupancyCostses",
                column: "DeductionTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IITRLodgements_FinancialYearId",
                table: "IITRLodgements",
                column: "FinancialYearId");

            migrationBuilder.CreateIndex(
                name: "IX_IITRLodgements_IndividualId",
                table: "IITRLodgements",
                column: "IndividualId");

            migrationBuilder.CreateIndex(
                name: "IX_IITRLodgements_MainFormId",
                table: "IITRLodgements",
                column: "MainFormId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IncomeDetailsForms_MainFormId",
                table: "IncomeDetailsForms",
                column: "MainFormId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IncomeTestses_OtherItemTypeDetailId",
                table: "IncomeTestses",
                column: "OtherItemTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IncomeTypeDetails_IncomeDetailsFormId",
                table: "IncomeTypeDetails",
                column: "IncomeDetailsFormId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeTypeDetails_IncomeTypeId",
                table: "IncomeTypeDetails",
                column: "IncomeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeTypeForms_MainFormId",
                table: "IncomeTypeForms",
                column: "MainFormId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IncomeTypeIncomeTypeForms_IncomeTypeId",
                table: "IncomeTypeIncomeTypeForms",
                column: "IncomeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Individuals_AccountUserId",
                table: "Individuals",
                column: "AccountUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Individuals_BusinessId",
                table: "Individuals",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Individuals_OccupationId",
                table: "Individuals",
                column: "OccupationId");

            migrationBuilder.CreateIndex(
                name: "IX_InterestDeductions_DeductionTypeDetailId",
                table: "InterestDeductions",
                column: "DeductionTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InternetAccessExpenses_DeductionTypeDetailId",
                table: "InternetAccessExpenses",
                column: "DeductionTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_L1TaxLossesOfEarlierIncomeYearsClaimedThisIncomeYears_OtherItemTypeDetailId",
                table: "L1TaxLossesOfEarlierIncomeYearsClaimedThisIncomeYears",
                column: "OtherItemTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LowValuePoolDeductions_DeductionTypeDetailId",
                table: "LowValuePoolDeductions",
                column: "DeductionTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_M1MedicareLevyReductionOrExemptions_OtherItemTypeDetailId",
                table: "M1MedicareLevyReductionOrExemptions",
                column: "OtherItemTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_M2MedicareLevSurcharges_OtherItemTypeDetailId",
                table: "M2MedicareLevSurcharges",
                column: "OtherItemTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MobilePhoneExpenses_DeductionTypeDetailId",
                table: "MobilePhoneExpenses",
                column: "DeductionTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NetFarmManagementDepositOrRepaymentses_IncomeTypeDetailId",
                table: "NetFarmManagementDepositOrRepaymentses",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NetIncomeOrLossFromBusinesses_IncomeTypeDetailId",
                table: "NetIncomeOrLossFromBusinesses",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NonIndividualPaymentSummary_IncomeTypeDetailId",
                table: "NonIndividualPaymentSummary",
                column: "IncomeTypeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndividualPaymentSummary_P1PersonalServicesIncomeId",
                table: "NonIndividualPaymentSummary",
                column: "P1PersonalServicesIncomeId");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationCategoryDeductionTypes_OccupationCategoryId",
                table: "OccupationCategoryDeductionTypes",
                column: "OccupationCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationCategoryIncomeTypes_OccupationCategoryId",
                table: "OccupationCategoryIncomeTypes",
                column: "OccupationCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Occupations_OccupationCategoryId",
                table: "Occupations",
                column: "OccupationCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherIncomes_IncomeTypeDetailId",
                table: "OtherIncomes",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtherItemDetailsForms_MainFormId",
                table: "OtherItemDetailsForms",
                column: "MainFormId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtherItemTypeDetails_OtherItemDetailsFormId",
                table: "OtherItemTypeDetails",
                column: "OtherItemDetailsFormId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherItemTypeDetails_OtherItemTypeId",
                table: "OtherItemTypeDetails",
                column: "OtherItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherItemTypeForms_MainFormId",
                table: "OtherItemTypeForms",
                column: "MainFormId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtherItemTypeOtherItemTypeForms_OtherItemTypeId",
                table: "OtherItemTypeOtherItemTypeForms",
                column: "OtherItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherWorkRelatedExpenseses_DeductionTypeDetailId",
                table: "OtherWorkRelatedExpenseses",
                column: "DeductionTypeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_P10SmallBusinessEntityDepreciatingAssetses_IncomeTypeDetailId",
                table: "P10SmallBusinessEntityDepreciatingAssetses",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_P11TradeDebtorses_IncomeTypeDetailId",
                table: "P11TradeDebtorses",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_P12TradeCreditorses_IncomeTypeDetailId",
                table: "P12TradeCreditorses",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_P13TotalSalaryAndWageExpenseses_IncomeTypeDetailId",
                table: "P13TotalSalaryAndWageExpenseses",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_P14PaymentsToAssociatedPersonses_IncomeTypeDetailId",
                table: "P14PaymentsToAssociatedPersonses",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_P15IntangibleDepreciatingAssetsFirstDeducteds_IncomeTypeDetailId",
                table: "P15IntangibleDepreciatingAssetsFirstDeducteds",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_P16OtherDepreciatingAssetsFirstDeducteds_IncomeTypeDetailId",
                table: "P16OtherDepreciatingAssetsFirstDeducteds",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_P17TerminationValueOfIntangibleDepreciatingAssets_IncomeTypeDetailId",
                table: "P17TerminationValueOfIntangibleDepreciatingAssets",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_P18TerminationValueOfOtherDepreciatingAssetses_IncomeTypeDetailId",
                table: "P18TerminationValueOfOtherDepreciatingAssetses",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_P19TradingStockElections_IncomeTypeDetailId",
                table: "P19TradingStockElections",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_P1PersonalServicesIncomes_IncomeTypeDetailId",
                table: "P1PersonalServicesIncomes",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_P2DescriptionOfMainBusinessOrProfessionalActivities_IncomeTypeDetailId",
                table: "P2DescriptionOfMainBusinessOrProfessionalActivities",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_P4StatusOfBusinesses_IncomeTypeDetailId",
                table: "P4StatusOfBusinesses",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_P5BusinessNameOfMainBusinessAndAbns_IncomeTypeDetailId",
                table: "P5BusinessNameOfMainBusinessAndAbns",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_P7GstByInternets_IncomeTypeDetailId",
                table: "P7GstByInternets",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_P8BusinessIncomeAndExpensesFarmings_IncomeTypeDetailId",
                table: "P8BusinessIncomeAndExpensesFarmings",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_P8BusinessIncomeAndExpensesNonFarmings_IncomeTypeDetailId",
                table: "P8BusinessIncomeAndExpensesNonFarmings",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_P9BusinessLossActivities_IncomeTypeDetailId",
                table: "P9BusinessLossActivities",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ParkAndTollses_DeductionTypeDetailId",
                table: "ParkAndTollses",
                column: "DeductionTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PartnershipsAndTrustses_IncomeTypeDetailId",
                table: "PartnershipsAndTrustses",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PaygSummaries_IncomeTypeDetailId",
                table: "PaygSummaries",
                column: "IncomeTypeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalServiceIncomes_IncomeTypeDetailId",
                table: "PersonalServiceIncomes",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrivateHealthInsurancePolicyDetailses_OtherItemTypeDetailId",
                table: "PrivateHealthInsurancePolicyDetailses",
                column: "OtherItemTypeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Rent_IncomeTypeDetailId",
                table: "Rent",
                column: "IncomeTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SpouseDetailses_OtherItemTypeDetailId",
                table: "SpouseDetailses",
                column: "OtherItemTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SunProtections_DeductionTypeDetailId",
                table: "SunProtections",
                column: "DeductionTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T10OtherNonRefundableTaxOffsetses_OtherItemTypeDetailId",
                table: "T10OtherNonRefundableTaxOffsetses",
                column: "OtherItemTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T11OtherRefundableTaxOffsetses_OtherItemTypeDetailId",
                table: "T11OtherRefundableTaxOffsetses",
                column: "OtherItemTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T1SeniorsAndPensionerses_OtherItemTypeDetailId",
                table: "T1SeniorsAndPensionerses",
                column: "OtherItemTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T2AustralianSuperannuationIncomeStreams_OtherItemTypeDetailId",
                table: "T2AustralianSuperannuationIncomeStreams",
                column: "OtherItemTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T3SuperannuationContributionsOnBehalfOfYourSpouses_OtherItemTypeDetailId",
                table: "T3SuperannuationContributionsOnBehalfOfYourSpouses",
                column: "OtherItemTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T4ZoneOrOverseasForceses_OtherItemTypeDetailId",
                table: "T4ZoneOrOverseasForceses",
                column: "OtherItemTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T6Dependents_OtherItemTypeDetailId",
                table: "T6Dependents",
                column: "OtherItemTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaxCompliances_FinancialYearId",
                table: "TaxCompliances",
                column: "FinancialYearId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRates_FinancialYearId",
                table: "TaxRates",
                column: "FinancialYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Thresholds_TaxComplianceId",
                table: "Thresholds",
                column: "TaxComplianceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ToolAndEquipments_DeductionTypeDetailId",
                table: "ToolAndEquipments",
                column: "DeductionTypeDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UnionFeeses_DeductionTypeDetailId",
                table: "UnionFeeses",
                column: "DeductionTypeDetailId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "A1Under18s");

            migrationBuilder.DropTable(
                name: "A2PartYearTaxFreeThresholds");

            migrationBuilder.DropTable(
                name: "A3SuperCoContributions");

            migrationBuilder.DropTable(
                name: "A4WorkingHolidayMakerNetIncomes");

            migrationBuilder.DropTable(
                name: "Aaasiss");

            migrationBuilder.DropTable(
                name: "Agas");

            migrationBuilder.DropTable(
                name: "Agps");

            migrationBuilder.DropTable(
                name: "Allowances");

            migrationBuilder.DropTable(
                name: "Apsis");

            migrationBuilder.DropTable(
                name: "Aslsps");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BankInterests");

            migrationBuilder.DropTable(
                name: "BasicDetailsForms");

            migrationBuilder.DropTable(
                name: "Bflicafss");

            migrationBuilder.DropTable(
                name: "CapitalGainOrLosseses");

            migrationBuilder.DropTable(
                name: "ComputerLaptopForWorks");

            migrationBuilder.DropTable(
                name: "D10CostOfTaxAffairses");

            migrationBuilder.DropTable(
                name: "D11DeductibleAmountOfUndeductedPurchasePriceOfForeignPensionOrAnnuities");

            migrationBuilder.DropTable(
                name: "D12PersonalSuperannuationContributionses");

            migrationBuilder.DropTable(
                name: "D13DeductionForProjectPools");

            migrationBuilder.DropTable(
                name: "D14ForestryManagedInvestmentSchemeDeductions");

            migrationBuilder.DropTable(
                name: "D15OtherDeductionses");

            migrationBuilder.DropTable(
                name: "D1WorkRelatedCarExpenseses");

            migrationBuilder.DropTable(
                name: "D2WorkRelatedTravelExpenseses");

            migrationBuilder.DropTable(
                name: "D3WorkRelatedUniformClothingLaundryDryCleanings");

            migrationBuilder.DropTable(
                name: "D4WorkRelatedSelfEducationExpenseses");

            migrationBuilder.DropTable(
                name: "D9GiftsOrDonationses");

            migrationBuilder.DropTable(
                name: "DeductionTypeDeductionTypeForms");

            migrationBuilder.DropTable(
                name: "DeferredNonCommercialBusinessLosseses");

            migrationBuilder.DropTable(
                name: "DependencyChildrens");

            migrationBuilder.DropTable(
                name: "DividendDeductions");

            migrationBuilder.DropTable(
                name: "Dividendses");

            migrationBuilder.DropTable(
                name: "Elsps");

            migrationBuilder.DropTable(
                name: "EmployeeShareSchemeses");

            migrationBuilder.DropTable(
                name: "Etps");

            migrationBuilder.DropTable(
                name: "Fmisis");

            migrationBuilder.DropTable(
                name: "ForeignEntitieses");

            migrationBuilder.DropTable(
                name: "ForeignSourceIncomes");

            migrationBuilder.DropTable(
                name: "HomeOfficeExpenses");

            migrationBuilder.DropTable(
                name: "HomeOfficeOccupancyCostses");

            migrationBuilder.DropTable(
                name: "IITRLodgements");

            migrationBuilder.DropTable(
                name: "IncomeTestses");

            migrationBuilder.DropTable(
                name: "IncomeTypeIncomeTypeForms");

            migrationBuilder.DropTable(
                name: "InterestDeductions");

            migrationBuilder.DropTable(
                name: "InternetAccessExpenses");

            migrationBuilder.DropTable(
                name: "L1TaxLossesOfEarlierIncomeYearsClaimedThisIncomeYears");

            migrationBuilder.DropTable(
                name: "LowValuePoolDeductions");

            migrationBuilder.DropTable(
                name: "M1MedicareLevyReductionOrExemptions");

            migrationBuilder.DropTable(
                name: "M2MedicareLevSurcharges");

            migrationBuilder.DropTable(
                name: "MobilePhoneExpenses");

            migrationBuilder.DropTable(
                name: "NetFarmManagementDepositOrRepaymentses");

            migrationBuilder.DropTable(
                name: "NetIncomeOrLossFromBusinesses");

            migrationBuilder.DropTable(
                name: "NonIndividualPaymentSummary");

            migrationBuilder.DropTable(
                name: "OccupationCategoryDeductionTypes");

            migrationBuilder.DropTable(
                name: "OccupationCategoryIncomeTypes");

            migrationBuilder.DropTable(
                name: "OtherIncomes");

            migrationBuilder.DropTable(
                name: "OtherItemTypeOtherItemTypeForms");

            migrationBuilder.DropTable(
                name: "OtherWorkRelatedExpenseses");

            migrationBuilder.DropTable(
                name: "P10SmallBusinessEntityDepreciatingAssetses");

            migrationBuilder.DropTable(
                name: "P11TradeDebtorses");

            migrationBuilder.DropTable(
                name: "P12TradeCreditorses");

            migrationBuilder.DropTable(
                name: "P13TotalSalaryAndWageExpenseses");

            migrationBuilder.DropTable(
                name: "P14PaymentsToAssociatedPersonses");

            migrationBuilder.DropTable(
                name: "P15IntangibleDepreciatingAssetsFirstDeducteds");

            migrationBuilder.DropTable(
                name: "P16OtherDepreciatingAssetsFirstDeducteds");

            migrationBuilder.DropTable(
                name: "P17TerminationValueOfIntangibleDepreciatingAssets");

            migrationBuilder.DropTable(
                name: "P18TerminationValueOfOtherDepreciatingAssetses");

            migrationBuilder.DropTable(
                name: "P19TradingStockElections");

            migrationBuilder.DropTable(
                name: "P2DescriptionOfMainBusinessOrProfessionalActivities");

            migrationBuilder.DropTable(
                name: "P4StatusOfBusinesses");

            migrationBuilder.DropTable(
                name: "P5BusinessNameOfMainBusinessAndAbns");

            migrationBuilder.DropTable(
                name: "P7GstByInternets");

            migrationBuilder.DropTable(
                name: "P8BusinessIncomeAndExpensesFarmings");

            migrationBuilder.DropTable(
                name: "P8BusinessIncomeAndExpensesNonFarmings");

            migrationBuilder.DropTable(
                name: "P9BusinessLossActivities");

            migrationBuilder.DropTable(
                name: "ParkAndTollses");

            migrationBuilder.DropTable(
                name: "PartnershipsAndTrustses");

            migrationBuilder.DropTable(
                name: "PaygSummaries");

            migrationBuilder.DropTable(
                name: "PersonalServiceIncomes");

            migrationBuilder.DropTable(
                name: "PrivateHealthInsurancePolicyDetailses");

            migrationBuilder.DropTable(
                name: "Rent");

            migrationBuilder.DropTable(
                name: "SpouseDetailses");

            migrationBuilder.DropTable(
                name: "SunProtections");

            migrationBuilder.DropTable(
                name: "T10OtherNonRefundableTaxOffsetses");

            migrationBuilder.DropTable(
                name: "T11OtherRefundableTaxOffsetses");

            migrationBuilder.DropTable(
                name: "T1SeniorsAndPensionerses");

            migrationBuilder.DropTable(
                name: "T2AustralianSuperannuationIncomeStreams");

            migrationBuilder.DropTable(
                name: "T3SuperannuationContributionsOnBehalfOfYourSpouses");

            migrationBuilder.DropTable(
                name: "T4ZoneOrOverseasForceses");

            migrationBuilder.DropTable(
                name: "T6Dependents");

            migrationBuilder.DropTable(
                name: "TaxRates");

            migrationBuilder.DropTable(
                name: "Thresholds");

            migrationBuilder.DropTable(
                name: "ToolAndEquipments");

            migrationBuilder.DropTable(
                name: "UnionFeeses");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "DeductionTypeForms");

            migrationBuilder.DropTable(
                name: "Individuals");

            migrationBuilder.DropTable(
                name: "IncomeTypeForms");

            migrationBuilder.DropTable(
                name: "P1PersonalServicesIncomes");

            migrationBuilder.DropTable(
                name: "OtherItemTypeForms");

            migrationBuilder.DropTable(
                name: "OtherItemTypeDetails");

            migrationBuilder.DropTable(
                name: "TaxCompliances");

            migrationBuilder.DropTable(
                name: "DeductionTypeDetails");

            migrationBuilder.DropTable(
                name: "Business");

            migrationBuilder.DropTable(
                name: "Occupations");

            migrationBuilder.DropTable(
                name: "IncomeTypeDetails");

            migrationBuilder.DropTable(
                name: "OtherItemDetailsForms");

            migrationBuilder.DropTable(
                name: "OtherItemTypes");

            migrationBuilder.DropTable(
                name: "FinancialYears");

            migrationBuilder.DropTable(
                name: "DeductionDetailsForms");

            migrationBuilder.DropTable(
                name: "DeductionTypes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "OccupationCategories");

            migrationBuilder.DropTable(
                name: "IncomeDetailsForms");

            migrationBuilder.DropTable(
                name: "IncomeTypes");

            migrationBuilder.DropTable(
                name: "MainForms");
        }
    }
}
