using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex6 Variables
            double xx = 1.23456;
            int ii = 19;

            //Strings Build
            string cardsymbols = "\u2660 \u2665 \u2663 \u2666";
            string train = "I'm a cho cho train \"ChhOOoO ChOOooOO\"";
            string dragon = "I'm a flying dragon,\n FLAP FLAP FLAP";

            //Printing Strings
            Console.WriteLine(cardsymbols);
            Console.WriteLine(train);
            Console.WriteLine(dragon);

            //Just for better reading
            Console.WriteLine("\n");

            //Variable Declaration
            string a = "aaaaaaaaaaaah";
            char heart = '\u2665';
            int four = 4;
            int five = 5;

            //String Concatenation
            string scream = "My head hurts " + a;

            //String Interpolation
            string heartbro = $"I'm {heart}broken";
            string notfour = $"This number is not four: {four + five}";

            //Prints all new strings
            Console.WriteLine(scream);
            Console.WriteLine(heartbro);
            Console.WriteLine(notfour);

            //Just for better reading
            Console.WriteLine("\n");

            //Prints xx in
            //Real with 2 decimals
            string xx_f = $"{xx:f2}";
            Console.WriteLine(xx_f);

            //Percent with 1 decimal
            string xx_p = $"{xx:p1}";
            Console.WriteLine(xx_p);

            //Prints ii in
            //Hexadecimal
            string ii_h = $"{ii:x}";
            Console.WriteLine(ii_h);

            //Coin
            string ii_c = $"{ii:c}";
            Console.WriteLine(ii_c);
        }
    }
}
