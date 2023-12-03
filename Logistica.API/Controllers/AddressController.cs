using Logistica.Application.UseCases.Address.CreateAddress;
using Logistica.Application.UseCases.Address.DeleteAddress;
using Logistica.Application.UseCases.Address.GetAddressById;
using Logistica.Application.UseCases.Address.GetAllAddress;
using Logistica.Application.UseCases.Address.UpdateAddress;
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

        /// <summary>
        /// Obtém todos os endereços
        /// </summary>
        /// <response code="200">Obtém todos os dados.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpGet]
        public async Task<ActionResult<List<GetAllAddressResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllAddressRequest(), cancellationToken);
            return Ok(response);
        }

        /// <summary>
        /// Obtém endereço por Id
        /// </summary>
        /// <param name="id">Id do endereço.</param>
        /// <response code="200">Obtém endereço.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpGet("{id}")]
        public async Task<ActionResult<GetAddressByIdResponse>> Get(Guid? id, CancellationToken cancellationToken)
        {
            if (id is null) { return BadRequest(); }

            var request = new GetAddressByIdRequest(id.Value);
            var response = await _mediator.Send(request, cancellationToken);

            if (response is null) { return NotFound(); }
            return Ok(response);
        }

        /// <summary>
        /// Atualiza endereço
        /// </summary>
        /// <param name="request">Dados do endereço.</param>
        /// <response code="200">Atualiza endereço.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateAddressResponse>>Update(Guid id, UpdateAddressRequest request, CancellationToken cancellationToken)
        {
            if (id != request.Id)
            {
                return BadRequest();
            }
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        /// <summary>
        /// Cria endereço
        /// </summary>
        /// <param name="request">Dados do endereço.</param>
        /// <response code="201">Cria endereço.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpPost]
        public async Task<IActionResult> Create(CreateAddressRequest request)
        {
            var product = await _mediator.Send(request);
            return Ok(product);
        }

        /// <summary>
        /// Delete endereço
        /// </summary>
        /// <param name="id">Id do endereço.</param>
        /// <response code="200">Deleta endereço.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid? id, CancellationToken cancellationToken)
        {
            if (id is null)
            {
                return BadRequest();
            }

            var deleteRequest = new DeleteAddressRequest(id.Value);
            var response = await _mediator.Send(deleteRequest, cancellationToken);
            return Ok(response);
        }
    }
}
