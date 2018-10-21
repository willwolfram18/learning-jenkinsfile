using System.Linq;

namespace WebApp.Models.Calculator
{
    public class Calculator : ICalculate
    {
        public int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}