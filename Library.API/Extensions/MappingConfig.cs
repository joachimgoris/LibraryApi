using AutoMapper;
using Library.API.Extensions.MapperProfiles;
using Microsoft.Extensions.DependencyInjection;

namespace Library.API.Extensions
{
    public static class MappingConfig
    {
        internal static void RegisterAutoMapperProfiles(IServiceCollection services)
        {
            services.AddAutoMapper(
                typeof(AuthorProfile),
                typeof(LanguageProfile)
                );
        }
    }
}
