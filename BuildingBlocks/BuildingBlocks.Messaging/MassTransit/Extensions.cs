﻿using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlocks.Messaging.MassTransit;

public static class Extensions
{
    public static IServiceCollection AddMessageBroker(this IServiceCollection services, AssemblyLoadEventArgs? assembly = null)
    {

        return services;
    }
}
