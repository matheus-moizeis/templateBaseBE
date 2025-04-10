using TemplateBaseBe.Domain.Entities;
using TemplateBaseBe.Domain.Interfaces;

namespace TemplateBaseBe.Data.Repositories;

public class ProductRepository(IBaseRepository<Product> baseRepository) : IProductRepository
{
    private readonly IBaseRepository<Product> _baseRepository = baseRepository;

    public async Task<Product> Create(Product product)
    {
        return await _baseRepository.Create(product);
    }
}
