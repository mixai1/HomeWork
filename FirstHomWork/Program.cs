﻿using System;

namespace FirstHomWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input nember ?");
           var Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You Input nember {Number}");
            NumberDay(Number);



             static void NumberDay(int Number)
            {
                switch (Number)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;

                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;

                   default:
                        Console.WriteLine("No Day");
                        break;




                }
            }
        }

        
    }
}
