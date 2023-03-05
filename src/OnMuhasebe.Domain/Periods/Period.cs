namespace OnMuhasebe.Periods;
public class Period : FullAuditedAggregateRoot<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }

    public ICollection<Invoice> Invoices { get; set; }
    public ICollection<Receipt> Receipts { get; set; }
    public ICollection<CompanyParameter> CompanyParameters { get; set; }
}
