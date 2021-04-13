using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace freakingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarvelController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Root> Get()
        {
            List<Root> characters = new List<Root>();
            return characters;
        }
    }
}
