using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddExample(this IServiceCollection services)
        {
            services.AddScoped<IData, Data>();

            return services;
        }
    }
}
