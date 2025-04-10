﻿namespace TemplateBaseBe.Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public ICollection<Product>? Products { get; set; }
}
