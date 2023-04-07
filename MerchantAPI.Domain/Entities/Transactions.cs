using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantAPI.Domain.Entities
{
    public class Transactions
    {
        [Key]
        public string TransactionId { get; set; } = Guid.NewGuid().ToString();
        public decimal Amount { get; set; }
        public string CardType { get; set; }
        public string RRN { get; set; }
        [ForeignKey("TerminalId")]
        public Terminal terminal { get; set; }
    }
}
