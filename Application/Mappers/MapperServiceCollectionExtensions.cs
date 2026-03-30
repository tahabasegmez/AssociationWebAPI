using Microsoft.Extensions.DependencyInjection;

namespace AssociationWebAPI.Application.Mappers;

public static class MapperServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationMappers(this IServiceCollection services)
    {
        services.AddAutoMapper(config => config.AddProfile<DtoMappingProfile>());
        return services;
    }
}

