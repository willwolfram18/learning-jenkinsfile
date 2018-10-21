using System;
using Xunit;
using WebApp.Controllers;
using WebApp.Models.Calculator;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Tests
{
    public class MathControllerTests
    {
        [Fact]
        public void When_Add_Is_Called_Then_The_Sum_Is_Returned()
        {
            var controller = new MathController(new Calculator());
            var numbers = new [] { 1, 5, 3 };

            var result = controller.AddNumbers(numbers) as OkObjectResult;

            Assert.Equal(result.Value, numbers.Sum());
        }
    }
}
