using MediatRExemplo.Domain.Models;
using System.Collections.Generic;

namespace MediatRExemplo.Domain.Interfaces
{
    public interface IDataAccess
    {
        IList<AssetModel> GetAssets();

        AssetModel Add(string ticker, string name, decimal price);
    }
}