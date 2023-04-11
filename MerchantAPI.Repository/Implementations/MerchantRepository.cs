using MerchantAPI.Domain.Entities;
using MerchantAPI.Repository.Data;
using MerchantAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MerchantAPI.Repository.Implementations
{
    public class MerchantRepository : GenericRepository<Merchant>, IMerchantRepository
    {
        private readonly AppDbContext _context;
        
        public MerchantRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Merchant> GetMerchantById(string id)
        {
             return  await _context.Merchants.FirstOrDefaultAsync(x => x.MerchantId == id);
           
        }
    }
}
