using Microsoft.AspNetCore.Mvc;

namespace ExApp.controllers;

[Route("api/[controller]")]
[ApiController]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Check()
    {
        return Ok(new { 
            status = "Healthy", 
            timestamp = DateTime.UtcNow,
            service = "Exam-API-Service"
        });
    }
}    