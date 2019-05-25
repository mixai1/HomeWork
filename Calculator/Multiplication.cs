using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Multiplication
    {
        public int Input()
        {
            Console.WriteLine("input nuber");
           var x=Convert.ToInt32(Console.ReadLine());
            return x;
        }
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
