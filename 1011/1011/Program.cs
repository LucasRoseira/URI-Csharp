using System;
using System.Globalization;

namespace _1011
{
    class Program
    {
        // (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.
        static void Main(string[] args)
        {
            //Variable definitions
            int radius;
            double area;
            //Values assaignment
            radius = int.Parse(Console.ReadLine());
            //Calculations
            area = (4 / 3.0) * 3.14159 * Math.Pow(radius, 3.0);
            //Printing on the screen
            Console.WriteLine("VOLUME = " + area.ToString("F3", CultureInfo.InvariantCulture));
            //Wait until you digit something
            Console.Read();
        }
    }
}