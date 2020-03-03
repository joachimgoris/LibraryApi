using Library.Data;
using Library.Domain;
using Library.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    public class BaseController<T, TService> : ControllerBase, IBaseController<T>
        where T : Entity
        where TService : IBaseService<T, LibraryContext>
    {
        public TService _service;

        public BaseController(TService service)
        {
            _service = service;
        }

        [HttpDelete]
        public virtual async Task<IActionResult> Delete(string entityID)
        {
            await Task.Run(() => _service.Delete(entityID)).ConfigureAwait(true);

            return NoContent();
        }

        [HttpGet("{entityID}")]
        public virtual async Task<ActionResult<T>> Get(string entityID)
        {
            var result = await _service.GetAsync(entityID);
            if (result == null) return NotFound();

            return Ok(result);
        }

        [HttpGet]
        public virtual async Task<ActionResult<ICollection<T>>> GetAll()
        {
            var result = await _service.GetAll().ToListAsync();

            return Ok(result);
        }

        [HttpPatch]
        public virtual async Task<ActionResult<T>> Patch([FromBody] T entity)
        {
            var result = await Task.Run(() => _service.Update(entity)).ConfigureAwait(true);

            return Ok(result);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Post([FromBody] T entity)
        {
            var result = await _service.InsertAsync(entity);
            if (result == null) return BadRequest();

            return Ok(result);
        }

        [HttpPut]
        public virtual async Task<ActionResult<T>> Put([FromBody] T entity)
        {
            var result = await Task.Run(() => _service.Update(entity)).ConfigureAwait(true);

            return Ok(result);
        }
    }
}
