using StrategyDesignPatternDemo.Model;
using System.Text.Json;

namespace StrategyDesignPatternDemo.Services;

public class JsonParser : IFileParser
{
    public string FileExtension => ".json";

    public List<Flight> Parse(Stream fileStream)
    {
        var jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        var flights = JsonSerializer.Deserialize<List<Flight>>(
                  fileStream,
                 jsonSerializerOptions);


        if (flights is { Count: 0 })
        {
            return (List<Flight>)Enumerable.Empty<Flight>();
        }

        return flights;
    }
}
