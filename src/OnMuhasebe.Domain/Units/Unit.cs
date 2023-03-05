namespace OnMuhasebe.Units;
public class Unit : FullAuditedAggregateRoot<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }

    public SpecialCode SpecialCode1 { get; set; }
    public SpecialCode SpecialCode2 { get; set; }

    public ICollection<Service> Services { get; set; }
    public ICollection<Stock> Stocks { get; set; }
    public ICollection<Cost> Costs { get; set; }
}
