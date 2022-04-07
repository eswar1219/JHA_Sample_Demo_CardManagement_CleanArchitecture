using JHA_Core.Entities;
using JHA_Core.Repositories;
using JHA_Infrastructure.Data;
using JHA_Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHA_Infrastructure.Repositories
{
    public class CardRepository : Repository<CardDetails>, ICardRepository
    {
        public CardRepository(CardManagementContext cardContext) : base(cardContext) { }
        public async Task<IEnumerable<CardDetails>> GetCardByName(string cardName)
        {
            return await _cardManagementContext.CardDetails.Where(x => x.CardName == cardName).ToListAsync();
        }
    }
}
