using MediatR;
using MediatRExemplo.Domain.Commands;
using MediatRExemplo.Domain.Commands.Handlers;
using MediatRExemplo.Domain.Interfaces;
using MediatRExemplo.Domain.Models;
using MediatRExemplo.Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace MediatRExemplo.Infra.DependencyInjection
{
    public static class IoC
    {
        public static IServiceCollection ConfigureRegister(this IServiceCollection services)
        {
            services.AddScoped<IDataAccess, DataAccess>();
            services.AddScoped<IRequestHandler<GetAssetListCommand, IList<AssetModel>>, GetAssetListHandler>();
            services.AddScoped<IRequestHandler<GetAssetByIdCommand, AssetModel>, GetAssetHandler>();
            services.AddScoped<IRequestHandler<AddAssetCommand, AssetModel>, AddAssetHandler>();

            return services;
        }
    }
}