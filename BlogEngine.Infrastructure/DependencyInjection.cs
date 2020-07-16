using System;
using System.Collections.Generic;
using System.Text;
using BlogEngine.Core.Interfaces;
using BlogEngine.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BlogEngine.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IPostRepository, PostRepository>();
            return services;
        }
    }
}
