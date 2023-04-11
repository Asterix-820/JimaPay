using AutoMapper;
using JimaPay.Common.DTO;
using JimaPay.Domain.Entities;
using JimaPay.Repository.Implementations;
using JimaPay.Repository.Interfaces;
using JimaPay.Services.Interfaces;

namespace JimaPay.Services.Implementations
{
    public class TerminalService : ITerminalService
    {
        private readonly ITerminalRepository _terminalRepository;
        private readonly IMapper _mapper;
        public TerminalService(ITerminalRepository terminalRepository, IMapper mapper)
        {
            _terminalRepository = terminalRepository;
            _mapper = mapper;
        }

        public void CreateTerminal(TerminalDTO terminal)
        {
            var terminalEntity = _mapper.Map<Terminal>(terminal);
            _terminalRepository.Create(terminalEntity);
        }

        public async Task<IEnumerable<TerminalDTO>> GetAllTerminals()
        {
            var terminals = await _terminalRepository.GetAll();
            var mappedTerminals = _mapper.Map<IEnumerable<TerminalDTO>>(terminals);
            return mappedTerminals;
        }

        public async Task<TerminalDTO> GetTerminalById(string id)
        {
            var terminal = await _terminalRepository.GetTerminalById(id);

            if (terminal != null)
            {
                var terminalEntity = _mapper.Map<TerminalDTO>(terminal);
                return terminalEntity;
            }
            throw new Exception("Terminal not found");
        }

        public void UpdateTerminal(TerminalDTO terminal)
        {
            var terminalEntity = _mapper.Map<Terminal>(terminal);
            _terminalRepository.Update(terminalEntity);
        }

        public async Task DeleteTerminal(string id)
        {
            var terminal = await _terminalRepository.GetTerminalById(id);

            if (terminal != null)
            {
                _terminalRepository.Delete(terminal);
            }
            throw new Exception("Requested Terminal not found");
        }
    }
}
