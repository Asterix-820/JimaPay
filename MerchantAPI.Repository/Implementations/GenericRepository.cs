using MerchantAPI.Repository.Data;
using MerchantAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantAPI.Repository.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T: class
    {
        private readonly AppDbContext _appDbContext;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<T>();
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
            SaveChanges();
        }

        public void Update(T entity) 
        {
            _dbSet.Update(entity);
            SaveChanges();
        }

        public void Delete(T entity) 
        {
            _dbSet.Remove(entity);
            SaveChanges();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<int> SaveChangesAsync()
        { 
           return await _appDbContext.SaveChangesAsync();
        }

        public int SaveChanges()
        {
            return _appDbContext.SaveChanges();
        }
    }
}
