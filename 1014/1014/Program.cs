using System;
using System.Globalization;

namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable definitions
            int distanceTraveled;
            double totalFuel, total;
            //Values assaignment
            distanceTraveled = Convert.ToInt32(Console.ReadLine());
            totalFuel = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Calculations
            total = distanceTraveled / totalFuel;
            //Printing on the screen
            Console.WriteLine(total.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
            //Wait until you digit something
            Console.Read();
        }
    }
}
