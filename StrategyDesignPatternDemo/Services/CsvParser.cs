using StrategyDesignPatternDemo.Model;

namespace StrategyDesignPatternDemo.Services;

public class CsvParser : IFileParser
{
    public string FileExtension => ".csv";

    public List<Flight> Parse(Stream fileStream)
    {
        throw new NotImplementedException();
    }
}