using JimaPay.Common.DTO;
using JimaPay.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JimaPay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost("transaction")]
        public async Task<IActionResult> CreateTransaction(TransactionDTO transaction)
        {
            _transactionService.CreateTransaction(transaction);
            return Ok("Successful");
        }

        [HttpGet("transaction")]
        public async Task<IActionResult> GetTransactionById(string transactionId)
        {
            var output = await _transactionService.GetTransactionById(transactionId);
            return Ok(output);
        }

        [HttpGet("transactions")]
        public async Task<IActionResult> GetAllTransactions()
        {
            var output = await _transactionService.GetAllTransactions();
            return Ok(output);
        }
    }
}
