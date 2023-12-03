using Logistica.Application.UseCases.Receiver.CreateReceiver;
using Logistica.Application.UseCases.Receiver.DeleteReceiver;
using Logistica.Application.UseCases.Receiver.GetAllReceiver;
using Logistica.Application.UseCases.Receiver.GetReceiverById;
using Logistica.Application.UseCases.Receiver.UpdateReceiver;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace Logistica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiverController : ControllerBase
    {
        IMediator _mediator;

        public ReceiverController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Obtém todos os recebedores
        /// </summary>
        /// <response code="200">Obtém todos os dados.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpGet]
        public async Task<ActionResult<List<GetAllReceiverResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllReceiverRequest(), cancellationToken);
            return Ok(response);
        }

        /// <summary>
        /// Obtém recebedor por Id
        /// </summary>
        /// <param name="id">Id do recebedor.</param>
        /// <response code="200">Obtém recebedor.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpGet("{id}")]
        public async Task<ActionResult<GetReceiverByIdResponse>> Get(Guid? id, CancellationToken cancellationToken)
        {
            if (id is null) { return BadRequest(); }

            var request = new GetReceiverByIdRequest(id.Value);
            var response = await _mediator.Send(request, cancellationToken);

            if (response is null) { return NotFound(); }
            return Ok(response);
        }

        /// <summary>
        /// Atualiza recebedor
        /// </summary>
        /// <param name="request">Dados do recebedor.</param>
        /// <response code="200">Atualiza recebedor.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateReceiverResponse>> Update(Guid id, UpdateReceiverRequest request, CancellationToken cancellationToken)
        {
            if (id != request.Id)
            {
                return BadRequest();
            }
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        /// <summary>
        /// Cria recebedor
        /// </summary>
        /// <param name="request">Dados do recebedor.</param>
        /// <response code="201">Cria recebedor.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpPost]
        public async Task<IActionResult> Create(CreateReceiverRequest request)
        {
            var product = await _mediator.Send(request);
            return Ok(product);
        }

        /// <summary>
        /// Delete recebedor
        /// </summary>
        /// <param name="id">Id do recebedor.</param>
        /// <response code="200">Deleta recebedor.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid? id, CancellationToken cancellationToken)
        {
            if (id is null)
            {
                return BadRequest();
            }

            var deleteRequest = new DeleteReceiverRequest(id.Value);
            var response = await _mediator.Send(deleteRequest, cancellationToken);
            return Ok(response);
        }
    }
}
