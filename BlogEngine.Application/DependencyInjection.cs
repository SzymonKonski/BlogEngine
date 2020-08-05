using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using AutoMapper;
using BlogEngine.Application.Interfaces;
using BlogEngine.Application.Services;
using BlogEngine.Application.Mapping;

namespace BlogEngine.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient<IPostService, PostService>();
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
