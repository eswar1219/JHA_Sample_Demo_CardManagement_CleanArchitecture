using JHA_Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHA_Application.Commands
{
    public class CreateCardCommand : IRequest<CardResponse>
    {
        public string CardName { get; set; }

        public string CardNumber { get; set; }

        public int CVV { get; set; }

        public DateTime ExpiryDate { get; set; }
    }
}
