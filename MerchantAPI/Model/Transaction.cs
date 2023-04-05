namespace MerchantAPI.Model
{
    public class Transaction
    {
        public string TransactionId { get; set; } = Guid.NewGuid().ToString();
        public decimal Amount { get; set; }
        public string CardType { get; set; } = string.Empty;
        public string RRN { get; set; } = string.Empty;
        public string TerminalId { get; set; }
        public Terminal terminal { get; set; }
    }
}
