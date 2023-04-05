using AutoMapper;
using MerchantAPI.DTO;
using MerchantAPI.Interfaces;
using MerchantAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace MerchantAPI.Repository
{
    public class MerchantRepository : IMerchantRepository
    {
        private readonly MerchantDbContext _context;
        private readonly IMapper _mapper;
        public MerchantRepository(MerchantDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> CreateMerchant(MerchantDTO merchant)
        {
            var merchantEntity = _mapper.Map<Merchant>(merchant);
            _context.Merchants.Add(merchantEntity);
            await _context.SaveChangesAsync();
            return await merchantEntity.MerchantId;
        }

        public async Task<MerchantDTO> GetMerchant(int id)
        {
            var merchant = await _context.Merchants.FindAsync(id);
            return _mapper.Map<MerchantDTO>(merchant);
        }

        public async Task<IEnumerable<MerchantDTO>> GetMerchants()
        {
            var merchants = await _context.Merchants.ToListAsync();
            return _mapper.Map<IEnumerable<MerchantDTO>>(merchants);
        }
    }
}
