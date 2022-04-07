using AutoMapper;
using JHA_Application.Commands;
using JHA_Application.Responses;
using JHA_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHA_Application.Mapper
{
    public class CardMappingProfile : Profile
    {
        public CardMappingProfile()
        {
            CreateMap<CardDetails, CardResponse>().ReverseMap();

            CreateMap<CardDetails, CreateCardCommand>().ReverseMap();
        }
    }
}
