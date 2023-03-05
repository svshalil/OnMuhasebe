namespace OnMuhasebe.BankBranchs;
public class BankBranch : FullAuditedAggregateRoot<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid BankId { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }

    public Bank Bank { get; set; }
    public SpecialCode SpecialCode1 { get; set; }
    public SpecialCode SpecialCode2 { get; set; }
    public ICollection<BankAccount> BankAccounts { get; set; }
    public ICollection<ReceiptMovement> ReceiptMovements { get; set; }

}
