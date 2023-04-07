using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantAPI.Common.DTO
{
    public class TransactionDTO
    {
        public decimal Amount { get; set; }
        public string CardType { get; set; } = string.Empty;
        public string RRN { get; set; } = string.Empty;
    }
}
