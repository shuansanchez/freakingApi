using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace freakingApi.Classes
{
    public class Result
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string modified { get; set; }
        public string resourceURI { get; set; }
        public List<Url> urls { get; set; }
        public Thumbnail thumbnail { get; set; }
        public Comics comics { get; set; }
        public Stories stories { get; set; }
        public Events events { get; set; }
        public Series series { get; set; }
    }
}
