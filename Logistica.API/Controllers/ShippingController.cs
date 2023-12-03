using Logistica.Application.UseCases.Shipping.CreateShipping;
using Logistica.Application.UseCases.Shipping.DeleteShipping;
using Logistica.Application.UseCases.Shipping.GetAllShipping;
using Logistica.Application.UseCases.Shipping.GetShippingById;
using Logistica.Application.UseCases.Shipping.UpdateShipping;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Logistica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingController : ControllerBase
    {
        IMediator _mediator;

        public ShippingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Obtém todas as entregas
        /// </summary>
        /// <response code="200">Obtém todos os dados.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpGet]
        public async Task<ActionResult<List<GetAllShippingResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllShippingRequest(), cancellationToken);
            return Ok(response);
        }

        /// <summary>
        /// Obtém entrega por Id
        /// </summary>
        /// <param name="id">Id da entrega.</param>
        /// <response code="200">Obtém entrega.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpGet("{id}")]
        public async Task<ActionResult<GetShippingByIdResponse>> Get(Guid? id, CancellationToken cancellationToken)
        {
            if (id is null) { return BadRequest(); }

            var request = new GetShippingByIdRequest(id.Value);
            var response = await _mediator.Send(request, cancellationToken);

            if (response is null) { return NotFound(); }
            return Ok(response);
        }

        /// <summary>
        /// Atualiza entrega
        /// </summary>
        /// <param name="request">Dados da entrega.</param>
        /// <response code="200">Atualiza entrega.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateShippingResponse>> Update(Guid id, UpdateShippingRequest request, CancellationToken cancellationToken)
        {
            if (id != request.Id)
            {
                return BadRequest();
            }
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        /// <summary>
        /// Cria entrega
        /// </summary>
        /// <param name="request">Dados da entrega.</param>
        /// <response code="201">Cria entrega.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpPost]
        public async Task<IActionResult> Create(CreateShippingRequest request)
        {
            var product = await _mediator.Send(request);
            return Ok(product);
        }

        /// <summary>
        /// Delete entrega
        /// </summary>
        /// <param name="id">Id da entrega.</param>
        /// <response code="200">Deleta entrega.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid? id, CancellationToken cancellationToken)
        {
            if (id is null)
            {
                return BadRequest();
            }

            var deleteRequest = new DeleteShippingRequest(id.Value);
            var response = await _mediator.Send(deleteRequest, cancellationToken);
            return Ok(response);
        }
    }
}
