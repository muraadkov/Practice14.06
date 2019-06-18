using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice24._06
{
    public class Characters
    {

        [JsonProperty("patch")]
        public string patch { get; set; }

        [JsonProperty("classes")]
        public IList<string> classes { get; set; }

        [JsonProperty("sets")]
        public IList<string> sets { get; set; }

        [JsonProperty("standard")]
        public IList<string> standard { get; set; }

        [JsonProperty("wild")]
        public IList<string> wild { get; set; }

        [JsonProperty("types")]
        public IList<string> types { get; set; }

        [JsonProperty("factions")]
        public IList<string> factions { get; set; }

        [JsonProperty("qualities")]
        public IList<string> qualities { get; set; }

        [JsonProperty("races")]
        public IList<string> races { get; set; }

        [JsonProperty("locales")]
        public IList<string> locales { get; set; }
    }

}
