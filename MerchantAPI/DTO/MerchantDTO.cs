namespace MerchantAPI.DTO
{
    public class MerchantDTO
    {   
        public string MerchantId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}
