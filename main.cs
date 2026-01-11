using System;
using System.Data;

namespace project
{
    class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            int number = 1;
            while (number <= 100)
            {
                Console.WriteLine(number);
                number++;
            }
            do
            {
                Console.WriteLine(number);
            } while (number <= 100);


        }
    }
}
