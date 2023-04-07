using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantAPI.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<int> SaveChangesAsync();
        int SaveChanges();
    }
}
