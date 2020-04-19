using AutoMapper;
using Library.Data;
using Library.Domain;
using Library.Dto.Language;
using Library.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    public class LanguageController : BaseController<Language, LanguageService, LanguageReadDto, LanguageCreateDto, LanguageModifyDto>
    {
        public LanguageController(LanguageService service, IMapper mapper) : base(service, mapper) { }
    }
}
