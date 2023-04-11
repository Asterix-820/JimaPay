using AutoMapper;
using MerchantAPI.Common.DTO;
using MerchantAPI.Domain.Entities;
using MerchantAPI.Repository.Implementations;
using MerchantAPI.Repository.Interfaces;
using MerchantAPI.Services.Interfaces;

namespace MerchantAPI.Services.Implementations
{
    public class TransactionService : ITransactionService
    {

        private readonly ITransactionRepository _transactionRepository;
        private readonly IMapper _mapper;
        public TransactionService(ITransactionRepository transactionRepository, IMapper mapper)
        {
            _transactionRepository = transactionRepository;
            _mapper = mapper;
        }
        public void CreateTransaction(TransactionDTO transaction)
        {
            var transactionEntity = _mapper.Map<Transactions>(transaction);
            _transactionRepository.Create(transactionEntity);
        }

        public async Task<IEnumerable<TransactionDTO>> GetAllTransactions()
        {
            var transaction = await _transactionRepository.GetAll();
            var mappedTransactions = _mapper.Map<IEnumerable<TransactionDTO>>(transaction);
            return mappedTransactions;
        }

        public async Task<TransactionDTO> GetTransactionById(string id)
        {
            var transaction = await _transactionRepository.GetTransactionById(id);

            if (transaction != null)
            {
                var transactionEntity = _mapper.Map<TransactionDTO>(transaction);
                return transactionEntity;
            }
            throw new Exception("Transaction not found");
        }

        public void UpdateTransaction(TransactionDTO transaction)
        {
            var transactionEntity = _mapper.Map<Transactions>(transaction);
            _transactionRepository.Update(transactionEntity);
        }

        public async Task DeleteTransaction(string id)
        {
            var transaction = await _transactionRepository.GetTransactionById(id);

            if (transaction != null)
            {
                _transactionRepository.Delete(transaction);
            }
            throw new Exception("Requested Transaction not found");
        }
    }
}
