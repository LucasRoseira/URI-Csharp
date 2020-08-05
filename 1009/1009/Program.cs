using System;
using System.Globalization;
namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable definitions
            String nameFunc;
            double salaryFixed,salesMonth,  totalSalary;
            //Values assaignment
            nameFunc = Console.ReadLine();
            salaryFixed = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salesMonth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Calculations
            totalSalary =  salesMonth * 0.15 + salaryFixed ;
            //Printing on the screen
            Console.WriteLine("TOTAL = R$ " + totalSalary.ToString("F2"), CultureInfo.InvariantCulture);
            //Wait until you type something
            Console.ReadLine();
        }
    }
}
