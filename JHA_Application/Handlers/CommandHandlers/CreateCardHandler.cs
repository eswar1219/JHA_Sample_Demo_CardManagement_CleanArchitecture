using JHA_Application.Commands;
using JHA_Application.Mapper;
using JHA_Application.Responses;
using JHA_Core.Entities;
using JHA_Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHA_Application.Handlers.CommandHandlers
{
    public class CreateCardHandler : IRequestHandler<CreateCardCommand, CardResponse>
    {
        private readonly ICardRepository _cardRepo;
        public CreateCardHandler(ICardRepository cardRepository)
        {
            _cardRepo = cardRepository;
        }
        public async Task<CardResponse> Handle(CreateCardCommand request, CancellationToken cancellationToken)
        {
            var cardEntitiy = CardMapper.Mapper.Map<CardDetails>(request);
            if (cardEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newCard = await _cardRepo.AddAsync(cardEntitiy);
            var cardResponse = CardMapper.Mapper.Map<CardResponse>(newCard);
            return cardResponse;
        }
    }
}
