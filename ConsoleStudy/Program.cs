using System;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key;
            while (true)
            {
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.F)
                {
                    Console.WriteLine("FFFFFFFF");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
