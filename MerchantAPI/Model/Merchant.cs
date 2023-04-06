using System.ComponentModel.DataAnnotations;

namespace MerchantAPI.Model
{
    public class Merchant
    {
        [Key]
        public string MerchantId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty; 
        public string Email { get; set; } = string.Empty;       
        public string Phone { get; set; } = string.Empty;   
        public ICollection <Terminal> Terminals { get; set; }
    }
}
