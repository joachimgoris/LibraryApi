using Library.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    interface IBaseController<T>
        where T : Entity
    {
        Task<IActionResult> Post([FromBody]T entity);

        Task<ActionResult<T>> Get(string entityID);

        Task<ActionResult<ICollection<T>>> GetAll();

        Task<ActionResult<T>> Patch([FromBody]T entity);

        Task<ActionResult<T>> Put([FromBody]T entity);

        Task<IActionResult> Delete(string entityID);
    }
}
