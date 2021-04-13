using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace freakingApi.Classes
{
    public class Series
    {
        public string available { get; set; }
        public string returned { get; set; }
        public string collectionURI { get; set; }
        public List<Item> items { get; set; }
    }
}
