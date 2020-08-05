using System;

namespace _1016
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable definitions
            int distance;
            //Values assaignment
            //Piece 1
            distance = Convert.ToInt32(Console.ReadLine());
            //Calculations
            distance *= 2   ;
            //Printing on the screen
            Console.WriteLine(distance + " minutos");
            //Wait until you digit something
            Console.Read();
        }
    }
}
