using AutoMapper;
using MerchantAPI.DTO;
using MerchantAPI.Interfaces;
using MerchantAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace MerchantAPI.Repository
{
    public class TerminalRepository : ITerminalRepository
    {
        private readonly MerchantDbContext _context;
        private readonly IMapper _mapper;
        public TerminalRepository(MerchantDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> CreateTerminal(TerminalDTO terminal)
        {
            var terminalEntity = _mapper.Map<Terminal>(terminal);
            _context.Terminals.Add(terminalEntity);
            await _context.SaveChangesAsync();
            return  terminalEntity.TerminalId;
        }

        public async Task<TerminalDTO> GetTerminal(int id)
        {
            var terminal = await _context.Terminals.FindAsync(id);
            return _mapper.Map<TerminalDTO>(terminal);
        }

        public async Task<IEnumerable<TerminalDTO>> GetTerminals()
        {
            var merchants = await _context.Terminals.ToListAsync();
            return _mapper.Map<IEnumerable<TerminalDTO>>(merchants);
        }
    }   
}
