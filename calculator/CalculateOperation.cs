using calculator.Abstractions;

namespace calculator
{
    public class CalculateOperation
    {
        private readonly ICalculateOperation _operation;
        public CalculateOperation(ICalculateOperation operation)
        {
            _operation=operation;
        }
      public double Calculate(double x ,double y)
      {
          return _operation.CalculateOperation(x,y);
      }
    }
}