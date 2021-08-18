using MediatR;
using MediatRExemplo.Domain.Interfaces;
using MediatRExemplo.Domain.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExemplo.Domain.Commands.Handlers
{
    public class GetAssetListHandler : IRequestHandler<GetAssetListCommand, IList<AssetModel>>
    {
        private readonly IDataAccess _dataAccess;

        public GetAssetListHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IList<AssetModel>> Handle(GetAssetListCommand request, CancellationToken cancellationToken)
        {
            return _dataAccess.GetAssets();
        }
    }
}