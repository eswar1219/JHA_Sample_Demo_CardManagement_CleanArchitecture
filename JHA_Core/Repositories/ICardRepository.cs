using JHA_Core.Entities;
using JHA_Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHA_Core.Repositories
{
    public interface ICardRepository : IRepository<CardDetails>
    {
        Task<IEnumerable<CardDetails>> GetCardByName(string cardName);

    }
}
