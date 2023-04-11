using AutoMapper;
using JimaPay.Common.DTO;
using JimaPay.Domain.Entities;
using JimaPay.Repository.Data;
using JimaPay.Repository.Interfaces;
using Jimpay.Repository.Implementations;
using Microsoft.EntityFrameworkCore;

namespace JimaPay.Repository.Implementations
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
