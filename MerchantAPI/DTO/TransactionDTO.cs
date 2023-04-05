namespace MerchantAPI.DTO
{
    public class TransactionDTO
    {
        public string TransactionId { get; set; }
        public decimal Amount { get; set; }
        public string CardType { get; set; } = string.Empty;
        public string RRN { get; set; } = string.Empty;
        public string TerminalId { get; set; }
    }
}
