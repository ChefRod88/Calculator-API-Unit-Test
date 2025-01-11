using Microsoft.AspNetCore.Mvc;
using Domain;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculateController : ControllerBase
{
    [HttpGet("Add/{left}/{right})}")] //defining a route
    public int Get(int left, int right)
    {
        return new Calculator().Sum(left, right);
    }
}