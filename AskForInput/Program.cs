﻿using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for Number
            Console.WriteLine("Please insert a Integer Number:");
            string n1 = Console.ReadLine();

            //Converge
            int numb1 = int.Parse(n1);

            //Ask for second floating Number
            Console.WriteLine("Please insert a second float Number:");
            string n2 = Console.ReadLine();

            //Converge
            float numb2 = float.Parse(n2);

            //sum the 2 number
            float result = numb1 + numb2;
            Console.WriteLine($"The sum of {numb1} and {numb2} is {result}");

        }
    }
}
