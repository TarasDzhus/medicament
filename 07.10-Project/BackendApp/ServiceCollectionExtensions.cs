using BackendApp.Interfaces;
using BackendApp.Services;
using BackendApp.Services.ServicesTime;
using Microsoft.Extensions.DependencyInjection;

namespace BackendApp
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IEmployeeInfoService, EmployeeInfoService>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IMedicamentService, MedicamentService>();
            services.AddTransient<IOrderService, OrderService>();

            services.AddTransient<ITimeService, TimeService>();
            return services;
        }
    }
}   
