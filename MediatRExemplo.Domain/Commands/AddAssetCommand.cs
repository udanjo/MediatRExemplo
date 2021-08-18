using MediatR;
using MediatRExemplo.Domain.Models;

namespace MediatRExemplo.Domain.Commands
{
    public class AddAssetCommand : IRequest<AssetModel>
    {
        public string Ticker { get; }
        public string Name { get; }
        public decimal Price { get; }

        public AddAssetCommand(string ticker, string name, decimal price)
        {
            Ticker = ticker;
            Name = name;
            Price = price;
        }
    }
}