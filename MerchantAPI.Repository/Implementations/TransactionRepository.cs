using AutoMapper;
using MerchantAPI.Common.DTO;
using MerchantAPI.Domain.Entities;
using MerchantAPI.Repository.Data;
using MerchantAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MerchantAPI.Repository.Implementations
{
    public class TransactionRepository :ITransactionRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public TransactionRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<string> CreateTransaction(TransactionDTO transaction, string merchantId)
        {
            var merchantTransaction = await _context.Terminals.FirstOrDefaultAsync(t => t.merchant.MerchantId == merchantId);
            if (merchantTransaction == null)
            {
                return "Invalid Transaction Credentials";
            }

            var transactionEntity = _mapper.Map<Transactions>(transaction);
            transactionEntity.terminal = merchantTransaction;
            _context.Transactions.Add(transactionEntity);
            await _context.SaveChangesAsync();
            return transactionEntity.TransactionId;
        }

        public async Task<TransactionDTO> GetTransactionById(string id)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            return _mapper.Map<TransactionDTO>(transaction);
        }

        public async Task<IEnumerable<TransactionDTO>> GetAllTransactions()
        {
            var transactions = await _context.Transactions.ToListAsync();
            return _mapper.Map<IEnumerable<TransactionDTO>>(transactions);
        }

        public async Task<IEnumerable<TransactionDTO>> GetTerminalTransactions(string merchantId, string terminalId)
        {
            var terminalTransaction = await _context.Terminals.Where(t => t.merchant.MerchantId == merchantId && t.TerminalId == terminalId).ToListAsync();
            return _mapper.Map<IEnumerable<TransactionDTO>>(terminalTransaction);
        }
    }
}
