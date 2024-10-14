using AElf.ExceptionHandler.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Orleans;

namespace AElf.ExceptionHandler.Orleans.Extensions;

public static class ExceptionHandlerConfigurationExtension
{
    public static IServiceCollection AddOrleansExceptionHandler(this IServiceCollection services)
    {
        services.AddExceptionHandler();
        return services.AddSingleton<IIncomingGrainCallFilter, AttributeCallFilter>();
    }
}