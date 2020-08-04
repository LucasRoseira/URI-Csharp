using System;
using System.Globalization;

namespace _1002
{
    class Program
    {
        static void Main(string[] args)
        {
            /* area = π . raio2 π = 3.14159:*/
            double raio;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            raio = 3.14159 * Math.Pow(raio, 2.0);
            Console.WriteLine("A=" + raio.ToString("F4", CultureInfo.InvariantCulture));
            //Console.ReadLine();
        }
    }
}