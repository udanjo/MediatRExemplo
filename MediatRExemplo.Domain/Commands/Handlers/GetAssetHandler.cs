using MediatR;
using MediatRExemplo.Domain.Interfaces;
using MediatRExemplo.Domain.Models;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExemplo.Domain.Commands.Handlers
{
    public class GetAssetHandler : IRequestHandler<GetAssetByIdCommand, AssetModel>
    {
        private readonly IDataAccess _dataAccess;

        public GetAssetHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<AssetModel> Handle(GetAssetByIdCommand request, CancellationToken cancellationToken)
        {
            var assets = _dataAccess.GetAssets();
            return assets?.FirstOrDefault(x => x.Ticker == request.Ticker.ToUpper());
        }
    }
}