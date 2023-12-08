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
           try
           {
            PartidaXadrex partida = new PartidaXadrex();

            while (!partida.terminada)
            {
                Console.Clear();
                Tela.imprirmirTabuleiro(partida.tab);

                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Origem: "); 
                Posicao origem = Tela.lerPosicaoXadrez().toPosicao(); 
                Console.Write("Destino: ");
                Posicao destino = Tela.lerPosicaoXadrez().toPosicao(); 

                partida.executaMovimento(origem, destino);
            } 

            }
            catch (TabuleiroExecption e)
            {
            Console.WriteLine(e.Message);
            } 
            Console.WriteLine();
        }
    }
}
