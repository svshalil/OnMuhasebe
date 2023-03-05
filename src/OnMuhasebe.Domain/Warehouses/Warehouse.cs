namespace OnMuhasebe.Warehouses;
public class Warehouse : FullAuditedAggregateRoot<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public Guid BranchId { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }

    public Branch Branch { get; set; }
    public SpecialCode SpecialCode1 { get; set; }
    public SpecialCode SpecialCode2 { get; set; }

    public ICollection<CompanyParameter> CompanyParameters { get; set; }
    public ICollection<InvoiceMovement> InvoiceMovements { get; set; }
}
