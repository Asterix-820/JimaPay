using MerchantAPI.Common.DTO;
using MerchantAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MerchantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MerchantController : ControllerBase
    {
        private readonly IMerchantService _merchantService;
        public MerchantController(IMerchantService merchantService)
        {
           _merchantService = merchantService;
        }

        [HttpPost("merchant")]
        public async Task<IActionResult> CreateMerchant(MerchantDTO merchant)
        {
            _merchantService.CreateMerchant(merchant);
            return Ok("Successful");
        }

        [HttpGet("merchant")]
        public async Task<IActionResult>GetMerchantById(string merchantId)
        {
            var output = await _merchantService.GetMerchantById(merchantId);
            return Ok(output);
        }

        [HttpGet("merchants")]
        public async Task<IActionResult> GetAllMerchants()
        {
            var output = await _merchantService.GetAllMerchants();
            return Ok(output);
        }
    }
}
