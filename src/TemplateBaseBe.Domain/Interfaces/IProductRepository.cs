using TemplateBaseBe.Domain.Entities;

namespace TemplateBaseBe.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> Create(Product product);
    }
}
