using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantAPI.Domain.Entities
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
