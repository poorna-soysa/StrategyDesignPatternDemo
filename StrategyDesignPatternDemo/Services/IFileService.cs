using StrategyDesignPatternDemo.Model;

namespace StrategyDesignPatternDemo.Services;

public interface IFileService
{
    List<Flight> Import(string fileExtension, Stream fileStream);
}
