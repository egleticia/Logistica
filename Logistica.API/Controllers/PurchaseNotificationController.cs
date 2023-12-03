using Logistica.Application.UseCases.PurchaseNotification.CreatePurchaseNotification;
using Logistica.Application.UseCases.PurchaseNotification.DeletePurchaseNotification;
using Logistica.Application.UseCases.PurchaseNotification.GetAllPurchaseNotification;
using Logistica.Application.UseCases.PurchaseNotification.GetPurchaseNotificationById;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace Logistica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseNotificationController : ControllerBase
    {
        IMediator _mediator;

        public PurchaseNotificationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Obtém todas as notificações de compra
        /// </summary>
        /// <response code="200">Obtém todos os dados.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpGet]
        public async Task<ActionResult<List<GetAllPurchaseNotificationResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllPurchaseNotificationRequest(), cancellationToken);
            return Ok(response);
        }

        /// <summary>
        /// Obtém notificações de compra por Id
        /// </summary>
        /// <param name="id">Id da notificações de compra.</param>
        /// <response code="200">Obtém endereço.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpGet("{id}")]
        public async Task<ActionResult<GetPurchaseNotificationByIdResponse>> Get(Guid? id, CancellationToken cancellationToken)
        {
            if (id is null) { return BadRequest(); }

            var request = new GetPurchaseNotificationByIdRequest(id.Value);
            var response = await _mediator.Send(request, cancellationToken);

            if (response is null) { return NotFound(); }
            return Ok(response);
        }

        /// <summary>
        /// Cria notificaçõe de compra
        /// </summary>
        /// <param name="request">Dados da notificações de compra.</param>
        /// <response code="201">Cria notificações de compra.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpPost]
        public async Task<IActionResult> Create(CreatePurchaseNotificationRequest request)
        {
            var product = await _mediator.Send(request);
            return Ok(product);
        }

        /// <summary>
        /// Delete notificações de compra
        /// </summary>
        /// <param name="id">Id da notificações de compra.</param>
        /// <response code="200">Deleta notificações de compra.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid? id, CancellationToken cancellationToken)
        {
            if (id is null)
            {
                return BadRequest();
            }

            var deleteRequest = new DeletePurchaseNotificationRequest(id.Value);
            var response = await _mediator.Send(deleteRequest, cancellationToken);
            return Ok(response);
        }
    }
}
