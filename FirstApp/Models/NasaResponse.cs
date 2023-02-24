using System.Text.Json.Serialization;

namespace FirstApp.Models;
public record NasaResponse
{
[JsonPropertyName("copyright")]

public string copyright{get; init;}

[JsonPropertyName("date")]

public string date{get; init;}

[JsonPropertyName("explanation")]

public string explanation{get; init;}

[JsonPropertyName("hdurl")]

public string hdurl{get; init;}

[JsonPropertyName("media_type")]

public string MediaType{get; init;}

[JsonPropertyName("url")]

public string url{get; init;}

[JsonPropertyName("service_version")]

public string ServiceVersion{get; init;}

[JsonPropertyName("title")]

public string title{get; init;}

}