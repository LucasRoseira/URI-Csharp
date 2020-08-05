using System;
using System.Globalization;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable definitions
            int hoursSpent, averegeSpeed;
            double liters;
            //Values assaignment
            hoursSpent = Convert.ToInt32(Console.ReadLine());
            averegeSpeed = Convert.ToInt32(Console.ReadLine());
            //Calculations
            liters = (averegeSpeed / 12.0) * hoursSpent;
            //Printing on the screen
            Console.WriteLine(liters.ToString("F3", CultureInfo.InvariantCulture));
            //Wait until you digit something
            Console.Read();
        }
    }
}
