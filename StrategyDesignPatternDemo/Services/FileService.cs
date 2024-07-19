using StrategyDesignPatternDemo.Model;

namespace StrategyDesignPatternDemo.Services;

public class FileService : IFileService
{
    private readonly Dictionary<string, IFileParser> _fileParsers = new();

    public FileService(IEnumerable<IFileParser> fileParsers)
    {
        foreach (var fileParser in fileParsers)
        {
            _fileParsers.Add(fileParser.FileExtension, fileParser);
        }
    }
    public List<Flight> Import(string fileExtension, Stream fileStream)
    {
        if (!_fileParsers.TryGetValue(fileExtension, out var fileParser))
        {
            throw new ArgumentException("File extension is not supported",
                nameof(fileExtension));
        }

        return fileParser.Parse(fileStream);
    }
}
