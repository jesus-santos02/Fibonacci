using System;
using System.Diagnostics;

namespace Fibonacci_Memoizacion
{
    class Program
    {
        static int N = 10;
        static int[] valoresC = new int[N];
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < N; i++)
            {
                valoresC[i] = -1;
            }

            sw.Start();
            int valor = FibM(5);
            sw.Stop();

            Console.WriteLine($"Valor: {valor} \nTiempo Transcurrido: {sw.ElapsedTicks:N0}");
            Console.ReadKey();
        }

        static int FibM(int n)
        {
            if (valoresC[n] == -1) 
            {
                if (n == 1)
                    return valoresC[n] = 1;
                else if (n == 0)
                    return valoresC[n] = 0;
                else
                    valoresC[n] = FibM(n - 1) + FibM(n - 2);
            }
            return valoresC[n];

        }
    }
}
