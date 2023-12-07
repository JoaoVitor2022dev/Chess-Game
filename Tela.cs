using Xadrez.tabuleiro;
using Xadrez.tabuleiro.Enums;

namespace Xadrez
{
    class Tela
    {
        public static void imprirmirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else 
                    {
                       Tela.imprimirPeca(tab.peca(i,j));
                       Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }
        public static void imprimirPeca(Peca peca)
        {
           if (peca.cor == Cor.Branca)
           {
              Console.WriteLine(peca);
           }
           else
           {
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(peca);
            Console.ForegroundColor = aux;
           }
        }
    }
}