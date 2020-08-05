using System;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable definitions
            int[] values = new int[3];
            int maiorABC;
            //Values assaignment
            string[] linha1 = Console.ReadLine().Split(' ');
            //Piece 1
            values[0] = int.Parse(linha1[0]);
            values[1] = int.Parse(linha1[1]);
            values[2] = int.Parse(linha1[2]);
            //Calculations
            maiorABC = (values[0] + values[1] + Math.Abs(values[0] - values[1])) / 2;
            maiorABC = (maiorABC + values[2] + Math.Abs(maiorABC - values[2])) / 2;
            //Printing on the screen
            Console.WriteLine(maiorABC + " eh o maior");
            //Wait until you digit something
            Console.Read();
        }
    }
}
