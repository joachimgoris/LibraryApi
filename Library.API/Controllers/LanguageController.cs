using Library.Data;
using Library.Domain;
using Library.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageService<Language, LibraryContext> _service;

        public LanguageController(ILanguageService<Language, LibraryContext> languageService)
        {
            _service = languageService;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Language>>> GetAll()
        {
            return await _service.GetAll().ToListAsync();
        }
    }
}
