using MediatR;
using MediatRExemplo.Api.Request;
using MediatRExemplo.Domain.Commands;
using MediatRExemplo.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediatRExemplo.Api.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[Controller]")]
    [ApiController]
    public class AssetController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AssetController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IList<AssetModel>> Get()
        {
            return await _mediator.Send(new GetAssetListCommand());
        }

        [HttpGet("{ticker}")]
        public async Task<AssetModel> Get(string ticker)
        {
            return await _mediator.Send(new GetAssetByIdCommand(ticker));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RequestPostAsset request)
        {
            var command = request.ToCommand();
            var result = await _mediator.Send(command);

            return result != null
                ? Ok(result)
                : BadRequest("Não foi possível Incluir");
        }
    }
}