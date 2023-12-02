using System;
using System.Globalization;
using Xadrez.tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Tabuleiro tab = new Tabuleiro(8,8);

            Tela.imprirmirTabuleiro(tab);

            Console.WriteLine();
        }
    }
}
