using Microsoft.AspNetCore.Mvc;
using app.domain;

namespace app.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StatisticsController : ControllerBase {
    private readonly Statistics _statistics;

    public StatisticsController(Statistics statistics) {
        _statistics = statistics;
    }

    [HttpPost("average")]
    public IActionResult GetAverage([FromBody] int[] numbers) {
        if (numbers == null || numbers.Length == 0) {
            return BadRequest("Numbers array cannot be null or empty");
        }
        
        return Ok(_statistics.Average(numbers));
    }
}