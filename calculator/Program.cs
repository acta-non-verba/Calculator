using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;
            result= new CalculateOperation().Add(2,2);
            result=new CalculateOperation().Subtract(3,2);
        }
    }
}
