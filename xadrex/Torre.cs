using Xadrez.tabuleiro.Enums;
using Xadrez.tabuleiro;

namespace Xadrez.xadrex
{
    class Torre : Peca 
    {
        public Torre(Tabuleiro tabuleiro, Cor cor ): base(tabuleiro, cor)
        {}
        public override string ToString()
        {
            return "T";
        }
    }
}