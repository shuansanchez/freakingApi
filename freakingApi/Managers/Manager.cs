using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace freakingApi.Managers
{
    [ApiController]
    [Route("[controller]")]
    public class Manager : ControllerBase
    {
        public static async Task<InfoDTO> GetCharacters(int limit, int offset)
        {
            var result = new InfoDTO();
            var data = await ApiService.SearchMarvelCharacters(limit, offset);//devuelve obj de tipo root
            if (data != null)
            {
                result.IsFinalData = data.data.results.Count != limit;
                result.Characters.AddRange(data.data.results.Select(x => new CharDTO()
                {
                    Description = x.description,
                    Id = x.id,
                    Name = x.name,
                    Image = x.thumbnail.path + "/portrait_xlarge." + x.thumbnail.extension
                }));
            }
            return result;
        }
    }
}
