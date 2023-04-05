using AutoMapper;
using MerchantAPI.DTO;
using MerchantAPI.Model;

namespace MerchantAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Merchant, MerchantDTO>().ReverseMap();
            CreateMap<Terminal, TerminalDTO>().ReverseMap();
            CreateMap<Transaction, TransactionDTO>().ReverseMap();
        }
    }
}
