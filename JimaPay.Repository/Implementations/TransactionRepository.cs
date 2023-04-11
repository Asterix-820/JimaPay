using AutoMapper;
using JimaPay.Common.DTO;
using JimaPay.Domain.Entities;
using JimaPay.Repository.Data;
using JimaPay.Repository.Interfaces;
using Jimpay.Repository.Implementations;
using Microsoft.EntityFrameworkCore;

namespace JimaPay.Repository.Implementations
{
    public class TransactionRepository : GenericRepository<Transactions>, ITransactionRepository
    {
        private readonly AppDbContext _context;
        public TransactionRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Transactions> GetTransactionById(string id)
        {
            return await _context.Transactions.FirstOrDefaultAsync(x => x.TransactionId == id);
        }

        public async Task<IEnumerable<Transactions>> GetTerminalTransactions(string merchantId, string terminalId)
        {
            return await _context.Transactions.Where(t => t.MerchantId == merchantId && t.TerminalId == terminalId).ToListAsync();  
        }
    }
}
