using Microsoft.EntityFrameworkCore;
using TemplateBaseBe.Data.Context;
using TemplateBaseBe.Domain.Entities;
using TemplateBaseBe.Domain.Interfaces;

namespace TemplateBaseBe.Data.Repositories
{
    public class BaseRepository<T>(TemplateBaseBeContext _context) : IBaseRepository<T> where T : BaseEntity
    {
        public async Task<T> Create(T entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>()
                                 .AsNoTracking()
                                 .ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>()
                                 .AsNoTracking()
                                 .FirstOrDefaultAsync(e => e.Id == id);

        }

        public async Task<bool> Remove(int id)
        {
            var entity = await GetById(id);

            if (entity == null) return false;

            _context.Remove(entity);

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<T> Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
