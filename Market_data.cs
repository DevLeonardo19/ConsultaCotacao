using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotação
{
    public class Market_data
    {

        [JsonProperty(PropertyName = "high")]
        public decimal Maximo { get; set; }

        [JsonProperty(PropertyName = "low")]
        public decimal Minimo { get; set; }

    }
}
