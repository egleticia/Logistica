using Logistica.Application.UseCases.Message;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace Logistica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        IMediator _mediator;

        public MessageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateMessageRequest request)
        {
            var message = await _mediator.Send(request);
            return Ok(message);
        }
    }
}
