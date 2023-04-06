using MerchantAPI.DTO;
using MerchantAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MerchantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MerchantController : ControllerBase
    {
        private readonly IMerchantRepository _repository;
        public MerchantController(IMerchantRepository repository)
        {
            _repository= repository;
        }
        [HttpPost("merchant")]
        public async Task<IActionResult> CreateNewMerchant(MerchantDTO merchant)
        {
            var output = await _repository.CreateNewMerchant(merchant);
            return Ok(output);
        }
        [HttpGet("merchant")]
        public async Task<IActionResult>GetMerchantById(string merchantId)
        {
            var output = await _repository.GetMerchantById(merchantId);
            return Ok(output);
        }
        [HttpGet("merchants")]
        public async Task<IActionResult> GetAllMerchants()
        {
            var output = await _repository.GetAllMerchants();
            return Ok(output);
        }
    }
}
