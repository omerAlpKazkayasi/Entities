using BlogDal.Abstract;
using Entities.Concrete;
using Entities.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogDal.Concrete
{
    public class BaseDal<T> : IBaseDal<T> where T : BaseEntity,  new()
    {
        private readonly BlogDbContext _context;

        public BaseDal(BlogDbContext context)
        {
            _context = context;
        }

        private DbSet<T> _table { get => _context.Set<T>(); }
        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _table;

            if (predicate != null)
                query = query.Where(predicate);

            if (includeProperties.Any())
                foreach (var property in includeProperties)
                    query = query.Include(property);

            return await query.ToListAsync();

        }

        public async Task AddAsync(T entity)
        {
            await _table.AddAsync(entity);
            _context.SaveChanges();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _table;
            query = query.Where(predicate);

            if (includeProperties.Any())
                foreach (var property in includeProperties)
                    query = query.Include(property);

            return await query.SingleAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _table.FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            await Task.Run(() => _table.Update(entity));
            _context.SaveChanges();
        }

        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() => _table.Remove(entity));
            _context.SaveChanges();
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await _table.AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate is not null)
                return await _table.CountAsync(predicate);

            return await _table.CountAsync();
        }

        public async Task<List<T>> GetByIdListAsync(List<int> ids)
        {
            return await _table.Where(x => ids.Contains(x.Id)).ToListAsync();
        }
    }
}
