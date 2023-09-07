﻿using ProesBack.Domain.Interfaces;
using ProesBack.Infrastructure.Data.Repositories;
using ProesBack.Interfaces;
using ProesBack.Services;
using System.Runtime.CompilerServices;

namespace ProesBack.Infrastructure.ExtensionMethods
{
    public static class CommonInjectDependence
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<ILoginViewModelService, LoginViewModelService>();
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ILoginRepository, LoginRepository>();
            return services;
        }
    }
}
