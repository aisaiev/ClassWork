using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class Currency
    {
        [JsonProperty("ccy")]
        public string Ccy { get; set; }

        [JsonProperty("base_ccy")]
        public string BaseCcy { get; set; }

        [JsonProperty("buy")]
        public string Buy { get; set; }

        [JsonProperty("sale")]
        public string Sale { get; set; }
    }
}
