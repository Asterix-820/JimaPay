using JimaPay.Domain.Entities;
using JimaPay.Repository.Data;
using JimaPay.Repository.Interfaces;
using Jimpay.Repository.Implementations;
using Microsoft.EntityFrameworkCore;

namespace JimaPay.Repository.Implementations
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
