namespace OnMuhasebe.Invoices;
public class InvoiceMovement:FullAuditedEntity<Guid>
{
    public Guid InvoiceId { get; set; }
    public InvoiceMovementType MovementType { get; set; }
    public Guid? StockId { get; set; }
    public Guid? ServiceId { get; set; }
    public Guid? CostId { get; set; }
    public Guid? WarehouseId { get; set; }
    public decimal Amount { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal GrossAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public int KdvRate { get; set; }
    public decimal KdvExcludes { get; set; }
    public decimal KdvAmount { get; set; }
    public decimal NetAmount { get; set; }
    public string Description { get; set; }

    public Invoice Invoice { get; set; }
    public Stock Stock { get; set; }
    public Service Service { get; set; }
    public Cost Cost { get; set; }
    public Warehouse Warehouse { get; set; }
}