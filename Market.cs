using Newtonsoft.Json;

namespace Cotação
{
    public class Market
    {
        [JsonProperty("currencies")]
        public Currency Currency { get; set; }
    }

    public class Currency
    {

        [JsonProperty(PropertyName = "name")]
        public string Nome { get; set; }

        [JsonProperty(PropertyName = "buy")]
        public decimal Compra { get; set; }

        [JsonProperty(PropertyName = "sell")]
        public decimal Venda { get; set; }

        [JsonProperty(PropertyName = "variation")]
        public decimal Variacao { get; set; }

    }

}
