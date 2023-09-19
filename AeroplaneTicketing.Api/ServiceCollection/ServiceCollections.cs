using AeroplaneTicketing.Api.Services;

namespace AeroplaneTicketing.Api.ServiceCollection
{
    public static class ServiceCollections
    {
        public static IServiceCollection AddServicesDI(this IServiceCollection services)
        {

            services.AddScoped<ITicketService, TicketService>();
           


            return services;
        }
    }
}
