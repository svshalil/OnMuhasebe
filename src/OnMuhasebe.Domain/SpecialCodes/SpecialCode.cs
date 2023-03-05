namespace OnMuhasebe.SpecialCodes;
public class SpecialCode : FullAuditedAggregateRoot<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public SpecialCodeType CodeType { get; set; }
    public CartType CartType { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }

    public ICollection<BankAccount> SpecialCode1BankAccounts { get; set; }
    public ICollection<BankAccount> SpecialCode2BankAccounts { get; set; }
    public ICollection<Bank> SpecialCode1Banks { get; set; }
    public ICollection<Bank> SpecialCode2Banks { get; set; }
    public ICollection<BankBranch> SpecialCode1BankBranchs { get; set; }
    public ICollection<BankBranch> SpecialCode2BankBranchs { get; set; }
    public ICollection<Unit> SpecialCode1Units { get; set; }
    public ICollection<Unit> SpecialCode2Units { get; set; }
    public ICollection<Current> SpecialCode1Currents { get; set; }
    public ICollection<Current> SpecialCode2Currents { get; set; }
    public ICollection<Warehouse> SpecialCode1Warehouses { get; set; }
    public ICollection<Warehouse> SpecialCode2Warehouses { get; set; }
    public ICollection<Invoice> SpecialCode1Invoices { get; set; }
    public ICollection<Invoice> SpecialCode2Invoices { get; set; }
    public ICollection<Service> SpecialCode1Services { get; set; }
    public ICollection<Service> SpecialCode2Services { get; set; }
    public ICollection<Cash> SpecialCode1Cashs { get; set; }
    public ICollection<Cash> SpecialCode2Cashs { get; set; }
    public ICollection<Receipt> SpecialCode1Receipts { get; set; }
    public ICollection<Receipt> SpecialCode2Receipts { get; set; }
    public ICollection<Stock> SpecialCode1Stocks { get; set; }
    public ICollection<Stock> SpecialCode2Stocks { get; set; }
    public ICollection<Cost> SpecialCode1Costs { get; set; }
    public ICollection<Cost> SpecialCode2Costs { get; set; }
}