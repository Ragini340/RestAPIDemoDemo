using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPIDemoDemo.Model;

namespace RestAPIDemoDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Person>> GetAll()
        {
            return new[]
            {
            new Person { Name = "Alica" },
            new Person { Name = "Zack" },
            new Person { Name = "Will" }
        };
        }
    }
}

