using System;

//DIFERENCA = (A * B - C * D).
namespace _1007
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Variable definitions
             'values' is an array of int */
            int[] values = new int[4];
            int diferenca;
            //Values assaignment (Iterating Array)
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = int.Parse(Console.ReadLine());
            }
            //Calculations
            diferenca = values[0] * values[1] - values[2] * values[3];
            //printing on the screen
            Console.WriteLine("DIFERENCA = " + diferenca);
            //Wait until you digit something
            Console.ReadLine();
        }
    }
}
