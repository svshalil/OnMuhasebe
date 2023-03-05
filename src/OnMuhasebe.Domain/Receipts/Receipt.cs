namespace OnMuhasebe.Receipts;
public class Receipt : FullAuditedAggregateRoot<Guid>
{
    public ReceiptType ReceiptType { get; set; }
    public string ReceiptNo { get; set; }
    public DateTime RecordDate { get; set; }
    public Guid? CurrentId { get; set; }
    public Guid? CashId { get; set; }
    public Guid? BankAccountId { get; set; }
    public int MovesNumber { get; set; }
    public decimal CheckTotal { get; set; }
    public decimal PosTotal { get; set; }
    public decimal CashTotal { get; set; }
    public decimal BankTotal { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public Guid BranchId { get; set; }
    public Guid PeriodId { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }

    public Current Current { get; set; }
    public Cash Cash { get; set; }
    public BankAccount BankAccount { get; set; }
    public SpecialCode SpecialCode1 { get; set; }
    public SpecialCode SpecialCode2 { get; set; }
    public Branch Branch { get; set; }
    public Period Period { get; set; }

    public ICollection<ReceiptMovement> ReceiptMovements { get; set; }
}
