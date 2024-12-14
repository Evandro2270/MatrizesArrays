using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                string[,] nome = new string[3, 3];

                for (int linha = 0; linha < 3; linha++)
                {
                    for (int coluna = 0; coluna < 3; coluna++)
                    {
                        nome[linha, coluna] = Console.ReadLine();
                    }
                }
                
                Console.WriteLine();
                for (int linha = 0; linha < 3; linha++)
                {
                    for (int coluna = 0; coluna < 3; coluna++)
                    {
                        Console.Write(nome[linha, coluna] + " "); // "Espaço em branco" Concatenação
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}