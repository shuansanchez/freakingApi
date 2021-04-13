using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace freakingApi.Managers
{
    public class InfoDTO
    {
        public InfoDTO()
        {
            Characters = new List<CharDTO>();
        }
        public bool IsFinalData { get; set; }
        public List<CharDTO> Characters { get; set; }
    }
}
