using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using freakingApi.Classes;
using System.Threading.Tasks;

namespace freakingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarvelController : ControllerBase
    {

        [HttpGet("/api/")]
        public async Task<List<Result>> Get()
        {
            Root character = await ApiService.SearchMarvelCharacters();
            //List<CharDTO> characters = new List<CharDTO>();
            
            return character.data.results;
        }
    }
}
