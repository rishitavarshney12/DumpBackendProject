using Employee.DAL.Repositories;
using Employee.Domain.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Service.ServicesWireup
{
    public static class RegisterService
    {
        public static IServiceCollection RegisterDependencies(this IServiceCollection services)
        {
            services.AddScoped<IEmpService, EmpService>();
            //Processor name
            services.AddScoped<IEmpTableRepository, EmpTableRepository>();
            return services;

        }
    }
}
