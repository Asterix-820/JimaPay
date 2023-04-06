﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MerchantAPI.Model
{
    public class Transactions
    {
        public string TransactionId { get; set; } = Guid.NewGuid().ToString();
        public decimal Amount { get; set; }
        public string CardType { get; set; } 
        public string RRN { get; set; }
        [ForeignKey("TerminalId")]
        public Terminal terminal { get; set; }
    }
}
