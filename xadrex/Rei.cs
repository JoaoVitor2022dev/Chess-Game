using Xadrez.tabuleiro.Enums;
using Xadrez.tabuleiro;

namespace Xadrez.xadrex
{
    class Rei : Peca 
    {
        public Rei(Tabuleiro tabuleiro, Cor cor ): base(tabuleiro, cor)
        {}
        public override string ToString()
        {
            return "R";
        }
    }
}