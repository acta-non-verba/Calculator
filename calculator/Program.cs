using System;
using calculator.Abstractions;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculateOperation operationAdd=new Adder();
            ICalculateOperation operationSubtract=new Subtractor();
            double result;
            result= new CalculateOperation(operationAdd).Calculate(2,2);
            result=new CalculateOperation(operationSubtract).Calculate(3,2);
        }
    }
}
