using AutoMapper;
using Library.Domain;
using Library.Dto.Author;

namespace Library.API.Extensions.MapperProfiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorReadDto>();
            CreateMap<AuthorCreateDto, Author>();
            CreateMap<AuthorModifyDto, Author>();
        }
    }
}
