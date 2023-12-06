using System;
using System.Globalization;
using Xadrez.tabuleiro;
using Xadrez.xadrex;
using Xadrez.tabuleiro.Enums;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
           
           PosicaoXadrex pos = new PosicaoXadrex('a', 1);

           Console.WriteLine(pos);

           Console.WriteLine(pos.toPosicao());

           // Console.WriteLine(pos.toPosicao());

           Console.WriteLine();
        }
    }
}
