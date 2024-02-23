using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for Number
            Console.WriteLine("Please insert a Integer Number:");
            string n = Console.ReadLine();
            int numb = int.Parse(n);

            //Printing that number
            Console.WriteLine(numb);
        }
    }
}
