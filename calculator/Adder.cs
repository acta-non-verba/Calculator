using calculator.Abstractions;
namespace calculator{
    public class Adder : ICalculateOperation
    {
        public double CalculateOperation(double x, double y)
        {
            return x+y;
        }
    }
}