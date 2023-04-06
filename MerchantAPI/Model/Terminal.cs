using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MerchantAPI.Model
{
    public class Terminal
    {
       [Key]
        public string TerminalId { get; set; } = Guid.NewGuid().ToString();
        public string TerminalType { get; set; }
        public string Location { get; set; } 
        public ICollection<Transactions> Transactions { get; set; }
        [ForeignKey("MerchantId")]
        public Merchant merchant { get; set; }
    }
}
