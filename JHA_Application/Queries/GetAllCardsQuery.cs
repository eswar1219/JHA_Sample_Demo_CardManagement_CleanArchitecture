using JHA_Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHA_Application.Queries
{
    public class GetAllCardsQuery : IRequest<List<CardDetails>>
    {

    }
}
