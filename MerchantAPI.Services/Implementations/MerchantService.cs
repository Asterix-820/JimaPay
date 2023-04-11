using AutoMapper;
using MerchantAPI.Common.DTO;
using MerchantAPI.Domain.Entities;
using MerchantAPI.Repository.Interfaces;
using MerchantAPI.Services.Interfaces;

namespace MerchantAPI.Services.Implementations
{
    public class MerchantService : IMerchantService
    {
        private readonly IMerchantRepository _merchantRepository;
        private readonly IMapper _mapper;
        public MerchantService(IMerchantRepository merchantRepository, IMapper mapper )
        {
            _merchantRepository = merchantRepository;
            _mapper = mapper;   
        }
        public void CreateMerchant(MerchantDTO merchant)
        {
            var merchantEntity = _mapper.Map<Merchant>(merchant);
            _merchantRepository.Create(merchantEntity);
        }

        public async Task<IEnumerable<MerchantDTO>> GetAllMerchants()
        {
            var merchants = await _merchantRepository.GetAll();
            var mappedMerchants = _mapper.Map<IEnumerable<MerchantDTO>>(merchants);
            return mappedMerchants;
        }

        public async Task<MerchantDTO> GetMerchantById(string id)
        {
            var merchant = await _merchantRepository.GetMerchantById(id);

            if(merchant != null) 
            {
                var merchantEntity = _mapper.Map<MerchantDTO>(merchant);
                return merchantEntity;
            }
            throw new Exception("Merchant not found");
        }
        
        public void UpdateMerchant(MerchantDTO merchant)
        {
            var merchantEntity = _mapper.Map<Merchant>(merchant);
            _merchantRepository.Update(merchantEntity);
        }

        public async Task DeleteMerchant(string id) 
        {
            var merchant = await _merchantRepository.GetMerchantById(id);

            if(merchant != null)
            {
                _merchantRepository.Delete(merchant);
            }
            throw new Exception("Requested Merchant not found");
        }
    }
}
