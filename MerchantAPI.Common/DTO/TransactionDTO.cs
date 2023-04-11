namespace MerchantAPI.Common.DTO
{
    public class TransactionDTO
    {
        public decimal Amount { get; set; }
        public string CardType { get; set; } = string.Empty;
        public string RRN { get; set; } = string.Empty;
    }
}
