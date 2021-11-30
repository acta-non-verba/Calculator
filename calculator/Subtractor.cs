using calculator.Abstractions;
namespace calculator
{
    public class Subtractor : ICalculateOperation
    {
        public double CalculateOperation(double x, double y)
        {
            return x - y;
        }
    }
}