namespace OnMuhasebe.Banks;
public class Bank : FullAuditedAggregateRoot<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }

    public SpecialCode SpecialCode1 { get; set; }
    public SpecialCode SpecialCode2 { get; set; }

    public ICollection<BankBranch> BankBranchs { get; set; }
    public ICollection<ReceiptMovement> ReceiptMovements { get; set; }
}