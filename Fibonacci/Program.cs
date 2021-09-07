using System;
using System.Diagnostics;
using System.Collections;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            int valor = Fib(40);
            sw.Stop();

            Console.WriteLine($"Valor: {valor} \nTiempo Transcurrido: {sw.ElapsedTicks:N0}");
            Console.ReadKey();
        }
        static int Fib(int n)
        {
            if (n == 0 || n == 1)
                return n;
            
            return Fib(n - 1) + Fib(n - 2);
        }

    }
}
