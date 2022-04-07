using JHA_Core.Repositories.Base;
using JHA_Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHA_Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly CardManagementContext _cardManagementContext;

        public Repository(CardManagementContext context)
        {
            _cardManagementContext = context;

        }


        public async Task<T> AddAsync(T entity)
        {
            await _cardManagementContext.Set<T>().AddAsync(entity);
            await _cardManagementContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _cardManagementContext.Set<T>().Remove(entity);
            await _cardManagementContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _cardManagementContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _cardManagementContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
