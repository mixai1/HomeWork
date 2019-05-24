using System;

namespace Calculator
{
    class Program : ICalculator
    {
        static void Main(string[] args)
        {
            ICalculator.Multiplication(x=Convert.ToInt32(Console.ReadLine()));

        }

        public void Multiplication(int value)
        {
            throw new NotImplementedException();
        }
    }
}
