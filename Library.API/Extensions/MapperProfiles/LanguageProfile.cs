using AutoMapper;
using Library.Domain;
using Library.Dto.Language;

namespace Library.API.Extensions.MapperProfiles
{
    public class LanguageProfile: Profile
    {
        public LanguageProfile()
        {
            CreateMap<Language, LanguageReadDto>();
            CreateMap<LanguageCreateDto, Language>();
            CreateMap<LanguageModifyDto, Language>();
        }
    }
}
