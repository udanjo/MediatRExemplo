using MediatR;
using MediatRExemplo.Domain.Interfaces;
using MediatRExemplo.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExemplo.Domain.Commands.Handlers
{
    public class AddAssetHandler : IRequestHandler<AddAssetCommand, AssetModel>
    {
        private readonly IDataAccess _dataAccess;

        public AddAssetHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<AssetModel> Handle(AddAssetCommand request, CancellationToken cancellationToken)
        {
            return _dataAccess.Add(request.Ticker, request.Name, request.Price);
        }
    }
}