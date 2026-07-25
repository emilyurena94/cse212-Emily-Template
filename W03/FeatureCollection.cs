using System.Text.Json.Serialization;

// Represents the root object returned by the USGS earthquake API
public class FeatureCollection
{
    [JsonPropertyName("features")]
    public List<Feature> Features { get; set; }
}

// Represents a single earthquake entry
public class Feature
{
    [JsonPropertyName("properties")]
    public Properties Properties { get; set; }
}

// Stores the earthquake information used in the summary
public class Properties
{
    [JsonPropertyName("place")]
    public string Place { get; set; }

    [JsonPropertyName("mag")]
    public double Mag { get; set; }
}