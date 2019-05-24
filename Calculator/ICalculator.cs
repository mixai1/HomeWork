using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    interface ICalculator
    {   
       void Multiplication(int value)
        {
            for (int i = 1; i <= 10; i++)
            {
                 int result = value * i;
                Console.WriteLine($"{value}*{i}={result}");
            }
        }
    }
}
