using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using freakingApi.Managers;

namespace freakingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarvelController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<CharDTO> Get()
        {
            List<CharDTO> characters = new List<CharDTO>();
            return characters;
           
        }


    }
}
