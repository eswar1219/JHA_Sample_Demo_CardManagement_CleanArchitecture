using JHA_Application.Queries;
using JHA_Core.Entities;
using JHA_Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHA_Application.Handlers.QueryHandlers
{

    public class GetAllCardHandler : IRequestHandler<GetAllCardsQuery, List<CardDetails>>
    {
        private readonly ICardRepository _cardRepo;

        public GetAllCardHandler(ICardRepository cardRepository)
        {
            _cardRepo = cardRepository;
        }
        public async Task<List<CardDetails>> Handle(GetAllCardsQuery request, CancellationToken cancellationToken)
        {
            return (List<CardDetails>)await _cardRepo.GetAllAsync();
        }
    }

}
