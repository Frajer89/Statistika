using System;

namespace Statistika
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(false);
            } while (keyInfo.Key != ConsoleKey.Escape);
        }  
    }
}
