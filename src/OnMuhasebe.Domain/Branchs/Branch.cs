namespace OnMuhasebe.Branchs;
public class Branch:FullAuditedAggregateRoot<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }


    public ICollection<Warehouse> Warehouses { get; set; }
    public ICollection<BankAccount> BankAccounts { get; set; }
    public ICollection<Invoice> Invoices { get; set; }
    public ICollection<Service> Services { get; set; }
    public ICollection<Receipt> Receipts { get; set; }
    public ICollection<Cash> Cashs { get; set; }
    public ICollection<CompanyParameter> CompanyParameters { get; set; }
}