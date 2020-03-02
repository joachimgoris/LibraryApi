using Library.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    interface IBaseController<T>
        where T : Entity
    {
        Task<ActionResult<T>> Get(string entityID);

        Task<ActionResult<ICollection<T>>> GetAll();
    }
}
