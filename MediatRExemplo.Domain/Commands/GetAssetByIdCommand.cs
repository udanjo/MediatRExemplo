using MediatR;
using MediatRExemplo.Domain.Models;

namespace MediatRExemplo.Domain.Commands
{
    public record GetAssetByIdCommand(string Ticker) : IRequest<AssetModel>
    {
    }
}