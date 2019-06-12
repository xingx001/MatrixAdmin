﻿using Core.Api.Extensions.CustomException;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Api.Configurations
{
    public static class ValidateConfiguration
    {
        public static void AddService(IServiceCollection services)
        {
            services.AddMvc(s => s.Filters.Add(new ValidateModelAttribute()));
        }
    }
}