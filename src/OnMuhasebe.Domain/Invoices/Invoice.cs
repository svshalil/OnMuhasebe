namespace OnMuhasebe.Invoices;
public class Invoice : FullAuditedAggregateRoot<Guid>
{
    public InvoiceType InvoiceType { get; set; }
    public string InvoiceNo { get; set; }
    public DateTime RecordDate { get; set; }
    public decimal GrossAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal KdvExcludedAmount { get; set; }
    public decimal KdvAmount { get; set; }
    public decimal NetAmount { get; set; }
    public int MovesNumber { get; set; }
    public Guid CurrentId { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public Guid BranchId { get; set; }
    public Guid PeriodId { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }

    public Current Current { get; set; }
    public SpecialCode SpecialCode1 { get; set; }
    public SpecialCode SpecialCode2 { get; set; }
    public Branch Branch { get; set; }
    public Period Period { get; set; }

    public ICollection<InvoiceMovement> InvoiceMovements { get; set; }
}