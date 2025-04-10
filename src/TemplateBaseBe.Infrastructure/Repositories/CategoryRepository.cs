using Microsoft.EntityFrameworkCore;
using TemplateBaseBe.Data.Context;
using TemplateBaseBe.Domain.Entities;
using TemplateBaseBe.Domain.Interfaces;

namespace TemplateBaseBe.Data.Repositories
{
    public class CategoryRepository(TemplateBaseBeContext context) : BaseRepository<Category>(context), ICategoryRepository
    {
        private readonly TemplateBaseBeContext _context = context;

        public async Task<IEnumerable<Category>> GetCategoriesActive()
        {
            return await _context.Categories.Where(x => x.Active).AsNoTracking().ToListAsync();
        }
    }

}
