using JimaPay.Common.DTO;
using JimaPay.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JimaPay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerminalController : ControllerBase
    {
        private readonly ITerminalService _terminalService;
        public TerminalController(ITerminalService terminalService)
        {
            _terminalService = terminalService;
        }

        [HttpPost("terminal")]
        public async Task<IActionResult> CreateTerminal(TerminalDTO terminal)
        {
            _terminalService.CreateTerminal(terminal);
            return Ok("Successful");
        }

        [HttpGet("terminal")]
        public async Task<IActionResult> GetTerminalById(string terminalId)
        {
            var output = await _terminalService.GetTerminalById(terminalId);
            return Ok(output);
        }

        [HttpGet("terminals")]
        public async Task<IActionResult> GetAllTerminals()
        {
            var output = await _terminalService.GetAllTerminals();
            return Ok(output);
        }
    }
}
