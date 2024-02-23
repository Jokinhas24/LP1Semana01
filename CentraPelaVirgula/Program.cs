using System;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for float number
            Console.WriteLine("Insert 4 float Numbers:");
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            string n3 = Console.ReadLine();
            string n4 = Console.ReadLine();

            //Converts to float with 2 decimals
            float n1_f = float.Parse(n1);
            float n2_f = float.Parse(n2);
            float n3_f = float.Parse(n3);
            float n4_f = float.Parse(n4);

            //Formatting
            string numb1 = $"{n1_f,6:f2}";
            string numb2 = $"{n2_f,6:f2}";
            string numb3 = $"{n3_f,6:f2}";
            string numb4 = $"{n4_f,6:f2}";

            //Prints numbers in the Console
            Console.WriteLine(numb1);
            Console.WriteLine(numb2);
            Console.WriteLine(numb3);
            Console.WriteLine(numb4);



        }
    }
}
