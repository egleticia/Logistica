using Logistica.Application.UseCases.Address.CreateAddress;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace Logistica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        IMediator _mediator;

        public AddressController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAddressRequest request)
        {
            var product = await _mediator.Send(request);
            return Ok(product);
        }
    }
}
