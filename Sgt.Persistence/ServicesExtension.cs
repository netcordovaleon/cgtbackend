using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using Sgt.Application.Repository;
using Sgt.Persistence.Generic;
using Sgt.Persistence.MongoSetting;

namespace Sgt.Persistence;

public static class ServiceExtensions
{
    public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetSection("MongoDbSettings:ConnectionString").Value;
        var databaseName = configuration.GetSection("MongoDbSettings:DatabaseName").Value;
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(databaseName);
        // Register the MongoDB context or direct collections
        services.AddSingleton<IMongoDatabase>(database);
        // Register the generic repository for dependency injection
        // Note: You might need a factory or custom logic to handle collection names for different types
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
    }
}

