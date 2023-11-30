using System;
using System.Globalization;
using Xadrez.Tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p; 

            p = new Posicao(3,4);

            Console.WriteLine($"Informaçoes: {p}");

            Console.WriteLine();
        }
    }
}
