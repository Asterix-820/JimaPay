using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JimaPay.Domain.Entities
{
    public class Transactions
    {
        [Key]
        public string TransactionId { get; set; } = Guid.NewGuid().ToString();
        public decimal Amount { get; set; }
        public string CardType { get; set; }
        public string RRN { get; set; }
        [ForeignKey("TerminalId")]
        public string TerminalId;
        public Terminal terminal { get; set; }
        [ForeignKey("MerchantId")]
        public string MerchantId;
        public Merchant merchant { get; set; }
    }
}
