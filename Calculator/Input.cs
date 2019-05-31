using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Input
    {
        public int Inputnumber()
        {
            Console.WriteLine("input number");
            var x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
    }
}
