using System;
using System.Globalization;
namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable definitions
            int numFunc, hoursWorked;
            double valuePerHour, totalSalary;
            //Values assaignment
            numFunc = int.Parse(Console.ReadLine());
            hoursWorked = int.Parse(Console.ReadLine());
            valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Calculations
            totalSalary = hoursWorked * valuePerHour;
            //Printing on the screen
            Console.WriteLine("NUMBER = " + numFunc);
            Console.WriteLine("SALARY = U$ " + totalSalary.ToString("F2"), CultureInfo.InvariantCulture);
            //Wait until you digit something
            Console.ReadLine();
        }
    }
}
