using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

public class Conversao_classe
{
    public Dictionary<string, CurrencyData> Data { get; set; }
}

public class CurrencyData
{
    public string code { get; set; }
    public string codein { get; set; }
    public string name { get; set; }
    public decimal high { get; set; }
    public decimal low { get; set; }
    public decimal varBid { get; set; }
    public decimal pctChange { get; set; }

    [JsonProperty(PropertyName = "bid")]
    public decimal bid { get; set; }
    public decimal ask { get; set; }
    public string timestamp { get; set; }
    public string create_date { get; set; }
}
