using MediatRExemplo.Domain.Interfaces;
using MediatRExemplo.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace MediatRExemplo.Domain.Repositories
{
    public class DataAccess : IDataAccess
    {
        private List<AssetModel> _assets = new();

        public DataAccess()
        {
            _assets.Add(new AssetModel { Ticker = "BIDI4", Name = "BANCO INTER", Price = (decimal)21.5 });
            _assets.Add(new AssetModel { Ticker = "EGIE3", Name = "ENGIE BRASIL", Price = (decimal)37.33 });
        }

        public IList<AssetModel> GetAssets()
        {
            return _assets;
        }

        public AssetModel Add(string ticker, string name, decimal price)
        {
            if (!_assets.Any(w => w.Ticker == ticker))
            {
                return (AssetModel)(new() { Ticker = ticker, Name = name, Price = price });
            }
            else
            {
                return _assets.Find(w => w.Ticker == ticker);
            }
        }
    }
}