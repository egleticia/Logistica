using Logistica.Application.UseCases.Address.UpdateAddress;
using Logistica.Application.UseCases.Product.CreateProduct;
using Logistica.Application.UseCases.Product.DeleteProduct;
using Logistica.Application.UseCases.Product.GetAllProduct;
using Logistica.Application.UseCases.Product.GetProductById;
using Logistica.Application.UseCases.Product.UpdateProduct;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace Logistica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Obtém todos os produtos
        /// </summary>
        /// <response code="200">Obtém todos os dados.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpGet]
        public async Task<ActionResult<List<GetAllProductResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllAProductRequest(), cancellationToken);
            return Ok(response);
        }

        /// <summary>
        /// Obtém produto por Id
        /// </summary>
        /// <param name="id">Id do produto.</param>
        /// <response code="200">Obtém prosuto.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpGet("{id}")]
        public async Task<ActionResult<GetProductByIdResponse>> Get(Guid? id, CancellationToken cancellationToken)
        {
            if (id is null) { return BadRequest(); }

            var request = new GetProductByIdRequest(id.Value);
            var response = await _mediator.Send(request, cancellationToken);

            if (response is null) { return NotFound(); }
            return Ok(response);
        }

        /// <summary>
        /// Atualiza produto
        /// </summary>
        /// <param name="request">Dados do produto.</param>
        /// <response code="200">Atualiza produto.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateProductResponse>> Update(Guid id, UpdateAddressRequest request, CancellationToken cancellationToken)
        {
            if (id != request.Id)
            {
                return BadRequest();
            }
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        /// <summary>
        /// Cria produto
        /// </summary>
        /// <param name="request">Dados do produto.</param>
        /// <response code="201">Cria produto.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductRequest request)
        {
            var product = await _mediator.Send(request);
            return Ok(product);
        }

        /// <summary>
        /// Delete produto
        /// </summary>
        /// <param name="id">Id do produto.</param>
        /// <response code="200">Deleta produto.</response>
        /// <response code="400">Requisição inválida ou erro.</response>
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid? id, CancellationToken cancellationToken)
        {
            if (id is null)
            {
                return BadRequest();
            }

            var deleteRequest = new DeleteProductRequest(id.Value);
            var response = await _mediator.Send(deleteRequest, cancellationToken);
            return Ok(response);
        }
    }
}
