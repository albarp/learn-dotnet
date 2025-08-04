using Microsoft.AspNetCore.Mvc;

namespace app.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StatisticsController : ControllerBase {
    public StatisticsController() {

    }

    [HttpGet("average")]
    public IActionResult GetAverage(){
        return Ok("average endpoint");
    }
}