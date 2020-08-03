using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using AutoMapper;

namespace BlogEngine.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddTransient<IPostService, PostService>();
            return services;
        }
    }
}
