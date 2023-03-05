using System.Data;
using Microsoft.EntityFrameworkCore;
using OnMuhasebe.BankAccounts;
using OnMuhasebe.BankBranchs;
using OnMuhasebe.Banks;
using OnMuhasebe.Cashs;
using OnMuhasebe.Consts;
using OnMuhasebe.Currents;
using OnMuhasebe.Invoices;
using OnMuhasebe.Parameters;
using OnMuhasebe.Periods;
using OnMuhasebe.ReceiptMovements;
using OnMuhasebe.Receipts;
using OnMuhasebe.Services;
using OnMuhasebe.Units;
using OnMuhasebe.Warehouses;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace OnMuhasebe.Configurations;
public static class OnMuhasebeDbContextModelBuilderExtensions
{
    public static void ConfigureBank(this ModelBuilder builder)
    {
        builder.Entity<Bank>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Banks", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.Code)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxCodeLength);

            b.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxNameLength);

            b.Property(x => x.SpecialCode1Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());

            //indexs
            b.HasIndex(x => x.Code);
            //relations
            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1Banks)
                .OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.SpecialCode2)
                .WithMany(x => x.SpecialCode2Banks)
                .OnDelete(DeleteBehavior.NoAction); ;
        });
    }

    public static void ConfigureBankAccount(this ModelBuilder builder)
    {
        builder.Entity<BankAccount>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "BankAccounts", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.Code)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxCodeLength);

            b.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxNameLength);

            b.Property(x => x.AccountType)
                .IsRequired()
                .HasColumnType(SqlDbType.TinyInt.ToString());

            b.Property(x => x.AccountNo)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(BankAccountConsts.MaxAccountNoLength);

            b.Property(x => x.IbanNo)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(BankAccountConsts.MaxIbanNoLength);

            b.Property(x => x.BankBranch)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode1Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.BranchId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());

            //indexs
            b.HasIndex(x => x.Code);
            //relations
            b.HasOne(x => x.BankBranch)
               .WithMany(x => x.BankAccounts)
               .OnDelete(DeleteBehavior.Cascade);

            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1BankAccounts)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode2)
                .WithMany(x => x.SpecialCode2BankAccounts)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Branch)
               .WithMany(x => x.BankAccounts)
               .OnDelete(DeleteBehavior.Cascade);
        });
    }

    public static void ConfigureBankBranch(this ModelBuilder builder)
    {
        builder.Entity<BankBranch>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "BankBranchs", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            //properties
            b.Property(x => x.Code)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxCodeLength);

            b.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxNameLength);

            b.Property(x => x.BankId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode1Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());

            //indexs
            b.HasIndex(x => x.Code);
            //relations
            b.HasOne(x => x.Bank)
               .WithMany(x => x.BankBranchs)
               .OnDelete(DeleteBehavior.Cascade);

            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1BankBranchs)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode2)
                .WithMany(x => x.SpecialCode2BankBranchs)
                .OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureUnit(this ModelBuilder builder)
    {
        builder.Entity<Unit>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Units", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            //properties
            b.Property(x => x.Code)
              .IsRequired()
              .HasColumnType(SqlDbType.VarChar.ToString())
              .HasMaxLength(EntityConsts.MaxCodeLength);

            b.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxNameLength);

            b.Property(x => x.SpecialCode1Id)
               .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());
            //indexs
            b.HasIndex(x => x.Code);
            //relations
            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1Units)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode2)
                .WithMany(x => x.SpecialCode2Units)
                .OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureCurrent(this ModelBuilder builder)
    {
        builder.Entity<Current>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Currents", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            //properties
            b.Property(x => x.Code)
              .IsRequired()
              .HasColumnType(SqlDbType.VarChar.ToString())
              .HasMaxLength(EntityConsts.MaxCodeLength);

            b.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxNameLength);

            b.Property(x => x.TaxAdministration)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(CurrentConsts.MaxTaxNoLength);

            b.Property(x => x.TC)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(CurrentConsts.MaxTCNoLength);

            b.Property(x => x.TaxNo)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(CurrentConsts.MaxTaxAdministrationLength);

            b.Property(x => x.PhoneNumber)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxPhoneNumberLength);

            b.Property(x => x.Address)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxAddressLength);

            b.Property(x => x.SpecialCode1Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());
            //indexs
            b.HasIndex(x => x.Code);
            //relations
            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1Currents)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode2)
                .WithMany(x => x.SpecialCode2Currents)
                .OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureWarehouse(this ModelBuilder builder)
    {
        builder.Entity<Warehouse>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Warehouses", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            //properties
            b.Property(x => x.Code)
              .IsRequired()
              .HasColumnType(SqlDbType.VarChar.ToString())
              .HasMaxLength(EntityConsts.MaxCodeLength);

            b.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxNameLength);

            b.Property(x => x.SpecialCode1Id)
               .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.BranchId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());
            //indexs
            b.HasIndex(x => x.Code);
            //relations
            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1Warehouses)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode2)
                .WithMany(x => x.SpecialCode2Warehouses)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Branch)
              .WithMany(x => x.Warehouses)
              .OnDelete(DeleteBehavior.Cascade);
        });
    }

    public static void ConfigurePeriod(this ModelBuilder builder)
    {
        builder.Entity<Period>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Periods", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            //properties
            b.Property(x => x.Code)
              .IsRequired()
              .HasColumnType(SqlDbType.VarChar.ToString())
              .HasMaxLength(EntityConsts.MaxCodeLength);

            b.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxNameLength);

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());
            //indexs
            b.HasIndex(x => x.Code);
            //relations
          
        });
    }

    public static void ConfigureInvoice(this ModelBuilder builder)
    {
        builder.Entity<Invoice>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Invoices", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            //properties
            b.Property(x => x.InvoiceType)
              .IsRequired()
              .HasColumnType(SqlDbType.TinyInt.ToString());

            b.Property(x => x.InvoiceNo)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(InvoiceConsts.MaxInvoiceNoLength);

            b.Property(x => x.RecordDate)
                .IsRequired()
                .HasColumnType(SqlDbType.DateTime.ToString());

            b.Property(x => x.GrossAmount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.DiscountAmount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.KdvExcludedAmount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.KdvExcludedAmount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.KdvAmount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.NetAmount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.MovesNumber)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.CurrentId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode1Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.BranchId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.PeriodId)
               .IsRequired()
               .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());
            //indexs
            b.HasIndex(x => x.InvoiceNo);
            //relations
            b.HasOne(x => x.Current)
                .WithMany(x => x.Invoices)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1Invoices)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode2)
                .WithMany(x => x.SpecialCode2Invoices)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Branch)
                .WithMany(x => x.Invoices)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Period)
               .WithMany(x => x.Invoices)
               .OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureInvoiceMovement(this ModelBuilder builder)
    {
        builder.Entity<InvoiceMovement>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "InvoiceMovements", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            //properties
            b.Property(x => x.InvoiceId)
              .IsRequired()
              .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.MovementType)
                .IsRequired()
                .HasColumnType(SqlDbType.TinyInt.ToString());

            b.Property(x => x.StockId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.GrossAmount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.DiscountAmount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.ServiceId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.CostId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.KdvAmount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.NetAmount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.WarehouseId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Amount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.UnitPrice)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.KdvRate)
                .IsRequired()   
                .HasColumnType(SqlDbType.Int.ToString());

            b.Property(x => x.KdvExcludes)
               .IsRequired()
               .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxDescriptionLength);

            //indexs
            //relations
            b.HasOne(x => x.Invoice)
                .WithMany(x => x.InvoiceMovements)
                .OnDelete(DeleteBehavior.Cascade);

            b.HasOne(x => x.Stock)
                .WithMany(x => x.InvoiceMovements)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Service)
                .WithMany(x => x.InvoiceMovements)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Cost)
                .WithMany(x => x.InvoiceMovements)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Warehouse)
               .WithMany(x => x.InvoiceMovements)
               .OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureCompanyParameter(this ModelBuilder builder)
    {
        builder.Entity<CompanyParameter>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "CompanyParameters", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            //properties
            b.Property(x => x.UserId)
              .IsRequired()
              .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.BranchId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Period)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.WarehouseId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            //indexs

            //relations

            b.HasOne(x => x.User)
              .WithOne()
              .HasForeignKey<CompanyParameter>(x=>x.UserId);

            b.HasOne(x => x.Branch)
              .WithMany(x => x.CompanyParameters)
              .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Period)
              .WithMany(x => x.CompanyParameters)
              .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Warehouse)
              .WithMany(x => x.CompanyParameters)
              .OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureService(this ModelBuilder builder)
    {
        builder.Entity<Service>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Services", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            //properties
            b.Property(x => x.Code)
              .IsRequired()
              .HasColumnType(SqlDbType.VarChar.ToString())
              .HasMaxLength(EntityConsts.MaxCodeLength);

            b.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxNameLength);

            b.Property(x => x.KdvRate)
                .IsRequired()
                .HasColumnType(SqlDbType.Int.ToString());

            b.Property(x => x.UnitPrice)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString())
                .HasMaxLength(EntityConsts.MaxBarcodeLength);

            b.Property(x => x.BarCode)
                 .HasColumnType(SqlDbType.VarChar.ToString());

            b.Property(x => x.UnitId)
                 .IsRequired()
                 .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode1Id)
               .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());
            //indexs
            b.HasIndex(x => x.Code);
            //relations
            b.HasOne(x => x.Unit)
                .WithMany(x => x.Services)
                .OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1Services)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode2)
                .WithMany(x => x.SpecialCode2Services)
                .OnDelete(DeleteBehavior.NoAction);

        });
    }

    public static void ConfigureCash(this ModelBuilder builder)
    {
        builder.Entity<Cash>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Cashs", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            //properties
            b.Property(x => x.Code)
              .IsRequired()
              .HasColumnType(SqlDbType.VarChar.ToString())
              .HasMaxLength(EntityConsts.MaxCodeLength);

            b.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxNameLength);

            b.Property(x => x.SpecialCode1Id)
               .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.BranchId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());
            //indexs
            b.HasIndex(x => x.Code);
            //relations
            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1Cashs)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode2)
                .WithMany(x => x.SpecialCode2Cashs)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Branch)
              .WithMany(x => x.Cashs)
              .OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureReceipt(this ModelBuilder builder)
    {
        builder.Entity<Receipt>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Receipts", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            //properties
            b.Property(x => x.ReceiptType)
              .IsRequired()
              .HasColumnType(SqlDbType.TinyInt.ToString());

            b.Property(x => x.ReceiptNo)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(ReceiptConsts.MaxReceiptNoLength);

            b.Property(x => x.RecordDate)
                .IsRequired()
                .HasColumnType(SqlDbType.DateTime.ToString());

            b.Property(x => x.CurrentId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.CashId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.BankAccountId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.MovesNumber)
                .IsRequired()
                .HasColumnType(SqlDbType.Int.ToString());

            b.Property(x => x.CheckTotal)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.PosTotal)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.CashTotal)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.BankTotal)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.SpecialCode1Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.BranchId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.PeriodId)
               .IsRequired()
               .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());
            //indexs
            b.HasIndex(x => x.ReceiptNo);
            //relations
            b.HasOne(x => x.Current)
                .WithMany(x => x.Receipts)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Cash)
               .WithMany(x => x.Receipts)
               .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.BankAccount)
               .WithMany(x => x.Receipts)
               .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1Receipts)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode2)
                .WithMany(x => x.SpecialCode2Receipts)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Branch)
                .WithMany(x => x.Receipts)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Period)
               .WithMany(x => x.Receipts)
               .OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureReceiptMovement(this ModelBuilder builder)
    {
        builder.Entity<ReceiptMovement>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "ReceiptMovements", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            //properties
            b.Property(x => x.ReceiptId)
              .IsRequired()
              .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.PaymentType)
                .IsRequired()
                .HasColumnType(SqlDbType.TinyInt.ToString())
                .HasMaxLength(ReceiptMovementConsts.MaxTrackingNoLength);

            b.Property(x => x.TrackingNo)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString());

            b.Property(x => x.CheckBankId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.CheckBankBranchId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.CheckAccountNo)
                .IsRequired()
                .HasColumnType(SqlDbType.TinyInt.ToString())
                .HasMaxLength(ReceiptMovementConsts.MaxCheckAccountNoLength);

            b.Property(x => x.DocumentNo)
                .IsRequired()
                .HasColumnType(SqlDbType.TinyInt.ToString())
                .HasMaxLength(ReceiptMovementConsts.MaxDocumentNoLength);

            b.Property(x => x.Expiry)
              .IsRequired()
              .HasColumnType(SqlDbType.DateTime.ToString());

            b.Property(x => x.PrincipalDebtor)
                 .IsRequired()
                 .HasColumnType(SqlDbType.TinyInt.ToString())
                 .HasMaxLength(ReceiptMovementConsts.MaxPrincipalDebtorLength);

            b.Property(x => x.Ciranta)
                .IsRequired()
               .HasColumnType(SqlDbType.TinyInt.ToString())
                .HasMaxLength(ReceiptMovementConsts.MaxCirantaLength);

            b.Property(x => x.CashId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.BankAccountId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Amount)
                   .IsRequired()
                   .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.DocumentStatus)
                .IsRequired()
                .HasColumnType(SqlDbType.TinyInt.ToString());

            b.Property(x => x.OurOwnDocument)
              .IsRequired()
             .HasColumnType(SqlDbType.Bit.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxDescriptionLength);


            //indexs
            b.HasIndex(x => x.TrackingNo);
            //relations
            b.HasOne(x => x.Receipt)
                .WithMany(x => x.ReceiptMovements)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Bank)
               .WithMany(x => x.ReceiptMovements)
               .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.BankBranch)
             .WithMany(x => x.ReceiptMovements)
             .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Cash)
               .WithMany(x => x.ReceiptMovements)
               .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.BankAccount)
               .WithMany(x => x.ReceiptMovements)
               .OnDelete(DeleteBehavior.NoAction);
        });
    }
}