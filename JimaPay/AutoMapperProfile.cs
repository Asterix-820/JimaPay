using AutoMapper;
using JimaPay.Common.DTO;
using JimaPay.Domain.Entities;

namespace JimaPay
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Merchant, MerchantDTO>().ReverseMap();
            CreateMap<Terminal, TerminalDTO>().ReverseMap();
            CreateMap<Transactions, TransactionDTO>().ReverseMap();
        }
    }
}
