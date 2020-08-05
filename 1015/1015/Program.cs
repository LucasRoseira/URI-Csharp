using System;
using System.Globalization;
namespace _1015
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable definitions
            double x1, x2, y1, y2, distance;
            //Values assaignment
            string[] line1 = Console.ReadLine().Split(' ');
            string[] line2 = Console.ReadLine().Split(' ');
            //Line 1
            x1 = double.Parse(line1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(line1[1], CultureInfo.InvariantCulture);
            //Line2
            x2 = Convert.ToDouble(line2[0], CultureInfo.InvariantCulture);
            y2 = Convert.ToDouble(line2[1], CultureInfo.InvariantCulture);
            //Calculations
            distance = Math.Sqrt(Math.Pow(x2-x1, 2.0) + Math.Pow(y2-y1, 2.0));
            //Printing on the screen
            Console.WriteLine(distance.ToString("F4", CultureInfo.InvariantCulture));
            //Wait until you digit something
            Console.Read();
        }
    }
}
