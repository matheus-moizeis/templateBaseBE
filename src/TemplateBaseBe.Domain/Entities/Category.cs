namespace TemplateBaseBe.Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; private set; } = string.Empty;
    
    // EF Core navigation property
    public ICollection<Product> Products { get; set; }
}
