using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace freakingApi.Classes
{
    public class Data
    {
        public string offset { get; set; }
        public string limit { get; set; }
        public string total { get; set; }
        public string count { get; set; }
        public List<Result> results { get; set; }
    }
}
