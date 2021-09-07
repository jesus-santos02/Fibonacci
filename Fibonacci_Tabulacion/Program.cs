using System;
using System.Diagnostics;

namespace Fibonacci_Tabulacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            int valor = FibT(39);
            sw.Stop();

            Console.WriteLine($"Valor: {valor} \nTiempo Transcurrido: {sw.ElapsedTicks:N0}");
            Console.ReadKey();
        }

        static int FibT(int n)
        { 
            //Creamos el arreglo donde se guardará
            int[] valores = new int[n + 1];

            //Inicializamos los valores conocidos (seed)
            valores[0] = 0;
            valores[1] = 1;

            for (int m = 2; m <= n; m++)
            {
                //Calculamos el valor, los anteriores fueron previamente calculados
                valores[m] = valores[m - 1] + valores[m - 2];
            }

            //Retornamos el valor
            return valores[n];
        }
    }
}
