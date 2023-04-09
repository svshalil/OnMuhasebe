using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnMuhasebe.Migrations
{
    /// <inheritdoc />
    public partial class AllEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppBranchs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "VarChar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "VarChar(150)", maxLength: 150, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBranchs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppPeriods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPeriods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppSpecialCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    CodeType = table.Column<byte>(type: "TinyInt", nullable: false),
                    CartType = table.Column<byte>(type: "TinyInt", nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSpecialCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppBanks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBanks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppBanks_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppBanks_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppCashs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCashs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCashs_AppBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranchs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppCashs_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppCashs_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppCurrents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    TaxAdministration = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: true),
                    TaxNo = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "VarChar(15)", maxLength: 15, nullable: true),
                    Address = table.Column<string>(type: "VarChar(150)", maxLength: 150, nullable: true),
                    TC = table.Column<string>(type: "VarChar(15)", maxLength: 15, nullable: true),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCurrents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCurrents_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppCurrents_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUnits_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppUnits_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppWarehouses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppWarehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppWarehouses_AppBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranchs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppWarehouses_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppWarehouses_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppBankBranchs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    BankId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBankBranchs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppBankBranchs_AppBanks_BankId",
                        column: x => x.BankId,
                        principalTable: "AppBanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppBankBranchs_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppBankBranchs_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppInvoices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceType = table.Column<byte>(type: "TinyInt", nullable: false),
                    InvoiceNo = table.Column<string>(type: "VarChar(16)", maxLength: 16, nullable: false),
                    RecordDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    GrossAmount = table.Column<decimal>(type: "Money", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "Money", nullable: false),
                    KdvExcludedAmount = table.Column<decimal>(type: "Money", nullable: false),
                    KdvAmount = table.Column<decimal>(type: "Money", nullable: false),
                    NetAmount = table.Column<decimal>(type: "Money", nullable: false),
                    MovesNumber = table.Column<decimal>(type: "Money", nullable: false),
                    CurrentId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    PeriodId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppInvoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppInvoices_AppBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranchs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppInvoices_AppCurrents_CurrentId",
                        column: x => x.CurrentId,
                        principalTable: "AppCurrents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppInvoices_AppPeriods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "AppPeriods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppInvoices_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppInvoices_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppCosts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    KdvRate = table.Column<int>(type: "Int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "Money", maxLength: 128, nullable: false),
                    BarCode = table.Column<string>(type: "VarChar", nullable: true),
                    UnitId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCosts_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppCosts_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppCosts_AppUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "AppUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    KdvRate = table.Column<int>(type: "Int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "Money", maxLength: 128, nullable: false),
                    BarCode = table.Column<string>(type: "VarChar", nullable: true),
                    UnitId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppServices_AppBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranchs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppServices_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppServices_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppServices_AppUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "AppUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    KdvRate = table.Column<int>(type: "Int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "Money", maxLength: 128, nullable: false),
                    BarCode = table.Column<string>(type: "VarChar", nullable: true),
                    UnitId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStocks_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStocks_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStocks_AppUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "AppUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppCompanyParameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    PeriodId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    WarehouseId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCompanyParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCompanyParameters_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppCompanyParameters_AppBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranchs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppCompanyParameters_AppPeriods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "AppPeriods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppCompanyParameters_AppWarehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "AppWarehouses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppBankAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    AccountType = table.Column<byte>(type: "TinyInt", nullable: false),
                    AccountNo = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    IbanNo = table.Column<string>(type: "VarChar(26)", maxLength: 26, nullable: true),
                    BankBranchId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBankAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppBankAccounts_AppBankBranchs_BankBranchId",
                        column: x => x.BankBranchId,
                        principalTable: "AppBankBranchs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppBankAccounts_AppBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranchs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppBankAccounts_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppBankAccounts_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppInvoiceMovements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    MovementType = table.Column<byte>(type: "TinyInt", nullable: false),
                    StockId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    ServiceId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    CostId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    WarehouseId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Amount = table.Column<decimal>(type: "Money", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "Money", nullable: false),
                    GrossAmount = table.Column<decimal>(type: "Money", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "Money", nullable: false),
                    KdvRate = table.Column<int>(type: "Int", nullable: false),
                    KdvExcludes = table.Column<decimal>(type: "Money", nullable: false),
                    KdvAmount = table.Column<decimal>(type: "Money", nullable: false),
                    NetAmount = table.Column<decimal>(type: "Money", nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppInvoiceMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppInvoiceMovements_AppCosts_CostId",
                        column: x => x.CostId,
                        principalTable: "AppCosts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppInvoiceMovements_AppInvoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "AppInvoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppInvoiceMovements_AppServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "AppServices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppInvoiceMovements_AppStocks_StockId",
                        column: x => x.StockId,
                        principalTable: "AppStocks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppInvoiceMovements_AppWarehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "AppWarehouses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppReceipts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptType = table.Column<byte>(type: "TinyInt", nullable: false),
                    ReceiptNo = table.Column<string>(type: "VarChar(16)", maxLength: 16, nullable: false),
                    RecordDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    CurrentId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    CashId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    BankAccountId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    MovesNumber = table.Column<int>(type: "Int", nullable: false),
                    CheckTotal = table.Column<decimal>(type: "Money", nullable: false),
                    PosTotal = table.Column<decimal>(type: "Money", nullable: false),
                    CashTotal = table.Column<decimal>(type: "Money", nullable: false),
                    BankTotal = table.Column<decimal>(type: "Money", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    PeriodId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppReceipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppBankAccounts_BankAccountId",
                        column: x => x.BankAccountId,
                        principalTable: "AppBankAccounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranchs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppCashs_CashId",
                        column: x => x.CashId,
                        principalTable: "AppCashs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppCurrents_CurrentId",
                        column: x => x.CurrentId,
                        principalTable: "AppCurrents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppPeriods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "AppPeriods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppReceiptMovements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    PaymentType = table.Column<byte>(type: "TinyInt", maxLength: 20, nullable: false),
                    TrackingNo = table.Column<string>(type: "VarChar", nullable: false),
                    CheckBankId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    CheckBankBranchId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    CheckAccountNo = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    DocumentNo = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Expiry = table.Column<DateTime>(type: "DateTime", nullable: false),
                    PrincipalDebtor = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Ciranta = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    CashId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    BankAccountId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Amount = table.Column<decimal>(type: "Money", nullable: false),
                    DocumentStatus = table.Column<byte>(type: "TinyInt", nullable: false),
                    OurOwnDocument = table.Column<bool>(type: "Bit", nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    BankId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BankBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppReceiptMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppReceiptMovements_AppBankAccounts_BankAccountId",
                        column: x => x.BankAccountId,
                        principalTable: "AppBankAccounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceiptMovements_AppBankBranchs_BankBranchId",
                        column: x => x.BankBranchId,
                        principalTable: "AppBankBranchs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceiptMovements_AppBanks_BankId",
                        column: x => x.BankId,
                        principalTable: "AppBanks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceiptMovements_AppCashs_CashId",
                        column: x => x.CashId,
                        principalTable: "AppCashs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceiptMovements_AppReceipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "AppReceipts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppBankAccounts_BankBranchId",
                table: "AppBankAccounts",
                column: "BankBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankAccounts_BranchId",
                table: "AppBankAccounts",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankAccounts_Code",
                table: "AppBankAccounts",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankAccounts_SpecialCode1Id",
                table: "AppBankAccounts",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankAccounts_SpecialCode2Id",
                table: "AppBankAccounts",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankBranchs_BankId",
                table: "AppBankBranchs",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankBranchs_Code",
                table: "AppBankBranchs",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankBranchs_SpecialCode1Id",
                table: "AppBankBranchs",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankBranchs_SpecialCode2Id",
                table: "AppBankBranchs",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBanks_Code",
                table: "AppBanks",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppBanks_SpecialCode1Id",
                table: "AppBanks",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBanks_SpecialCode2Id",
                table: "AppBanks",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBranchs_Code",
                table: "AppBranchs",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppCashs_BranchId",
                table: "AppCashs",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCashs_Code",
                table: "AppCashs",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppCashs_SpecialCode1Id",
                table: "AppCashs",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppCashs_SpecialCode2Id",
                table: "AppCashs",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyParameters_BranchId",
                table: "AppCompanyParameters",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyParameters_PeriodId",
                table: "AppCompanyParameters",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyParameters_UserId",
                table: "AppCompanyParameters",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyParameters_WarehouseId",
                table: "AppCompanyParameters",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCosts_Code",
                table: "AppCosts",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppCosts_SpecialCode1Id",
                table: "AppCosts",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppCosts_SpecialCode2Id",
                table: "AppCosts",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppCosts_UnitId",
                table: "AppCosts",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCurrents_Code",
                table: "AppCurrents",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppCurrents_SpecialCode1Id",
                table: "AppCurrents",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppCurrents_SpecialCode2Id",
                table: "AppCurrents",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoiceMovements_CostId",
                table: "AppInvoiceMovements",
                column: "CostId");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoiceMovements_InvoiceId",
                table: "AppInvoiceMovements",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoiceMovements_ServiceId",
                table: "AppInvoiceMovements",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoiceMovements_StockId",
                table: "AppInvoiceMovements",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoiceMovements_WarehouseId",
                table: "AppInvoiceMovements",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoices_BranchId",
                table: "AppInvoices",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoices_CurrentId",
                table: "AppInvoices",
                column: "CurrentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoices_InvoiceNo",
                table: "AppInvoices",
                column: "InvoiceNo");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoices_PeriodId",
                table: "AppInvoices",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoices_SpecialCode1Id",
                table: "AppInvoices",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoices_SpecialCode2Id",
                table: "AppInvoices",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppPeriods_Code",
                table: "AppPeriods",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceiptMovements_BankAccountId",
                table: "AppReceiptMovements",
                column: "BankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceiptMovements_BankBranchId",
                table: "AppReceiptMovements",
                column: "BankBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceiptMovements_BankId",
                table: "AppReceiptMovements",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceiptMovements_CashId",
                table: "AppReceiptMovements",
                column: "CashId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceiptMovements_ReceiptId",
                table: "AppReceiptMovements",
                column: "ReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceiptMovements_TrackingNo",
                table: "AppReceiptMovements",
                column: "TrackingNo");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_BankAccountId",
                table: "AppReceipts",
                column: "BankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_BranchId",
                table: "AppReceipts",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_CashId",
                table: "AppReceipts",
                column: "CashId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_CurrentId",
                table: "AppReceipts",
                column: "CurrentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_PeriodId",
                table: "AppReceipts",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_ReceiptNo",
                table: "AppReceipts",
                column: "ReceiptNo");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_SpecialCode1Id",
                table: "AppReceipts",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_SpecialCode2Id",
                table: "AppReceipts",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppServices_BranchId",
                table: "AppServices",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppServices_Code",
                table: "AppServices",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppServices_SpecialCode1Id",
                table: "AppServices",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppServices_SpecialCode2Id",
                table: "AppServices",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppServices_UnitId",
                table: "AppServices",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AppSpecialCodes_Code",
                table: "AppSpecialCodes",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppStocks_Code",
                table: "AppStocks",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppStocks_SpecialCode1Id",
                table: "AppStocks",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppStocks_SpecialCode2Id",
                table: "AppStocks",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppStocks_UnitId",
                table: "AppStocks",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUnits_Code",
                table: "AppUnits",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppUnits_SpecialCode1Id",
                table: "AppUnits",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppUnits_SpecialCode2Id",
                table: "AppUnits",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppWarehouses_BranchId",
                table: "AppWarehouses",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppWarehouses_Code",
                table: "AppWarehouses",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppWarehouses_SpecialCode1Id",
                table: "AppWarehouses",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppWarehouses_SpecialCode2Id",
                table: "AppWarehouses",
                column: "SpecialCode2Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppCompanyParameters");

            migrationBuilder.DropTable(
                name: "AppInvoiceMovements");

            migrationBuilder.DropTable(
                name: "AppReceiptMovements");

            migrationBuilder.DropTable(
                name: "AppCosts");

            migrationBuilder.DropTable(
                name: "AppInvoices");

            migrationBuilder.DropTable(
                name: "AppServices");

            migrationBuilder.DropTable(
                name: "AppStocks");

            migrationBuilder.DropTable(
                name: "AppWarehouses");

            migrationBuilder.DropTable(
                name: "AppReceipts");

            migrationBuilder.DropTable(
                name: "AppUnits");

            migrationBuilder.DropTable(
                name: "AppBankAccounts");

            migrationBuilder.DropTable(
                name: "AppCashs");

            migrationBuilder.DropTable(
                name: "AppCurrents");

            migrationBuilder.DropTable(
                name: "AppPeriods");

            migrationBuilder.DropTable(
                name: "AppBankBranchs");

            migrationBuilder.DropTable(
                name: "AppBranchs");

            migrationBuilder.DropTable(
                name: "AppBanks");

            migrationBuilder.DropTable(
                name: "AppSpecialCodes");
        }
    }
}
