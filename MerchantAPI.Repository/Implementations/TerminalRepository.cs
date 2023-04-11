using AutoMapper;
using MerchantAPI.Common.DTO;
using MerchantAPI.Domain.Entities;
using MerchantAPI.Repository.Data;
using MerchantAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MerchantAPI.Repository.Implementations
{
    public class TerminalRepository : GenericRepository<Terminal>, ITerminalRepository
    {

        private readonly AppDbContext _context;
       
        public TerminalRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Terminal>> GetMerchantTerminal(string merchantId)
        {
           return await _context.Terminals.Where(m => m.MerchantId == merchantId).ToListAsync();
        }

        public async Task<Terminal> GetTerminalById(string id)
        {
           return await _context.Terminals.FirstOrDefaultAsync(x => x.TerminalId == id);
        }
    }
}
