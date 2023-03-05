namespace OnMuhasebe.Parameters;
public class CompanyParameter:Entity<Guid>
{
    public Guid UserId { get; set; }
    public Guid BranchId { get; set; }
    public Guid PeriodId { get; set; }
    public Guid?  WarehouseId { get; set; }

    public IdentityUser User { get; set; }
    public Branch Branch { get; set; }
    public Period Period { get; set; }
    public Warehouse Warehouse { get; set; }
}