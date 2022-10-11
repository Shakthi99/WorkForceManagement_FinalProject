using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WfmManagementAPI.Interface;
using WfmManagementAPI.Service;

namespace WfmManagementAPI.Models

{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddWfmService(this IServiceCollection service)
        {
            service.TryAddScoped<IManagerService, ManagerService>();
            return service;
        }
    }
}
