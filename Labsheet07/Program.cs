using System;

namespace Labsheet07
{
    class Program
    {
        const string DEFAULT_TEXT = "0123456789";
        const string ACTUAL_TEXT = "6002526";

        DigitArt digitArt;


        public Program()
        {
            Console.Title = String.Format("Labsheet07 - Print multiline number : {0}", ACTUAL_TEXT);
            digitArt = new DigitArt();
        }

        void Run()
        {
            Console.WriteLine("----------");
            Console.WriteLine("All template...");
            Console.WriteLine("----------");

            digitArt.WriteLine(DEFAULT_TEXT);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------");
            Console.WriteLine("Actual Text : ");
            Console.WriteLine("----------");

            digitArt.WriteLine(ACTUAL_TEXT);

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            new Program().Run();
        }
    }
}