using Library.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    interface IBaseController<T, TReadDto, TCreateDto, TModifyDto>
        where T : Entity
    {
        Task<IActionResult> Post([FromBody]TCreateDto entity);

        Task<ActionResult<TReadDto>> Get(string entityID);

        Task<ActionResult<ICollection<TReadDto>>> GetAll();

        Task<IActionResult> Patch([FromBody]TModifyDto entity);

        Task<IActionResult> Put([FromBody]T entity);

        Task<IActionResult> Delete(string entityID);
    }
}
