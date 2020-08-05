using System;
using System.Globalization;

namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable definitions
            int codPiece1, quantityPiece1;
            int codPiece2, quantityPiece2;
            double unitPrice1, unitPrice2, total;
            //Values assaignment
            string[] linha1 = Console.ReadLine().Split(' ');
            string[] linha2 = Console.ReadLine().Split(' ');
            //Piece 1
            codPiece1 = int.Parse(linha1[0]);
            quantityPiece1 = int.Parse(linha1[1]);
            unitPrice1 = double.Parse(linha1[2], CultureInfo.InvariantCulture);
            //Piece 2
            codPiece2 = int.Parse(linha2[0]);
            quantityPiece2 = int.Parse(linha2[1]);
            unitPrice2 = Convert.ToDouble(linha2[2], CultureInfo.InvariantCulture);
            //Calculations
            total = (quantityPiece1 * unitPrice1) + (quantityPiece2 * unitPrice2);
            //Printing on the screen
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            //Wait until you digit something
            Console.Read();
        }
    }
}
