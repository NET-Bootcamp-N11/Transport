using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Permission_Application.Abstractions.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Permission_Infrastructure.Generic
{
    public class GenericRepositories<T> : IGenericRepositories<T> where T : class
    {
        private readonly AppDbContext _appDbContext;
        private readonly DbSet<T> dbSet;
        public GenericRepositories(AppDbContext app)
        {
            _appDbContext = app;
            dbSet = _appDbContext.Set<T>();
        }
        public async Task<T> CreateAsync(T entity)
        {
                var entry = await dbSet.AddAsync(entity);
                await _appDbContext.SaveChangesAsync();
                return entry.Entity;
        }
        public async Task<bool> DeleteAsync(int id)
        {
                var entity = await dbSet.FirstOrDefaultAsync( x => x.Equals(id));
                dbSet.Remove(entity);
                await _appDbContext.SaveChangesAsync();
                return true;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            var get = await dbSet.FindAsync(id);
                return get;
        }
        public async Task<T> UpdateAsync(T entity)
        {
                var entry = dbSet.Update(entity);
                await _appDbContext.SaveChangesAsync();
                return entry.Entity;
        }
    }

}
