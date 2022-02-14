using ChannelEngineExercise.Shared.Interfaces;
using ChannelEngineExercise.Shared.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChannelEngineExercise.WEB.Extensions
{
    public static class IServiceCollectionExtension
    {
        public static void ResolveCoreServices(this IServiceCollection services)
        {
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddHttpClient();
        }
    }
}
