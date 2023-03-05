using System.Data;
using Microsoft.EntityFrameworkCore;
using OnMuhasebe.BankAccounts;
using OnMuhasebe.BankBranchs;
using OnMuhasebe.Banks;
using OnMuhasebe.Branchs;
using OnMuhasebe.Cashs;
using OnMuhasebe.Configurations;
using OnMuhasebe.Consts;
using OnMuhasebe.Costs;
using OnMuhasebe.Currents;
using OnMuhasebe.Invoices;
using OnMuhasebe.Parameters;
using OnMuhasebe.Periods;
using OnMuhasebe.Receipts;
using OnMuhasebe.Services;
using OnMuhasebe.SpecialCodes;
using OnMuhasebe.Stocks;
using OnMuhasebe.Units;
using OnMuhasebe.Warehouses;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace OnMuhasebe.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class OnMuhasebeDbContext :
    AbpDbContext<OnMuhasebeDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    public DbSet<BankAccount> BankAccounts { get; set; }
    public DbSet<BankBranch> BankBranchs { get; set; }
    public DbSet<Bank> Banks { get; set; }
    public DbSet<Branch> Branchs { get; set; }
    public DbSet<Cash> Cashs { get; set; }
    public DbSet<Cost> Costs { get; set; }
    public DbSet<Current> Currents { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<CompanyParameter> CompanyParameters { get; set; }
    public DbSet<Period> Periods { get; set; }
    public DbSet<Receipt> Receipts { get; set; }
    public DbSet<Service> Service { get; set; }
    public DbSet<SpecialCode> SpecialCodes { get; set; }
    public DbSet<Stock> Stocks { get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }

    public OnMuhasebeDbContext(DbContextOptions<OnMuhasebeDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */
        builder.ConfigureBank();
        builder.ConfigureBankBranch();
        builder.ConfigureBankAccount();
        builder.ConfigureUnit();
        builder.ConfigureCurrent();
        builder.ConfigureWarehouse();
        builder.ConfigurePeriod();
        builder.ConfigureInvoice();
        builder.ConfigureInvoiceMovement();
        builder.ConfigureCompanyParameter();
        builder.ConfigureService();
        builder.ConfigureCash();
        builder.ConfigureReceipt();
        builder.ConfigureReceiptMovement();



    }
}
