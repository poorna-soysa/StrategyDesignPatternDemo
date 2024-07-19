using StrategyDesignPatternDemo.Model;

namespace StrategyDesignPatternDemo.Services;

public interface IFileParser
{
    string FileExtension { get; }
    List<Flight> Parse(Stream fileStream);
}
