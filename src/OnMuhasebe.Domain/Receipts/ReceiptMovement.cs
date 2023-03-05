namespace OnMuhasebe.Receipts;
public class ReceiptMovement : FullAuditedEntity<Guid>
{
    public Guid ReceiptId { get; set; }
    public PaymentType PaymentType { get; set; }
    public string TrackingNo { get; set; }
    public Guid? CheckBankId { get; set; }
    public Guid? CheckBankBranchId { get; set; }
    public string CheckAccountNo { get; set; }
    public string DocumentNo { get; set; }
    public DateTime Expiry { get; set; }
    public string PrincipalDebtor { get; set; }
    public string Ciranta { get; set; }
    public Guid? CashId { get; set; }
    public Guid? BankAccountId { get; set; }
    public decimal Amount { get; set; }
    public DocumentStatus DocumentStatus { get; set; }
    public bool OurOwnDocument { get; set; }
    public string Description { get; set; }

    public Receipt Receipt { get; set; }
    public Bank Bank { get; set; }
    public BankBranch BankBranch { get; set; }
    public Cash Cash { get; set; }
    public BankAccount BankAccount { get; set; }
}