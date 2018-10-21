using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Calculator;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/math")]
    public class MathController : Controller
    {
        private readonly ICalculate _calculator;

        public MathController(ICalculate calculator)
        {
            _calculator = calculator;
        }

        [HttpGet("add")]
        public IActionResult AddNumbers([FromQuery(Name = "numbers")]int[] numbers)
        {
            return Ok(_calculator.Add(numbers));
        }
    }
}