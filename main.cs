using System;
using System.Data;
using System.Runtime.CompilerServices;

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

            for(int i = 50; i <= 70; i++)
            {
                Console.WriteLine(number);
            }
        }
    }
}
