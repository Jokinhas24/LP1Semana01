using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integer Variables
            int i = 4;
            uint ui = 5U;
            long l = 3L;
            ulong ul = 5UL;
            
            //Prints Integer Variables on the Console
            Console.WriteLine(i);
            Console.WriteLine(ui);
            Console.WriteLine(l);
            Console.WriteLine(ul);

            //Char Variables
            char heart = '\u2665';
            char cloud = '\u2601';
            char arrow = '\u27BC';

            //Prints Char Variables on the Console
            Console.WriteLine(heart);
            Console.WriteLine(cloud);
            Console.WriteLine(arrow);

            //Real Variables
            float f = 2.35f;
            double dd = 6.88;
            decimal d = 1.79m;

            //Prints Real Variables on the Console
            Console.WriteLine(f);
            Console.WriteLine(dd);
            Console.WriteLine(d);

            //Boolean Variables
            bool cd1 = false;
            bool cd2 = 6 > 3;

            //Prints Boolean Variables on the Console
            Console.WriteLine(cd1);
            Console.WriteLine(cd2);


        }
    }
}
