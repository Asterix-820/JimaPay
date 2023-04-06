using MerchantAPI.DTO;
using MerchantAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MerchantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionRepository _repository;
        public TransactionController(ITransactionRepository repository)
        {
            _repository = repository;
        }
        [HttpPost("transaction")]
        public async Task<IActionResult> CreateTransaction(TransactionDTO transaction, string merchantId)
        {
            var output = await _repository.CreateTransaction(transaction, merchantId);
            return Ok(output);
        }
        [HttpGet("transaction")]
        public async Task<IActionResult> GetTerminalTransaction(string merchantId, string terminalId)
        {
            var output = await _repository.GetTerminalTransactions(merchantId, terminalId);
            return Ok(output);
        }
        [HttpGet("transactions")]
        public async Task<IActionResult> GetAllTransactions()
        {
            var output = await _repository.GetAllTransactions();
            return Ok(output);
        }
    }
}
