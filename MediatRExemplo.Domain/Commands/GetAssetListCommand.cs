using MediatR;
using MediatRExemplo.Domain.Models;
using System.Collections.Generic;

namespace MediatRExemplo.Domain.Commands
{
    public record GetAssetListCommand() : IRequest<IList<AssetModel>>
    {
    }
}