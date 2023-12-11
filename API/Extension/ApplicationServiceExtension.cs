using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP.UnitOfWork;
using Dominio.Interfaces;
using Microsoft.Extensions.Options;

namespace API.Extension
{
    public static class ApplicationServiceExtension
    {
        public static void  ConfigureCors(this IServiceCollection services ) =>
        services.AddCors(Options =>
        {
            Options.AddPolicy("CorsPolicy", builder =>
            builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
        });
        public static void AddAplicacionServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork,UnitOfWork >();
        }
            
            
        
    }
}