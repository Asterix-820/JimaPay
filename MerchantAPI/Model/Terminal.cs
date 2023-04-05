namespace MerchantAPI.Model
{
    public class Terminal
    {
        public string TerminalId { get; set; } = Guid.NewGuid().ToString();
        public string TerminalType { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public List<Transaction> Transactions { get; set; }
        public string MerchantId { get; set; }
        public Merchant merchant { get; set; }
    }
}
