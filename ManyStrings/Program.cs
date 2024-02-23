using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strings Build
            string cardsymbols = "\u2660 \u2665 \u2663 \u2666";
            string train = "I'm a cho cho train \"ChhOOoO ChOOooOO\"";
            string dragon = "I'm a flying dragon,\n FLAP FLAP FLAP";

            //Printing Strings
            Console.WriteLine(cardsymbols);
            Console.WriteLine(train);
            Console.WriteLine(dragon);

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

            //Prints all strings
            Console.WriteLine(scream);
            Console.WriteLine(heartbro);
            Console.WriteLine(notfour);


        }
    }
}
