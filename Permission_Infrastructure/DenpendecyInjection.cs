﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Permission_Application.Abstractions.Repositories;
using Permission_Application.Services.Teacher_S;
using Permission_Infrastructure.Repositories;
using VehicleManagement_Infrastructure.Repositories;

namespace Permission_Infrastructure
{
    public  static class DenpendecyInjection
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));


            services.AddScoped<IServiceTransport, ServiceTransport>();
            services.AddScoped<ITransportRepositories, TransportRepositories>();
            services.AddScoped<ITransportRepositories, TransportRepositories>();

            return services;
        }

    }
}