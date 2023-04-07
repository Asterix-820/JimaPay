﻿using AutoMapper;
using MerchantAPI.Common.DTO;
using MerchantAPI.Domain.Entities;
using MerchantAPI.Repository.Data;
using MerchantAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantAPI.Repository.Implementations
{
    public class TerminalRepository : ITerminalRepository
    {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public TerminalRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<string> CreateTerminal(TerminalDTO terminal, string merchantId)
        {
            var ExistingMerchant = _context.Merchants.FirstOrDefault(m => m.MerchantId == merchantId);
            if (ExistingMerchant == null)
            {
                return "Invalid Merchant Credentials";
            }
            var terminalEntity = _mapper.Map<Terminal>(terminal);
            terminalEntity.merchant = ExistingMerchant;
            _context.Terminals.Add(terminalEntity);
            await _context.SaveChangesAsync();
            return terminalEntity.TerminalId;
        }

        public async Task<IEnumerable<TerminalDTO>> GetAllTerminals()
        {
            var terminals = await _context.Terminals.ToListAsync();
            return _mapper.Map<IEnumerable<TerminalDTO>>(terminals);
        }

        public async Task<IEnumerable<TerminalDTO>> GetMerchantTerminal(string merchantId)
        {
            var merchantTerminal = await _context.Terminals.Where(m => m.merchant.MerchantId == merchantId).ToListAsync();
            return _mapper.Map<IEnumerable<TerminalDTO>>(merchantTerminal);
        }

        public async Task<TerminalDTO> GetTerminalById(string id)
        {
            var terminal = await _context.Terminals.FindAsync(id);
            return _mapper.Map<TerminalDTO>(terminal);
        }
    }
}