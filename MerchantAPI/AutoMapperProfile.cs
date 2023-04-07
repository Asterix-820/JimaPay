using AutoMapper;
using MerchantAPI.Common.DTO;
using MerchantAPI.Domain.Entities;

namespace MerchantAPI
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
