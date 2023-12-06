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
            // classe tabuleiro de onde ve as operacóes em regal
            Tabuleiro tab = new Tabuleiro(8,8);

            // criando a peca e colocando ela na posiçao 

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0,0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1,3));
            tab.colocarPeca(new Rei(tab, Cor.Preta),  new Posicao(0,9));

            // imprimindo o tabuleiro na tela 
            Tela.imprirmirTabuleiro(tab);

           }
           catch (TabuleiroExecption e)
           {
              Console.WriteLine(e.Message);
           } 
            Console.WriteLine();
        }
    }
}
