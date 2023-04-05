namespace MerchantAPI.DTO
{
    public class TerminalDTO
    {
        public string TerminalId { get; set; }
        public string TerminalType { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string MerchantId { get; set; }
    }
}
