using System;
//Import para utilizar o CultureInfo
using System.Globalization; 

namespace _1006
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Definição de Váriaveis
            double A, B, C, MEDIA;

            /* Atribuição de Váriaveis.
             * 
             A leitura de dados de um tipo de valor no visual studio são regrados 
             * e precisam de castings, ou seja,
               precisam ser convertidos para o tipo que se deseja
               além disso precisa se utilizar o CultureInfo para formatar o número*/
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Cálculos
            MEDIA = ((A * 2.0) + (B * 3.0) + (C * 5.0)) / 10;
            //Console.WriteLine
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"), CultureInfo.InvariantCulture);
            /*Como o terminal faz os calculos e fecha o terminal precisa-se 
             colocar o Console.ReadLine */
            Console.ReadLine();
        }
    }
}
