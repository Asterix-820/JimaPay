using MerchantAPI.Common.DTO;
using MerchantAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MerchantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerminalController : ControllerBase
    {
        private readonly ITerminalRepository _repository;
        public TerminalController(ITerminalRepository repository)
        {
            _repository = repository;
        }
        [HttpPost("terminal")]
        public async Task<IActionResult> CreateTerminal(TerminalDTO terminal, string merchantId)
        {
            var output = await _repository.CreateTerminal(terminal, merchantId);
            return Ok(output);
        }
        [HttpGet("terminal")]
        public async Task<IActionResult> GetMerchantTerminal(string merchantId)
        {
            var output = await _repository.GetMerchantTerminal(merchantId);
            return Ok(output);
        }
        [HttpGet("terminals")]
        public async Task<IActionResult> GetAllTerminals()
        {
            var output = await _repository.GetAllTerminals();
            return Ok(output);
        }
    }
}
