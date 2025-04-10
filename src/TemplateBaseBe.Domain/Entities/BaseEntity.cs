namespace TemplateBaseBe.Domain.Entities;

public class BaseEntity
{
    public int Id { get; protected set; }
    public bool Active { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public int? ModifiedBy { get; set; }
}
