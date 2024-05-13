using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidasDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initializeDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "FileManagements",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Path = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
            //        Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__FileMana__3214EC074EBF133F", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AssociateUserBranches",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        UserId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        BranchOfficeId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Associat__3214EC074CF4ADD5", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Banks",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        DeletedAt = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Banks__3214EC073E0B7FAD", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "BranchOffices",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        OfficeName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        OfficeCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
            //        Address = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        PostalCodeId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        DeletedAt = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__BranchOf__3214EC07754AD330", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "BusinessOwnerDetails",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        IdentityNumber = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
            //        EmployeeIdentityNumber = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
            //        FullName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Position = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        PhoneNumber = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
            //        CompanyId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Business__3214EC07B6A1C06A", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "BusinessSectors",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        DeletedAt = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Business__3214EC07B146A0B6", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Cities",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        ProvinceId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        DeletedAt = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Cities__3214EC078ECFC12C", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CompanyAssets",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        Value = table.Column<decimal>(type: "money", nullable: false),
            //        CompanyId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__CompanyA__3214EC0788905132", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CompanyCredits",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreditApplicationNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        NPWP = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
            //        CompanyName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
            //        CompanyType = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
            //        PlaceOfEstasblishment = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        EstablishRegistrationNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
            //        EstablishRegistrationDate = table.Column<DateOnly>(type: "date", nullable: false),
            //        CompanyRegistrationNumber = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: false),
            //        Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        PhoneNumber = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
            //        Address = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
            //        PostalCodeId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CompanyOwnerId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        BranchOfficeId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        ApplicationAmount = table.Column<decimal>(type: "money", nullable: false),
            //        ApplicationPeriod = table.Column<int>(type: "int", nullable: false),
            //        ApplicationDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        CreditEndDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Status = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
            //        Notes = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
            //        EstablishRegistrationNumberFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CompanyRegistrationNumberFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        NPWPFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        IdentityNumberFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        BoardOfManagementFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        FinancialStatementFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        DeletedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        VerifiedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        VerifiedAt = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__CompanyC__3214EC07AE1E45A9", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK__CompanyCr__Board__07C12930",
            //            column: x => x.BoardOfManagementFile,
            //            principalTable: "FileManagements",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__CompanyCr__Branc__02FC7413",
            //            column: x => x.BranchOfficeId,
            //            principalTable: "BranchOffices",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__CompanyCr__Compa__04E4BC85",
            //            column: x => x.CompanyRegistrationNumberFile,
            //            principalTable: "FileManagements",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__CompanyCr__Estab__03F0984C",
            //            column: x => x.EstablishRegistrationNumberFile,
            //            principalTable: "FileManagements",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__CompanyCr__Finan__08B54D69",
            //            column: x => x.FinancialStatementFile,
            //            principalTable: "FileManagements",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__CompanyCr__Ident__06CD04F7",
            //            column: x => x.IdentityNumberFile,
            //            principalTable: "FileManagements",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__CompanyCr__NPWPF__05D8E0BE",
            //            column: x => x.NPWPFile,
            //            principalTable: "FileManagements",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CreditPayments",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        PaymentBilling = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        PaymentDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Status = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
            //        Notes = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
            //        IndividualCreditId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        CompanyCreditId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        ReceiptFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        DeletedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        VerifiedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        VerifiedAt = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__CreditPa__3214EC075A0D5231", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK__CreditPay__Compa__17F790F9",
            //            column: x => x.CompanyCreditId,
            //            principalTable: "CompanyCredits",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__CreditPay__Recei__18EBB532",
            //            column: x => x.ReceiptFile,
            //            principalTable: "FileManagements",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CreditUpgrades",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        UserId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreditUpgradeNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        MonthlyIncome = table.Column<decimal>(type: "money", nullable: false),
            //        AnnualBusinessGross = table.Column<decimal>(type: "money", nullable: false),
            //        ProfitBusinessGross = table.Column<decimal>(type: "money", nullable: false),
            //        Status = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
            //        Notes = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
            //        FinancialStatementFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        DeletedAt = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__CreditUp__3214EC070C13F416", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK__CreditUpg__Finan__2CF2ADDF",
            //            column: x => x.FinancialStatementFile,
            //            principalTable: "FileManagements",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EmergencyContacts",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        PhoneNumber = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
            //        IndividualCreditId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        Relative = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Emergenc__3214EC0771E679C6", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "IndividualCredits",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreditApplicationNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        UserId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        FamilyCardNumber = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
            //        Address = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
            //        PostalCodeId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        BusinessSectorId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        BusinessAddress = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
            //        BusinessPhoneNumber = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
            //        BusinessPeriod = table.Column<int>(type: "int", nullable: false),
            //        BusinessPlaceStatus = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
            //        TotalEmployee = table.Column<int>(type: "int", nullable: false),
            //        BusinessPostalCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        BranchOfficeId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        ApplicationAmount = table.Column<decimal>(type: "money", nullable: false),
            //        ApplicationPeriod = table.Column<int>(type: "int", nullable: false),
            //        ApplicationDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        CreditStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        CreditEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Status = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        Note = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
            //        DomicileFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        IdentityCardFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        IdentityCardSelfieFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        FamilyCardFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        BusinessCertificateFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        DeletedAt = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Individu__3214EC07B8A14867", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK__Individua__Branc__71D1E811",
            //            column: x => x.BranchOfficeId,
            //            principalTable: "BranchOffices",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Individua__Busin__6FE99F9F",
            //            column: x => x.BusinessSectorId,
            //            principalTable: "BusinessSectors",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Individua__Busin__76969D2E",
            //            column: x => x.BusinessCertificateFile,
            //            principalTable: "FileManagements",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Individua__Domic__72C60C4A",
            //            column: x => x.DomicileFile,
            //            principalTable: "FileManagements",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Individua__Famil__75A278F5",
            //            column: x => x.FamilyCardFile,
            //            principalTable: "FileManagements",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Individua__Ident__73BA3083",
            //            column: x => x.IdentityCardFile,
            //            principalTable: "FileManagements",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Individua__Ident__74AE54BC",
            //            column: x => x.IdentityCardSelfieFile,
            //            principalTable: "FileManagements",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PostalCodes",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        PostalCode = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
            //        VillageId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        DeletedAt = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__PostalCo__3214EC0744B4C17E", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Provinces",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        DeletedAt = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Province__3214EC07115CA759", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Roles",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        DeletedAt = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Roles__3214EC077DFD2452", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        Password = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
            //        FullName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        NickName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        IdentityNumber = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
            //        Gender = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
            //        BirthPlace = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
            //        PhoneNumber = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
            //        CreditScore = table.Column<int>(type: "int", nullable: false),
            //        PersonalCreditLimit = table.Column<decimal>(type: "money", nullable: true),
            //        CompanyCreditLimit = table.Column<decimal>(type: "money", nullable: true),
            //        RegistrationDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
            //        RoleId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        DeletedAt = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Users__3214EC0779B1C58E", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK__Users__CreatedBy__2B3F6F97",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Users__DeletedBy__2E1BDC42",
            //            column: x => x.DeletedBy,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Users__RoleId__2A4B4B5E",
            //            column: x => x.RoleId,
            //            principalTable: "Roles",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Users__UpdatedBy__2D27B809",
            //            column: x => x.UpdatedBy,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SubDistricts",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        CityId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        DeletedAt = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__SubDistr__3214EC073B248931", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK__SubDistri__CityI__403A8C7D",
            //            column: x => x.CityId,
            //            principalTable: "Cities",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__SubDistri__Creat__412EB0B6",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__SubDistri__Delet__440B1D61",
            //            column: x => x.DeletedBy,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__SubDistri__Updat__4316F928",
            //            column: x => x.UpdatedBy,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Withdrawals",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        BankId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        AccountNumber = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
            //        AccountName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        Status = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
            //        Notes = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
            //        IndividualCreditId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        CompanyCreditId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        ReceiptFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        DeletedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        VerifiedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        VerifiedAt = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Withdraw__3214EC073C477D25", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK__Withdrawa__BankI__208CD6FA",
            //            column: x => x.BankId,
            //            principalTable: "Banks",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Withdrawa__Compa__22751F6C",
            //            column: x => x.CompanyCreditId,
            //            principalTable: "CompanyCredits",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Withdrawa__Creat__245D67DE",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Withdrawa__Delet__2739D489",
            //            column: x => x.DeletedBy,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Withdrawa__Indiv__2180FB33",
            //            column: x => x.IndividualCreditId,
            //            principalTable: "IndividualCredits",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Withdrawa__Recei__236943A5",
            //            column: x => x.ReceiptFile,
            //            principalTable: "FileManagements",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Withdrawa__Updat__2645B050",
            //            column: x => x.UpdatedBy,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Withdrawa__Verif__282DF8C2",
            //            column: x => x.VerifiedBy,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Villages",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        SubDistrictId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        DeletedAt = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Villages__3214EC07FF9CFCDC", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK__Villages__Create__47DBAE45",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Villages__Delete__4AB81AF0",
            //            column: x => x.DeletedBy,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Villages__SubDis__46E78A0C",
            //            column: x => x.SubDistrictId,
            //            principalTable: "SubDistricts",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Villages__Update__49C3F6B7",
            //            column: x => x.UpdatedBy,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_AssociateUserBranches_BranchOfficeId",
            //    table: "AssociateUserBranches",
            //    column: "BranchOfficeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AssociateUserBranches_UserId",
            //    table: "AssociateUserBranches",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Banks_CreatedBy",
            //    table: "Banks",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Banks_DeletedBy",
            //    table: "Banks",
            //    column: "DeletedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Banks_UpdatedBy",
            //    table: "Banks",
            //    column: "UpdatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_BranchOffices_CreatedBy",
            //    table: "BranchOffices",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_BranchOffices_DeletedBy",
            //    table: "BranchOffices",
            //    column: "DeletedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_BranchOffices_PostalCodeId",
            //    table: "BranchOffices",
            //    column: "PostalCodeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_BranchOffices_UpdatedBy",
            //    table: "BranchOffices",
            //    column: "UpdatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__BranchOf__16F536C6D42E8226",
            //    table: "BranchOffices",
            //    column: "OfficeCode",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_BusinessOwnerDetails_CompanyId",
            //    table: "BusinessOwnerDetails",
            //    column: "CompanyId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_BusinessSectors_CreatedBy",
            //    table: "BusinessSectors",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_BusinessSectors_DeletedBy",
            //    table: "BusinessSectors",
            //    column: "DeletedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_BusinessSectors_UpdatedBy",
            //    table: "BusinessSectors",
            //    column: "UpdatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cities_CreatedBy",
            //    table: "Cities",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cities_DeletedBy",
            //    table: "Cities",
            //    column: "DeletedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cities_ProvinceId",
            //    table: "Cities",
            //    column: "ProvinceId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cities_UpdatedBy",
            //    table: "Cities",
            //    column: "UpdatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CompanyAssets_CompanyId",
            //    table: "CompanyAssets",
            //    column: "CompanyId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CompanyCredits_BoardOfManagementFile",
            //    table: "CompanyCredits",
            //    column: "BoardOfManagementFile");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CompanyCredits_BranchOfficeId",
            //    table: "CompanyCredits",
            //    column: "BranchOfficeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CompanyCredits_CompanyOwnerId",
            //    table: "CompanyCredits",
            //    column: "CompanyOwnerId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CompanyCredits_CompanyRegistrationNumberFile",
            //    table: "CompanyCredits",
            //    column: "CompanyRegistrationNumberFile");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CompanyCredits_CreatedBy",
            //    table: "CompanyCredits",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CompanyCredits_DeletedBy",
            //    table: "CompanyCredits",
            //    column: "DeletedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CompanyCredits_EstablishRegistrationNumberFile",
            //    table: "CompanyCredits",
            //    column: "EstablishRegistrationNumberFile");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CompanyCredits_FinancialStatementFile",
            //    table: "CompanyCredits",
            //    column: "FinancialStatementFile");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CompanyCredits_IdentityNumberFile",
            //    table: "CompanyCredits",
            //    column: "IdentityNumberFile");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CompanyCredits_NPWPFile",
            //    table: "CompanyCredits",
            //    column: "NPWPFile");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CompanyCredits_PostalCodeId",
            //    table: "CompanyCredits",
            //    column: "PostalCodeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CompanyCredits_UpdatedBy",
            //    table: "CompanyCredits",
            //    column: "UpdatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CompanyCredits_VerifiedBy",
            //    table: "CompanyCredits",
            //    column: "VerifiedBy");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__CompanyC__5473C74C9619A32C",
            //    table: "CompanyCredits",
            //    column: "CreditApplicationNumber",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__CompanyC__E542917DCD57F910",
            //    table: "CompanyCredits",
            //    column: "NPWP",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_CreditPayments_CompanyCreditId",
            //    table: "CreditPayments",
            //    column: "CompanyCreditId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CreditPayments_CreatedBy",
            //    table: "CreditPayments",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CreditPayments_DeletedBy",
            //    table: "CreditPayments",
            //    column: "DeletedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CreditPayments_IndividualCreditId",
            //    table: "CreditPayments",
            //    column: "IndividualCreditId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CreditPayments_ReceiptFile",
            //    table: "CreditPayments",
            //    column: "ReceiptFile");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CreditPayments_UpdatedBy",
            //    table: "CreditPayments",
            //    column: "UpdatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CreditPayments_VerifiedBy",
            //    table: "CreditPayments",
            //    column: "VerifiedBy");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__CreditPa__5F8E21DE1FCC2FB3",
            //    table: "CreditPayments",
            //    column: "PaymentBilling",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_CreditUpgrades_CreatedBy",
            //    table: "CreditUpgrades",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CreditUpgrades_DeletedBy",
            //    table: "CreditUpgrades",
            //    column: "DeletedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CreditUpgrades_FinancialStatementFile",
            //    table: "CreditUpgrades",
            //    column: "FinancialStatementFile");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CreditUpgrades_UpdatedBy",
            //    table: "CreditUpgrades",
            //    column: "UpdatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CreditUpgrades_UserId",
            //    table: "CreditUpgrades",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__CreditUp__6FC6D8937441A792",
            //    table: "CreditUpgrades",
            //    column: "CreditUpgradeNumber",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_EmergencyContacts_IndividualCreditId",
            //    table: "EmergencyContacts",
            //    column: "IndividualCreditId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IndividualCredits_BranchOfficeId",
            //    table: "IndividualCredits",
            //    column: "BranchOfficeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IndividualCredits_BusinessCertificateFile",
            //    table: "IndividualCredits",
            //    column: "BusinessCertificateFile");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IndividualCredits_BusinessPostalCode",
            //    table: "IndividualCredits",
            //    column: "BusinessPostalCode");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IndividualCredits_BusinessSectorId",
            //    table: "IndividualCredits",
            //    column: "BusinessSectorId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IndividualCredits_CreatedBy",
            //    table: "IndividualCredits",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IndividualCredits_DeletedBy",
            //    table: "IndividualCredits",
            //    column: "DeletedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IndividualCredits_DomicileFile",
            //    table: "IndividualCredits",
            //    column: "DomicileFile");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IndividualCredits_FamilyCardFile",
            //    table: "IndividualCredits",
            //    column: "FamilyCardFile");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IndividualCredits_IdentityCardFile",
            //    table: "IndividualCredits",
            //    column: "IdentityCardFile");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IndividualCredits_IdentityCardSelfieFile",
            //    table: "IndividualCredits",
            //    column: "IdentityCardSelfieFile");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IndividualCredits_PostalCodeId",
            //    table: "IndividualCredits",
            //    column: "PostalCodeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IndividualCredits_UpdatedBy",
            //    table: "IndividualCredits",
            //    column: "UpdatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IndividualCredits_UserId",
            //    table: "IndividualCredits",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Individu__5473C74C2A8121B5",
            //    table: "IndividualCredits",
            //    column: "CreditApplicationNumber",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_PostalCodes_CreatedBy",
            //    table: "PostalCodes",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PostalCodes_DeletedBy",
            //    table: "PostalCodes",
            //    column: "DeletedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PostalCodes_UpdatedBy",
            //    table: "PostalCodes",
            //    column: "UpdatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PostalCodes_VillageId",
            //    table: "PostalCodes",
            //    column: "VillageId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Provinces_CreatedBy",
            //    table: "Provinces",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Provinces_DeletedBy",
            //    table: "Provinces",
            //    column: "DeletedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Provinces_UpdatedBy",
            //    table: "Provinces",
            //    column: "UpdatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Roles_CreatedBy",
            //    table: "Roles",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Roles_DeletedBy",
            //    table: "Roles",
            //    column: "DeletedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Roles_UpdatedBy",
            //    table: "Roles",
            //    column: "UpdatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SubDistricts_CityId",
            //    table: "SubDistricts",
            //    column: "CityId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SubDistricts_CreatedBy",
            //    table: "SubDistricts",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SubDistricts_DeletedBy",
            //    table: "SubDistricts",
            //    column: "DeletedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SubDistricts_UpdatedBy",
            //    table: "SubDistricts",
            //    column: "UpdatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Users_CreatedBy",
            //    table: "Users",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Users_DeletedBy",
            //    table: "Users",
            //    column: "DeletedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Users_RoleId",
            //    table: "Users",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Users_UpdatedBy",
            //    table: "Users",
            //    column: "UpdatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Users__6354A73FEFBA1441",
            //    table: "Users",
            //    column: "IdentityNumber",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Users__A9D10534726D34FB",
            //    table: "Users",
            //    column: "Email",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Villages_CreatedBy",
            //    table: "Villages",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Villages_DeletedBy",
            //    table: "Villages",
            //    column: "DeletedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Villages_SubDistrictId",
            //    table: "Villages",
            //    column: "SubDistrictId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Villages_UpdatedBy",
            //    table: "Villages",
            //    column: "UpdatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Withdrawals_BankId",
            //    table: "Withdrawals",
            //    column: "BankId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Withdrawals_CompanyCreditId",
            //    table: "Withdrawals",
            //    column: "CompanyCreditId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Withdrawals_CreatedBy",
            //    table: "Withdrawals",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Withdrawals_DeletedBy",
            //    table: "Withdrawals",
            //    column: "DeletedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Withdrawals_IndividualCreditId",
            //    table: "Withdrawals",
            //    column: "IndividualCreditId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Withdrawals_ReceiptFile",
            //    table: "Withdrawals",
            //    column: "ReceiptFile");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Withdrawals_UpdatedBy",
            //    table: "Withdrawals",
            //    column: "UpdatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Withdrawals_VerifiedBy",
            //    table: "Withdrawals",
            //    column: "VerifiedBy");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Associate__Branc__628FA481",
            //    table: "AssociateUserBranches",
            //    column: "BranchOfficeId",
            //    principalTable: "BranchOffices",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Associate__UserI__619B8048",
            //    table: "AssociateUserBranches",
            //    column: "UserId",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Banks__CreatedBy__5441852A",
            //    table: "Banks",
            //    column: "CreatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Banks__DeletedBy__571DF1D5",
            //    table: "Banks",
            //    column: "DeletedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Banks__UpdatedBy__5629CD9C",
            //    table: "Banks",
            //    column: "UpdatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__BranchOff__Creat__5BE2A6F2",
            //    table: "BranchOffices",
            //    column: "CreatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__BranchOff__Delet__5EBF139D",
            //    table: "BranchOffices",
            //    column: "DeletedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__BranchOff__Updat__5DCAEF64",
            //    table: "BranchOffices",
            //    column: "UpdatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__BranchOff__Posta__5AEE82B9",
            //    table: "BranchOffices",
            //    column: "PostalCodeId",
            //    principalTable: "PostalCodes",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__BusinessO__Compa__10566F31",
            //    table: "BusinessOwnerDetails",
            //    column: "CompanyId",
            //    principalTable: "CompanyCredits",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__BusinessS__Creat__656C112C",
            //    table: "BusinessSectors",
            //    column: "CreatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__BusinessS__Delet__68487DD7",
            //    table: "BusinessSectors",
            //    column: "DeletedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__BusinessS__Updat__6754599E",
            //    table: "BusinessSectors",
            //    column: "UpdatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Cities__CreatedB__3A81B327",
            //    table: "Cities",
            //    column: "CreatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Cities__DeletedB__3D5E1FD2",
            //    table: "Cities",
            //    column: "DeletedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Cities__UpdatedB__3C69FB99",
            //    table: "Cities",
            //    column: "UpdatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Cities__Province__398D8EEE",
            //    table: "Cities",
            //    column: "ProvinceId",
            //    principalTable: "Provinces",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__CompanyAs__Compa__1332DBDC",
            //    table: "CompanyAssets",
            //    column: "CompanyId",
            //    principalTable: "CompanyCredits",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__CompanyCr__Compa__02084FDA",
            //    table: "CompanyCredits",
            //    column: "CompanyOwnerId",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__CompanyCr__Creat__09A971A2",
            //    table: "CompanyCredits",
            //    column: "CreatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__CompanyCr__Delet__0C85DE4D",
            //    table: "CompanyCredits",
            //    column: "DeletedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__CompanyCr__Updat__0B91BA14",
            //    table: "CompanyCredits",
            //    column: "UpdatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__CompanyCr__Verif__0D7A0286",
            //    table: "CompanyCredits",
            //    column: "VerifiedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__CompanyCr__Posta__01142BA1",
            //    table: "CompanyCredits",
            //    column: "PostalCodeId",
            //    principalTable: "PostalCodes",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__CreditPay__Creat__19DFD96B",
            //    table: "CreditPayments",
            //    column: "CreatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__CreditPay__Delet__1CBC4616",
            //    table: "CreditPayments",
            //    column: "DeletedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__CreditPay__Updat__1BC821DD",
            //    table: "CreditPayments",
            //    column: "UpdatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__CreditPay__Verif__1DB06A4F",
            //    table: "CreditPayments",
            //    column: "VerifiedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__CreditPay__Indiv__17036CC0",
            //    table: "CreditPayments",
            //    column: "IndividualCreditId",
            //    principalTable: "IndividualCredits",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__CreditUpg__Creat__2DE6D218",
            //    table: "CreditUpgrades",
            //    column: "CreatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__CreditUpg__Delet__30C33EC3",
            //    table: "CreditUpgrades",
            //    column: "DeletedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__CreditUpg__Updat__2FCF1A8A",
            //    table: "CreditUpgrades",
            //    column: "UpdatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__CreditUpg__UserI__2BFE89A6",
            //    table: "CreditUpgrades",
            //    column: "UserId",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Emergency__Indiv__31B762FC",
            //    table: "EmergencyContacts",
            //    column: "IndividualCreditId",
            //    principalTable: "IndividualCredits",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Individua__Busin__70DDC3D8",
            //    table: "IndividualCredits",
            //    column: "BusinessPostalCode",
            //    principalTable: "PostalCodes",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Individua__Posta__6EF57B66",
            //    table: "IndividualCredits",
            //    column: "PostalCodeId",
            //    principalTable: "PostalCodes",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Individua__Creat__778AC167",
            //    table: "IndividualCredits",
            //    column: "CreatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Individua__Delet__7A672E12",
            //    table: "IndividualCredits",
            //    column: "DeletedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Individua__Updat__797309D9",
            //    table: "IndividualCredits",
            //    column: "UpdatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Individua__UserI__6E01572D",
            //    table: "IndividualCredits",
            //    column: "UserId",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__PostalCod__Creat__4E88ABD4",
            //    table: "PostalCodes",
            //    column: "CreatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__PostalCod__Delet__5165187F",
            //    table: "PostalCodes",
            //    column: "DeletedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__PostalCod__Updat__5070F446",
            //    table: "PostalCodes",
            //    column: "UpdatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__PostalCod__Villa__4D94879B",
            //    table: "PostalCodes",
            //    column: "VillageId",
            //    principalTable: "Villages",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Provinces__Creat__33D4B598",
            //    table: "Provinces",
            //    column: "CreatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Provinces__Delet__36B12243",
            //    table: "Provinces",
            //    column: "DeletedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Provinces__Updat__35BCFE0A",
            //    table: "Provinces",
            //    column: "UpdatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Roles__CreatedBy__2F10007B",
            //    table: "Roles",
            //    column: "CreatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Roles__DeletedBy__30F848ED",
            //    table: "Roles",
            //    column: "DeletedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK__Roles__UpdatedBy__300424B4",
            //    table: "Roles",
            //    column: "UpdatedBy",
            //    principalTable: "Users",
            //    principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK__Roles__CreatedBy__2F10007B",
            //    table: "Roles");

            //migrationBuilder.DropForeignKey(
            //    name: "FK__Roles__DeletedBy__30F848ED",
            //    table: "Roles");

            //migrationBuilder.DropForeignKey(
            //    name: "FK__Roles__UpdatedBy__300424B4",
            //    table: "Roles");

            //migrationBuilder.DropTable(
            //    name: "AssociateUserBranches");

            //migrationBuilder.DropTable(
            //    name: "BusinessOwnerDetails");

            //migrationBuilder.DropTable(
            //    name: "CompanyAssets");

            //migrationBuilder.DropTable(
            //    name: "CreditPayments");

            //migrationBuilder.DropTable(
            //    name: "CreditUpgrades");

            //migrationBuilder.DropTable(
            //    name: "EmergencyContacts");

            //migrationBuilder.DropTable(
            //    name: "Withdrawals");

            //migrationBuilder.DropTable(
            //    name: "Banks");

            //migrationBuilder.DropTable(
            //    name: "CompanyCredits");

            //migrationBuilder.DropTable(
            //    name: "IndividualCredits");

            //migrationBuilder.DropTable(
            //    name: "BranchOffices");

            //migrationBuilder.DropTable(
            //    name: "BusinessSectors");

            //migrationBuilder.DropTable(
            //    name: "FileManagements");

            //migrationBuilder.DropTable(
            //    name: "PostalCodes");

            //migrationBuilder.DropTable(
            //    name: "Villages");

            //migrationBuilder.DropTable(
            //    name: "SubDistricts");

            //migrationBuilder.DropTable(
            //    name: "Cities");

            //migrationBuilder.DropTable(
            //    name: "Provinces");

            //migrationBuilder.DropTable(
            //    name: "Users");

            //migrationBuilder.DropTable(
            //    name: "Roles");
        }
    }
}
