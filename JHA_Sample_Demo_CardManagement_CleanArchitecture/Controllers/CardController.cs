using JHA_Application.Commands;
using JHA_Application.Queries;
using JHA_Application.Responses;
using JHA_Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JHA_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<CardDetails>> Get()
        {
            return await _mediator.Send(new GetAllCardsQuery());
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CardResponse>> CreateCard([FromBody] CreateCardCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
