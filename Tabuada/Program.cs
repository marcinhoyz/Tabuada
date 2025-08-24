using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero ;
            Console.WriteLine("Informe o número que deseja ver a tabuda: ");
            numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");

            }
        }
    }
}


