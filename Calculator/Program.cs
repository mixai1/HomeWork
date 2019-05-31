using System;

namespace Calculator
{
    class Program 

    {
        static void Main(string[] args)
        {
           Multiplication Multiplication = new Multiplication();
            Input input = new Input();
            Multiplication.Multip(input.Inputnumber());

        }


    }
}
