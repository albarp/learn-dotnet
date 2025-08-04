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

    [HttpGet("average")]
    public IActionResult GetAverage(){
        return Ok(_statistics.Average());
    }
}