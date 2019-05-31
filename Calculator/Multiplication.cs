using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Multiplication
    {
       
        public void Multip (int number)
        {
            
            for (int i = 1; i <= 10; i++)
            {
                var result = number * i;
                Console.WriteLine($"{i} * {number} = {result}");
            }
        }
    }
}
