using TemplateBaseBe.Domain.Entities;

namespace TemplateBaseBe.Domain.Interfaces;

public interface ICategoryRepository : IBaseRepository<Category>
{
    Task<IEnumerable<Category>> GetCategoriesActive();

}
