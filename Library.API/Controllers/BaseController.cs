using AutoMapper;
using Library.Data;
using Library.Domain;
using Library.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    public class BaseController<T, TService, TReadDto, TCreateDto, TModifyDto> : ControllerBase, IBaseController<T, TReadDto, TCreateDto, TModifyDto>
        where T : Entity
        where TService : IBaseService<T, LibraryContext>
    {
        public TService _service;
        public IMapper _mapper;

        public BaseController(TService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpDelete]
        public virtual async Task<IActionResult> Delete(string entityID)
        {
            await Task.Run(() => _service.Delete(entityID)).ConfigureAwait(true);

            return NoContent();
        }

        [HttpGet("{entityID}")]
        public virtual async Task<ActionResult<TReadDto>> Get(string entityID)
        {
            var result = await _service.GetAsync(entityID);
            if (result == null) return NotFound();

            return Ok(_mapper.Map<TReadDto>(result));
        }

        [HttpGet]
        public virtual async Task<ActionResult<ICollection<TReadDto>>> GetAll()
        {
            var result = await _service.GetAll().ToListAsync();
            
            return Ok(_mapper.Map<List<TReadDto>>(result));
        }

        [HttpPatch]
        public virtual async Task<IActionResult> Patch([FromBody] TModifyDto entity)
        {
            await Task.Run(() => _service.Update(_mapper.Map<T>(entity))).ConfigureAwait(true);

            return NoContent();
        }

        [HttpPost]
        public virtual async Task<IActionResult> Post([FromBody] T entity)
        {
            var result = await _service.InsertAsync(entity);
            if (result == null) return BadRequest();

            return Ok(result);
        }

        [HttpPut]
        public virtual async Task<IActionResult> Put([FromBody] T entity)
        {
            var result = await Task.Run(() => _service.Update(entity)).ConfigureAwait(true);

            return Ok(result);
        }
    }
}
