using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int before, now, next;
            before = 0;
            now = 1;
            for (int i = 0; i < 25; i++)
            {
                next = before + now;
                before = now;
                now = next;
                Console.WriteLine(next);
            }
           
            Console.Read();
        }
    }
}
