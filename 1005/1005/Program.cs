using System;
using System.Globalization;

namespace _1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n1 = ((n1 * 3.5)+(n2 * 7.5))/11;
            Console.WriteLine("MEDIA = " + n1.ToString("F5", CultureInfo.InvariantCulture));
            Console.Read();
        }
    }
}
