using Microsoft.AspNetCore.Mvc;
using StrategyDesignPatternDemo.Services;

namespace StrategyDesignPatternDemo.Controllers;
[Route("api/[controller]")]
[ApiController]
public class FlightsController(IFileService fileService) : ControllerBase
{
    [HttpPost]
    public IActionResult Import(IFormFile file)
    {
        var flights = fileService.Import(
            Path.GetExtension(file.FileName),
            file.OpenReadStream());

        return Ok(flights);
    }
}
