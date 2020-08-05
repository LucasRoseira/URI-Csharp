using System;
using System.Globalization;

namespace _1012
{
    class Program
    {
        // (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.
        static void Main(string[] args)
        {
            //Variable definitions
            string[] linha = Console.ReadLine().Split(' ');
            double[] values = new double[3];
            double total;
            //Values assaignment
            values[0] = double.Parse(linha[0], CultureInfo.InvariantCulture);
            values[1] = double.Parse(linha[1], CultureInfo.InvariantCulture);
            values[2] = double.Parse(linha[2], CultureInfo.InvariantCulture);
            //Calculations and printings
            total = (values[0] * values[2]) / 2;
            Console.WriteLine("TRIANGULO: " + total.ToString("F3", CultureInfo.InvariantCulture));

            total = 3.14159 * Math.Pow(values[2], 2.0);
            Console.WriteLine("CIRCULO: " + total.ToString("F3", CultureInfo.InvariantCulture));

            total = ((values[0] + values[1]) / 2) * values[2];
            Console.WriteLine("TRAPEZIO: " + total.ToString("F3", CultureInfo.InvariantCulture));

            total = Math.Pow(values[1], 2.0);
            Console.WriteLine("QUADRADO: " + total.ToString("F3", CultureInfo.InvariantCulture));

            total = values[0] * values[1];
            Console.WriteLine("RETANGULO: " + total.ToString("F3", CultureInfo.InvariantCulture));

            //Wait until you digit something
            Console.Read();
        }
    }
}
