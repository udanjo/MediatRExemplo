using MediatRExemplo.Domain.Commands;

namespace MediatRExemplo.Api.Request
{
    public class RequestPostAsset
    {
        public string Ticker { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }


        public AddAssetCommand ToCommand()
        {
            return new(Ticker.ToUpper(), Name, Price);
        }
    }
}