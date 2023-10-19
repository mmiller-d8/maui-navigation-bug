using System;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;

namespace NavigationBug.Extensions;

public static class IDependencyInjectionExtensions
{

    public static IServiceCollection AddDerivedTypes<T>(this IServiceCollection services, string nameEndsWith = null)
    {
        var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(domainAssembly => domainAssembly.GetTypes())
            .Where(type =>
                (typeof(T).IsAssignableFrom(type)
                || (nameEndsWith != null && type.Name.EndsWith(nameEndsWith, StringComparison.OrdinalIgnoreCase)))
                && type != typeof(T)
                && !type.IsAbstract
            ).ToList();

        foreach (var type in types)
        {
            var attribute = type.GetCustomAttributes<DependencyInjectedAttribute>(true).FirstOrDefault();
            if (attribute == null || attribute.Lifetime == DependencyInjectionLifetime.Transient)
                services.TryAddTransient(type);
            else if (attribute.Lifetime == DependencyInjectionLifetime.Singleton)
                services.TryAddSingleton(type);
            else if (attribute.Lifetime == DependencyInjectionLifetime.Scoped)
                services.TryAddScoped(type);
        }

        return services;
    }

}

