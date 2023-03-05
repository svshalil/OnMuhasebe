namespace OnMuhasebe.Stocks;
public class Stock:FullAuditedAggregateRoot<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public int KdvRate { get; set; }
    public decimal UnitPrice { get; set; }
    public string BarCode { get; set; }
    public Guid UnitId { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }

    public Unit Unit { get; set; }
    public SpecialCode SpecialCode1 { get; set; }
    public SpecialCode SpecialCode2 { get; set; }

    public ICollection<InvoiceMovement> InvoiceMovements { get; set; }

}