using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("asn")]
    public string asn { get; set; }

    [JsonProperty("simple")]
    public string simple { get; set; }

    [JsonProperty("handle")]
    public string handle { get; set; }

    [JsonProperty("description")]
    public string description { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
